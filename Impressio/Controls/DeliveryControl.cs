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

    #region Ribbon

    public void PrintDelivery(object sender, ItemClickEventArgs e)
    {
      Delivery.LoadDeliveryReport();
    }

    private void ReloadControl(object sender, ItemClickEventArgs e)
    {
      ReloadControl();
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
          _ribbonGroup.ItemLinks.Clear();
          PrintButton.ItemClick += PrintDelivery;
          DeleteButton.ItemClick += DeleteRow;
          RefreshButton.ItemClick += ReloadControl;
          _ribbonGroup.ItemLinks.Add(RefreshButton);
          _ribbonGroup.ItemLinks.Add(PrintButton);
          _ribbonGroup.ItemLinks.Add(DeleteButton);
          _ribbonPage.Groups.Add(_ribbonGroup);
        }
        return _ribbonPage;
      }
    }
    
    public BarButtonItem PrintButton
    {
      get
      {
        return _printButton ?? (_printButton = new BarButtonItem
        {
          Caption = "Lieferschein drucken",
          Id = 3,
          LargeGlyph = Properties.Resources.printglyph,
          LargeWidth = 80,
        });
      }
    }

    public BarButtonItem DeleteButton
    {
      get
      {
        return _deleteButton ?? (_deleteButton = new BarButtonItem
        {
          Caption = "Position löschen",
          Id = 3,
          LargeGlyph = Properties.Resources.delete,
          LargeWidth = 80,
        });
      }
    }
    
    public BarButtonItem RefreshButton
    {
      get
      {
        return _refreshButton ?? (_refreshButton = new BarButtonItem
        {
          Caption = "Aktualisieren",
          Id = 3,
          LargeGlyph = Properties.Resources.refresh,
          LargeWidth = 80,
        });
      }
    }

    private RibbonPageGroup _ribbonGroup;

    private RibbonPage _ribbonPage;

    private BarButtonItem _printButton;

    private BarButtonItem _deleteButton;

    private BarButtonItem _refreshButton;

    #endregion

    private readonly DeliveryPosition _deliveryPosition = new DeliveryPosition();

    private List<object> _editors;

    private List<GridColumn> _columns;
  }
}