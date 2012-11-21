using System;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Models.Tools;
using Impressio.Views;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class PredefinedOrderControl : PredefinedOrderBase
  {
    public PredefinedOrderControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override GridView GridView
    {
      get { return viewPredefinedOrder; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                 {
                   colFkOrderId,
                   colKind,
                   colName,
                   colPages,
                   colColorFront,
                   colColorBack,
                 });
      }
    }

    public override void ReloadControl()
    {
      _order.ClearObjectList();
      orderSearchLookUp.DataSource = _order.LoadObjectList(Order.Columns.IsPredefined, true);
      _predefinedOrder.ClearObjectList();
      predefinedOrderBindingSource.DataSource = _predefinedOrder.LoadObjectList();
      viewPredefinedOrder.RefreshData();
    }

    public override RibbonPage RibbonPage
    {
      get
      {
        return _ribbonPage ?? (_ribbonPage = RibbonTools.GetSimplePage(new List<BarButtonItem>
                                                                         {
                                                                           RibbonTools.GetRefreshButton(ReloadControl),
                                                                           RibbonTools.GetDeleteButton(DeleteRow),
                                                                           RibbonTools.GetOpenButton(EditPredefinedOrder),
                                                                         }, "Vordefinierte Aufträge"));
      }
    }

    private RibbonPage _ribbonPage;

    private List<GridColumn> _columns;

    private readonly PredefinedOrder _predefinedOrder = new PredefinedOrder();

    private readonly Order _order = new Order();

    private void EditPredefinedOrder(object sender, EventArgs e)
    {
      if (FocusedRow.Usable())
      {
        var order = new Order
                      {
                        Identity = FocusedRow.FkOrderId,
                      };
        order.LoadSingleObject();
        new OrderRibbonView(order).Show();
      }
    }

    private void OrderSearchLookUpEditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
    {
      var oldOrder = new Order { Identity = (int)e.OldValue };
      oldOrder.LoadSingleObject();
      oldOrder.DeleteObject();

      var newOrder = new Order { Identity = (int)e.NewValue };
      newOrder.LoadSingleObject();
      newOrder.CopyOrder();
      newOrder.IsPredefined = true;
      newOrder.OrderName = newOrder.OrderName.Replace("[Kopie]", "[Predefined]");
      newOrder.SaveObject();
      e.NewValue = newOrder.Identity;
    }
  }
}
