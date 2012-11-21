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
  public partial class GenderControl : GenderControlBase
  {
    public GenderControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override GridView GridView
    {
      get { return viewGender; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                                         {
                                           colName,
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
                                                                         }, "Anreden"));
      }
    }

    public override void ReloadControl()
    {
      _gender.ClearObjectList();
      genderBindingSource.DataSource = _gender.LoadObjectList();
      viewGender.RefreshData();
    }
    
    private RibbonPage _ribbonPage;

    private readonly Gender _gender = new Gender();

    private List<GridColumn> _columns;
  }
}