using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
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

    public override void ReloadControl()
    {
      _paper.ClearObjectList();
      paperBindingSource.DataSource = _paper.LoadObjectList();
      viewPaper.RefreshData();
    }
    
    #region Ribbons

    public void ReloadControl(object sender, ItemClickEventArgs e)
    {
      ReloadControl();
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
    
    public override RibbonPage RibbonPage
    {
      get
      {
        if (_ribbonPage == null)
        {
          _ribbonPage = new RibbonPage("Klickkosten");
        }
        if (_ribbonGroup == null)
        {
          _ribbonGroup = new RibbonPageGroup();
        }

        _ribbonGroup.ItemLinks.Clear();
        _ribbonGroup.ItemLinks.Add(DeleteButton);
        _ribbonGroup.ItemLinks.Add(RefreshButton);
        _ribbonGroup.ItemLinks.Add(ImportButton);

        DeleteButton.ItemClick += DeleteRow;
        RefreshButton.ItemClick += ReloadControl;
        ImportButton.ItemClick += LoadFromExcel;

        _ribbonPage.Groups.Add(_ribbonGroup);

        return _ribbonPage;
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

    public BarButtonItem ImportButton
    {
      get
      {
        return _importButton ?? (_importButton = new BarButtonItem
        {
          Caption = "Excel importieren",
          Id = 2,
          LargeGlyph = Properties.Resources.excel,
          LargeWidth = 80,
        });
      }
    }

    private RibbonPageGroup _ribbonGroup;

    private RibbonPage _ribbonPage;

    private BarButtonItem _refreshButton;

    private BarButtonItem _deleteButton;

    private BarButtonItem _importButton;

    #endregion

    private readonly Paper _paper = new Paper();

    private List<GridColumn> _columns;
  }
}