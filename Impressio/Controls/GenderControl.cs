using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
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

    public override void ReloadControl()
    {
      _gender.ClearObjectList();
      genderBindingSource.DataSource = _gender.LoadObjectList();
      viewGender.RefreshData();
    }
    
    #region Ribbons

    public void ReloadControl(object sender, ItemClickEventArgs e)
    {
      ReloadControl();
    }

    public override RibbonPage RibbonPage
    {
      get
      {
        if (_ribbonPage == null)
        {
          _ribbonPage = new RibbonPage("Anreden");
        }
        if (_ribbonGroup == null)
        {
          _ribbonGroup = new RibbonPageGroup();

          _ribbonGroup.ItemLinks.Clear();
          _ribbonGroup.ItemLinks.Add(DeleteButton);
          _ribbonGroup.ItemLinks.Add(RefreshButton);

          DeleteButton.ItemClick += DeleteRow;
          RefreshButton.ItemClick += ReloadControl;

          _ribbonPage.Groups.Add(_ribbonGroup);
        }
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

    private RibbonPageGroup _ribbonGroup;

    private RibbonPage _ribbonPage;

    private BarButtonItem _refreshButton;

    private BarButtonItem _deleteButton;

    #endregion

    private readonly Gender _gender = new Gender();

    private List<GridColumn> _columns;
  }
}