using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Columns;
using Impressio.Models;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class ClickCostControl : ClickCostControlBase
  {
    public ClickCostControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override void ReloadControl()
    {
      _clickCost.ClearObjectList();
      clickCostBindingSource.DataSource = _clickCost.LoadObjectList();
      viewClickCost.RefreshData();
    }

    public override GridView GridView
    {
      get { return viewClickCost; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                                         {
                                           colName,
                                           colCost,
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
                                                                           RibbonTools.GetDeleteButton(DeleteRow),
                                                                         }, "Klickkosten"));
      }
    }

    private RibbonPage _ribbonPage;

    private List<GridColumn> _columns;

    private readonly ClickCost _clickCost = new ClickCost();
  }
}