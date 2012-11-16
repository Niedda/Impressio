using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class DeliveryOverviewControl : DeliveryOverviewBase
  {
    public DeliveryOverviewControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override GridView GridView
    {
      get { return viewDelivery; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                                         {
                                           colDeliveryDate,
                                           colFkDeliveryCompany,
                                         });
      }
    }

    public override void ReloadControl()
    {
      if (Order != null)
      {
        _company.ClearObjectList();
        _delivery.ClearObjectList();
        companyBindingSource.DataSource = _company.LoadObjectList();
        deliveryBindingSource.DataSource = _delivery.LoadObjectList(Delivery.Columns.FkDeliveryOrder, Order.Identity);
        viewDelivery.RefreshData();
      }
    }

    public Order Order;

    private void ViewDeliveryInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewDelivery.SetFocusedRowCellValue(colFkDeliveryOrder, Order.Identity);
    }

    #region Ribbon

    public void ReloadControl(object sender, ItemClickEventArgs e)
    {
      ReloadControl();
    }

    public void DeleteRow(object sender, ItemClickEventArgs e)
    {
      DeleteRow();
    }

    public override RibbonPage RibbonPage
    {
      get
      {
        if (_ribbonPage == null)
        {
          _ribbonPage = new RibbonPage("Lieferscheine")
                          {
                            Name = "overview",
                          };
        }
        if (_ribbonGroup == null)
        {
          _ribbonGroup = new RibbonPageGroup();
        }

        _ribbonGroup.ItemLinks.Clear();
        _ribbonGroup.ItemLinks.Add(DeleteButton);
        _ribbonGroup.ItemLinks.Add(RefreshButton);
        _ribbonGroup.ItemLinks.Add(OpenDelivery);

        _ribbonPage.Groups.Add(_ribbonGroup);

        return _ribbonPage;
      }
    }

    public BarButtonItem OpenDelivery
    {
      get
      {
        return _openDelivery ?? (_openDelivery = new BarButtonItem
        {
          Caption = "Position öffnen",
          Id = 1,
          LargeGlyph = Properties.Resources.open,
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

    public BarButtonItem DeleteButton
    {
      get
      {
        return _deleteButton ?? (_deleteButton = new BarButtonItem
        {
          Caption = "Löschen",
          Id = 2,
          LargeGlyph = Properties.Resources.delete,
          LargeWidth = 80,
        });
      }
    }

    private RibbonPageGroup _ribbonGroup;

    private RibbonPage _ribbonPage;

    private BarButtonItem _openDelivery;

    private BarButtonItem _refreshButton;

    private BarButtonItem _deleteButton;

    #endregion

    private readonly Company _company = new Company();

    private readonly Delivery _delivery = new Delivery();

    private List<GridColumn> _columns;
  }
}