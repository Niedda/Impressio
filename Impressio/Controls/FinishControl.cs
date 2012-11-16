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
  public partial class FinishControl : FinishControlBase
  {
    public FinishControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override GridView GridView
    {
      get { return viewFinish; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                                         {
                                           colDescription,
                                           colQuantity,
                                           colPricePerQuantity,
                                         });
      }
    }

    public override void ReloadControl()
    {
      if (Finish != null)
      {
        Finish.LoadSingleObject();
        _finishPosition.ClearObjectList();
        finishPositionBindingSource.DataSource = _finishPosition.LoadObjectList(FinishPosition.Columns.FkFinishFinishPosition, Finish.Identity);

        remarkEdit.Text = Finish.Remark;
      }
    }

    public Finish Finish;

    private void RemarkEditEditValueChanged(object sender, EventArgs e)
    {
      Finish.Remark = remarkEdit.Text;
      Finish.SaveObject();
    }

    private void ViewFinishInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewFinish.SetFocusedRowCellValue(colFkFinishFinishPosition, Finish.Identity);
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

    private readonly FinishPosition _finishPosition = new FinishPosition();

    private List<GridColumn> _columns;
  }
}