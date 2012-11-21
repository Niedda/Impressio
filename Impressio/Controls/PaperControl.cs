using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Models.Tools;
using Impressio.Properties;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class PaperControl : PaperControlBase
  {
    public PaperControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override GridView GridView
    {
      get { return viewPaper; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                                         {
                                           colName,
                                           colPrice1,
                                           colSizeB,
                                           colSizeL,
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
                                                                           RibbonTools.GetCustomButton("Excel importieren", Resources.excel,LoadFromExcel),
                                                                           RibbonTools.GetDeleteButton(DeleteRow),
                                                                         }, "Papierverwaltung"));
      }
    }
    
    public override void ReloadControl()
    {
      _paper.ClearObjectList();
      paperBindingSource.DataSource = _paper.LoadObjectList();
      viewPaper.RefreshData();
    }

    public void LoadFromExcel(object sender, ItemClickEventArgs e)
    {
      var fileDialog = new OpenFileDialog { Filter = "Excel Worksheets|*.xls | *.xlsx" };
      var result = fileDialog.ShowDialog();

      if (result == DialogResult.OK)
      {
        Paper.LoadFromExcel(fileDialog.FileName);
      }
    }

    private RibbonPage _ribbonPage;

    private readonly Paper _paper = new Paper();

    private List<GridColumn> _columns;
  }
}