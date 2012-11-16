using System;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class FinishControl : ControlBase, IGridControl
  {
    public FinishControl()
    {
      InitializeComponent();
    }

    #region Ribbon

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
        _refreshButton.ItemClick += ReloadControl;
        _deleteButton.ItemClick += DeleteRow;
        _ribbonGroup.ItemLinks.Add(RefreshButton);
        _ribbonGroup.ItemLinks.Add(DeleteButton);

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
    
    public void ReloadControl(object sender, ItemClickEventArgs e)
    {
      ReloadControl();
    }

    public void DeleteRow(object sender, ItemClickEventArgs e)
    {
      DeleteRow();
    }

    #endregion

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

    public new bool ValidateControl()
    {
      if (ValidateRow() && !ErrorProvider.HasErrors)
      {

        return true;
      }
      return false;
    }

    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewFinish.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewFinish.ClearColumnErrors();
      //CheckColumn(colDescription);
      return !viewFinish.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.FkFinishFinishPosition = Finish.Identity;
        FocusedRow.Identity = FocusedRow.SaveObject();
        Finish.PositionTotal = _finishPosition.Objects.Sum(position => position.PriceTotal);
        Finish.SaveObject();
      }
    }

    public override void Refresh()
    {
      GetFinish();
      base.Refresh();
    }

    public void GetFinish()
    {
      Finish.Remark = remarkEdit.Text;
      Finish.PositionTotal = _finishPosition.Objects.Sum(finish => finish.PriceTotal);
      Finish.SaveObject();
    }

    public FinishPosition FocusedRow
    {
      get { return viewFinish.GetFocusedRow() as FinishPosition; }
    }

    public Finish Finish;

    private readonly FinishPosition _finishPosition = new FinishPosition();

    private void FinishControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void FinishControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }

    private void ViewFinishCellValueChanged(object sender, CellValueChangedEventArgs e)
    {
      if (e.Column.Name == colPricePerQuantity.Name || e.Column.Name == colQuantity.Name)
      {
        viewFinish.SetRowCellValue(e.RowHandle, colPriceTotal,
                                   (int)viewFinish.GetRowCellValue(e.RowHandle, colPricePerQuantity) *
                                   (int)viewFinish.GetRowCellValue(e.RowHandle, colQuantity));
      }
    }

    private void ViewFinishValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();

      if (e.Valid)
      {
        UpdateRow();
      }
    }

    private void ViewFinishInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void RemarkEditEditValueChanged(object sender, EventArgs e)
    {
      GetFinish();
    }
  }
}