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
  public partial class MachineControl : MachineControlBase
  {
    public MachineControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override GridView GridView
    {
      get { return viewMachine; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                 {
                   colName,
                   colPlateCost,
                   colPricePerColor,
                   colSpeed,
                   colCostPerHour,
                   colDifficultColor,
                   colDifficultSetup,
                   colEasySetup,
                   colPlateSetup,
                 });
      }
    }

    public override void ReloadControl()
    {
      _machine.ClearObjectList();
      machineBindingSource.DataSource = _machine.LoadObjectList();
      viewMachine.RefreshData();
    }

    public override RibbonPage RibbonPage
    {
      get
      {
        return _ribbonPage ?? (_ribbonPage = RibbonTools.GetSimplePage(new List<BarButtonItem>
                                                                         {
                                                                           RibbonTools.GetRefreshButton(ReloadControl),
                                                                           RibbonTools.GetDeleteButton(DeleteRow),
                                                                         }, "Druckmaschinen"));
      }
    }

    private RibbonPage _ribbonPage;

    private List<GridColumn> _columns;

    private readonly Machine _machine = new Machine();
  }
}