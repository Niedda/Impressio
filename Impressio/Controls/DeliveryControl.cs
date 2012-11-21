using System;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class DeliveryControl : DeliveryControlBase
  {
    public DeliveryControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override GridView GridView
    {
      get { return viewDeliveryPosition; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                                         {
                                           colPosition,
                                           colQuantity,
                                         });
      }
    }

    public override List<object> EditorsToCheck
    {
      get
      {
        return _editors ?? (_editors = new List<object>
                                         {
                                           deliveryDate,
                                         });
      }
    }

    public override RibbonPage RibbonPage
    {
      get
      {
        return _ribbonPage ?? (_ribbonPage = RibbonTools.GetSimplePage(new List<BarButtonItem>
                                                                         {
                                                                           RibbonTools.GetRefreshButton(ReloadControl),
                                                                           RibbonTools.GetPrintButton("Lieferschein drucken", PrintDelivery),
                                                                           RibbonTools.GetDeleteButton(DeleteRow),
                                                                         }, "Lieferschein"));
      }
    }
    
    public override void ReloadControl()
    {
      if (Delivery == null) { throw new InvalidOperationException("Delivery cannot be null"); }

      _deliveryPosition.ClearObjectList();
      Delivery.LoadSingleObject();
      clientBindingSource.DataSource = Delivery.AvaibleClients;
      addressBindingSource.DataSource = Delivery.AvaibleAddresses;
      deliveryBindingSource.DataSource = Delivery;
      deliveryPositionBindingSource.DataSource = _deliveryPosition.LoadObjectList(DeliveryPosition.Columns.FkDeliveryPositionDelivery, Delivery.Identity);
      positionComboEdit.Items.AddRange(_deliveryPosition.LoadDescriptions(Delivery.FkDeliveryOrder));
    }

    public override bool ValidateControl()
    {
      ValidateChildren();

      if(ValidateRow() && !ErrorProvider.HasErrors)
      {
        Delivery.SaveObject();
        return true;
      }
      return false;
    }

    public Delivery Delivery;

    private void ViewDeliveryPositionInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewDeliveryPosition.SetFocusedRowCellValue(colFkDeliveryPositionDelivery, Delivery.Identity);
    }

    private void PrintDelivery(object sender, ItemClickEventArgs e)
    {
      Delivery.LoadDeliveryReport();
    }

    private RibbonPage _ribbonPage;

    private readonly DeliveryPosition _deliveryPosition = new DeliveryPosition();

    private List<object> _editors;

    private List<GridColumn> _columns;
  }
}