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
  public partial class PaperSizeControl : PaperSizeBase
  {
    public PaperSizeControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override GridView GridView
    {
      get { return paperSizeView; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                                         {
                                           colHeight,
                                           colWidth,
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
                                                                         }, "Papierformate"));
      }
    }

    public override void ReloadControl()
    {
      _paperSizeses.ClearObjectList();
      paperSizesBindingSource.DataSource = _paperSizeses.LoadObjectList();
      GridView.RefreshData();
    }

    public override void DeleteRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.DeleteObject();
        paperSizeView.DeleteSelectedRows();
      }
    }

    private readonly PaperSizes _paperSizeses = new PaperSizes();

    private RibbonPage _ribbonPage;

    private List<GridColumn> _columns;
  }
}
