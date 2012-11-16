using System;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
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

    public override void ReloadControl()
    {
      if (Delivery != null)
      {
        _deliveryPosition.ClearObjectList();
        Delivery.LoadSingleObject();
        clientBindingSource.DataSource = Delivery.AvaibleClients;
        addressBindingSource.DataSource = Delivery.AvaibleAddresses;
        deliveryPositionBindingSource.DataSource = _deliveryPosition.LoadObjectList(DeliveryPosition.Columns.FkDeliveryPositionDelivery, Delivery.Identity);

        positionComboEdit.Items.AddRange(_deliveryPosition.LoadDescriptions(Delivery.FkDeliveryOrder));

        deliveryDate.Text = Delivery.DeliveryDate.ToShortDateString();
        clientLookUp.EditValue = Delivery.FkDeliveryClient;
        addressLookUp.EditValue = Delivery.FkDeliveryAddress;
      }
    }
    
    public Delivery Delivery;

    private void ViewDeliveryPositionInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewDeliveryPosition.SetFocusedRowCellValue(colFkDeliveryPositionDelivery, Delivery.Identity);
    }

    private void SaveDelivery(object sender, EventArgs e)
    {
      Delivery.SaveObject();
    }
    
    #region Ribbon

    public void PrintDelivery(object sender, ItemClickEventArgs e)
    {
      Delivery.LoadDeliveryReport();
    }

    public override RibbonPage RibbonPage
    {
      get
      {
        if (_ribbonPage == null)
        {
          _ribbonPage = new RibbonPage("Lieferschein");
        }
        if (_ribbonGroup == null)
        {
          _ribbonGroup = new RibbonPageGroup();
        }

        _ribbonGroup.ItemLinks.Clear();
        RefreshButton.ItemClick += PrintDelivery;
        _ribbonGroup.ItemLinks.Add(RefreshButton);
        
        _ribbonPage.Groups.Add(_ribbonGroup);

        return _ribbonPage;
      }
    }

    public BarButtonItem RefreshButton
    {
      get
      {
        return _refreshButton ?? (_refreshButton = new BarButtonItem
        {
          Caption = "Lieferschein drucken",
          Id = 3,
          LargeGlyph = Properties.Resources.printglyph,
          LargeWidth = 80,
        });
      }
    }
    
    private RibbonPageGroup _ribbonGroup;

    private RibbonPage _ribbonPage;
    
    private BarButtonItem _refreshButton;

    #endregion

    private readonly DeliveryPosition _deliveryPosition = new DeliveryPosition();

    private List<object> _editors; 

    private List<GridColumn> _columns;
  }
}