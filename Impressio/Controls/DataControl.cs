using System;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class DataControl : DataControlBase
  {
    public DataControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override GridView GridView
    {
      get { return viewData; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                                         {
                                           colPricePerQuantity,
                                           colDescription,
                                           colQuantity,
                                         });
      }
    }

    public override void ReloadControl()
    {
      if (Data != null)
      {
        _isLoaded = false;

        _dataPosition.ClearObjectList();
        Data.LoadSingleObject();
        remarkEdit.Text = Data.Remark;
        dataPositionBindingSource.DataSource = _dataPosition.LoadObjectList(DataPosition.Columns.FkDataDataPosition, Data.Identity);
        viewData.RefreshData();

        _isLoaded = true;
      }
    }

    public Data Data;

    private bool _isLoaded;

    private void RemarkEditEditValueChanged(object sender, EventArgs e)
    {
      if (_isLoaded)
      {
        Data.Remark = remarkEdit.Text;
        Data.SaveObject();
      }
    }

    #region Ribbon

    public void ReloadControl(object sender, ItemClickEventArgs e)
    {
      ReloadControl();
    }

    public void DeleteRow(object sender, ItemClickEventArgs e)
    {
      DeleteRow();
    }

    public override RibbonPage RibbonPage
    {
      get
      {
        if (_ribbonPage == null)
        {
          _ribbonPage = new RibbonPage("Datenaufbereitung");
        }
        if (_ribbonGroup == null)
        {
          _ribbonGroup = new RibbonPageGroup();
        }

        _ribbonGroup.ItemLinks.Clear();
        _ribbonGroup.ItemLinks.Add(RefreshButton);
        _ribbonGroup.ItemLinks.Add(DeleteButton);
        _refreshButton.ItemClick += ReloadControl;
        _deleteButton.ItemClick += DeleteRow;

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
          Name = "positionRefresh"
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
          Name = "positionDelete",
        });
      }
    }

    private RibbonPageGroup _ribbonGroup;

    private RibbonPage _ribbonPage;

    private BarButtonItem _refreshButton;

    private BarButtonItem _deleteButton;

    #endregion

    private readonly DataPosition _dataPosition = new DataPosition();

    private List<GridColumn> _columns;
  }
}