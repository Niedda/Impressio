using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class StateControl : StateControlBase
  {
    public StateControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override GridView GridView
    {
      get { return viewState; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                                         {
                                           colStateName,
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
                                                                         }, "Statusverwaltung"));
      }
    }

    public override void ReloadControl()
    {
      _state.ClearObjectList();
      stateBindingSource.DataSource = _state.LoadObjectList();
      viewState.RefreshData();
    }

    public override void DeleteRow()
    {
      if (FocusedRow != null)
      {
        if (FocusedRow.HasOrders())
        {
          XtraMessageBox.Show("Status ist noch Aufträgen zugewiesen. Bitte diese zuerst umschreiben.", "Fehler");
        }
        else
        {
          FocusedRow.DeleteObject();
          viewState.DeleteSelectedRows();
        }
      }
    }
    
    private RibbonPage _ribbonPage;

    private readonly State _state = new State();

    private List<GridColumn> _columns;
  }
}