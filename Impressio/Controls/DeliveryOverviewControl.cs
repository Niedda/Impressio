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

    public override RibbonPage RibbonPage
    {
      get
      {
        return _ribbonPage ?? (_ribbonPage = RibbonTools.GetSimplePage(new List<BarButtonItem>
                                                                         {
                                                                           RibbonTools.GetRefreshButton(ReloadControl),
                                                                           OpenDelivery,
                                                                           RibbonTools.GetDeleteButton(DeleteRow),
                                                                           RibbonTools.GetPrintButton("Lieferschein drucken", PrintDelivery),
                                                                         }, "Lieferscheine"));
      }
    }

    public BarButtonItem OpenDelivery
    {
      get
      {
        return _openDelivery ?? (_openDelivery = RibbonTools.GetOpenButton());
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
    
    private void PrintDelivery(object sender, ItemClickEventArgs e)
    {
      if(FocusedRow != null)
      {
        FocusedRow.LoadDeliveryReport();
      }
    }

    private RibbonPage _ribbonPage;

    private BarButtonItem _openDelivery;

    private readonly Company _company = new Company();

    private readonly Delivery _delivery = new Delivery();

    private List<GridColumn> _columns;
  }
}