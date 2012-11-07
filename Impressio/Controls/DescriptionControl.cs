using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class DescriptionControl : ControlBase, IControl, IGridControl<Description>, IRibbon
  {
    public DescriptionControl()
    {
      InitializeComponent();
    }
    
    #region Ribbon

    public string RibbonGroupName { get { return "Beschreibungen"; } }

    public List<BarButtonItem> Buttons
    {
      get
      {
        return _buttons ?? (_buttons = LoadButtons());
      }
    }

    public RibbonPageGroup GetRibbon()
    {
      var pageGroup = new RibbonPageGroup
      {
        Text = "Beschreibungen",
        Name = "descriptionPageGroup"
      };
      pageGroup.ItemLinks.AddRange(Buttons.ToArray());

      return pageGroup;
    }

    private List<BarButtonItem> _buttons;

    private List<BarButtonItem> LoadButtons()
    {
      var deleteButton = new BarButtonItem
      {
        Caption = "Beschreibung Löschen",
        Id = 1,
        LargeGlyph = Properties.Resources.delete,
        LargeWidth = 80,
        Name = "descriptionDelete",
      };
      deleteButton.ItemClick += DeleteRow;

      var deleteDetailButton = new BarButtonItem
      {
        Caption = "Detail Löschen",
        Id = 2,
        LargeGlyph = Properties.Resources.delete,
        LargeWidth = 80,
        Name = "detailDelete",
      };
      deleteDetailButton.ItemClick += DeleteDetailRow;
      
      var refreshButton = new BarButtonItem
      {
        Caption = "Aktualisieren",
        Id = 3,
        LargeGlyph = Properties.Resources.refresh,
        LargeWidth = 80,
        Name = "descriptionRefresh"
      };
      refreshButton.ItemClick += ReloadControl;

      return new List<BarButtonItem> { deleteButton, deleteDetailButton, refreshButton};
    }
    
    public void DeleteDetailRow(object sender, ItemClickEventArgs e)
    {
      DeleteDetailRow();
    }

    public void DeleteRow(object sender, ItemClickEventArgs e)
    {
      DeleteRow();
    }

    public void ReloadControl(object sender, ItemClickEventArgs e)
    {
      ReloadControl();
    }

    #endregion

    public void ReloadControl()
    {
      _description.ClearObjectList();
      _description.ClearPredefinedObjects();
      _description.LoadPredefined();

      if (IsPredefinedMode)
      {
        IsPredefinedMode = true;
        descriptionBindingSource.DataSource = _description.PredefinedObjects;
      }
      else
      {
        descriptionBindingSource.DataSource = _description.LoadObjectList(Description.Columns.FkDescriptionOrder,
                                                                          Order.Identity);
        predefinedDescriptionCombo.Items.Clear();
        predefinedDescriptionCombo.Items.AddRange(_description.PredefinedObjects.Select(a => a.JobTitle).ToList());
      }
      viewDescription.RefreshData();
    }

    public bool ValidateControl()
    {
      return ValidateRow() && ValidateDetailRow();
    }
    
    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewDescription.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewDescription.ClearColumnErrors();
      CheckColumn(colJobTitel);
      return !viewDescription.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (!viewDescription.HasColumnErrors && FocusedRow != null)
      {
        FocusedRow.IsPredefined = IsPredefinedMode;

        if (viewDescription.IsNewItemRow(viewDescription.FocusedRowHandle))
        {
          FocusedRow.Arrange = viewDescription.RowCount;
        }
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    public void DeleteDetailRow()
    {
      FocusedRowDetail.DeleteObject();
      viewDetail.DeleteSelectedRows();
    }

    public bool ValidateDetailRow()
    {
      viewDetail.ClearColumnErrors();
      CheckColumn(colDetailTitle);
      CheckColumn(colDetailContent);
      return !viewDetail.HasColumnErrors;
    }

    public void UpdateDetailRow()
    {
      if (FocusedRowDetail != null)
      {
        if (FocusedRowDetail.Identity == 0)
        {
          FocusedRowDetail.FkDetailDescription = FocusedRow.Identity;
          FocusedRowDetail.Arrange = viewDetail.DataRowCount;
        }
        FocusedRowDetail.Identity = FocusedRowDetail.SaveObject();
      }
    }

    public Description FocusedRow
    {
      get { return viewDescription.GetFocusedRow() as Description; }
    }

    public Detail FocusedRowDetail
    {
      get { return viewDetail.GetFocusedRow() as Detail; }
    }

    public bool IsPredefinedMode;

    public Order Order = new Order();

    private readonly Description _description = new Description();

    private void DescriptionControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewDescriptionValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewDescriptionRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void ViewDescriptionInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewDescriptionFocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
    {
      detailsBindingSource.Clear();

      if (FocusedRow != null)
      {
        detailsBindingSource.DataSource = FocusedRow.Details;
        viewDetail.RefreshData();
      }

      gridDetail.Enabled = !viewDescription.IsNewItemRow(e.FocusedRowHandle);
    }

    private void ViewDescriptionInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewDescription.SetFocusedRowCellValue(colFkDescriptionOrder, Order.Identity);
    }

    private void DescriptionMoveUpEditClick(object sender, EventArgs e)
    {
      var view = viewDescription;
      var index = view.FocusedRowHandle;

      if (index > 0 && !view.IsNewItemRow(index))
      {
        var rowArrange1 = viewDescription.GetRowCellValue(index, colArrange);
        var rowArrange2 = viewDescription.GetRowCellValue(index - 1, colArrange);

        viewDescription.SetRowCellValue(index, colArrange, rowArrange2);
        viewDescription.SetRowCellValue(index - 1, colArrange, rowArrange1);

        (view.GetRow(index) as Description).SaveObject();
        (view.GetRow(index - 1) as Description).SaveObject();

        view.FocusedRowHandle = index - 1;
      }
    }

    private void DescriptionMoveDownEditClick(object sender, EventArgs e)
    {
      var view = viewDescription;
      var index = view.FocusedRowHandle;

      if (index < view.DataRowCount - 1 && !view.IsNewItemRow(index))
      {
        var val1 = viewDescription.GetRowCellValue(index, colArrange);
        var val2 = viewDescription.GetRowCellValue(index + 1, colArrange);

        viewDescription.SetRowCellValue(index, colArrange, val2);
        viewDescription.SetRowCellValue(index + 1, colArrange, val1);

        (view.GetRow(index) as Description).SaveObject();
        (view.GetRow(index + 1) as Description).SaveObject();

        view.FocusedRowHandle = index + 1;
      }
    }

    private void ViewDescriptionCellValueChanging(object sender, CellValueChangedEventArgs e)
    {
      if (!IsPredefinedMode)
      {
        var predef =
          (from det in _description.PredefinedObjects where det.JobTitle == e.Value as string select det).
            FirstOrDefault();

        if (predef != null)
        {
          var newDescription = predef;
          newDescription.Identity = 0;
          newDescription.FkDescriptionOrder = _description.FkDescriptionOrder;
          newDescription.Arrange = viewDescription.RowCount + 1;
          newDescription.Identity = newDescription.SaveObject();

          foreach (var detail in predef.Details)
          {
            detail.Identity = 0;
            detail.FkDetailDescription = predef.Identity;
            detail.Arrange = viewDetail.RowCount + 1;
            detail.Identity = detail.SaveObject();
          }

          if (viewDescription.IsNewItemRow(viewDescription.FocusedRowHandle))
          {
            viewDescription.DeleteSelectedRows();
          }

          ReloadControl();
        }
      }
    }


    private void ViewDetailValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateDetailRow();
    }

    private void ViewDetailInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewDetailRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateDetailRow();
    }

    private void DetailMoveUpEditClick(object sender, EventArgs e)
    {
      var view = viewDetail;
      var index = view.FocusedRowHandle;

      if (index > 0 && !view.IsNewItemRow(index))
      {
        var val1 = view.GetRowCellValue(index, colArrangeDetail);
        var val2 = view.GetRowCellValue(index - 1, colArrangeDetail);

        view.SetRowCellValue(index, colArrangeDetail, val2);
        view.SetRowCellValue(index - 1, colArrangeDetail, val1);

        (view.GetRow(index) as Detail).SaveObject();
        (view.GetRow(index - 1) as Detail).SaveObject();

        view.FocusedRowHandle = index - 1;
      }
    }

    private void DetailMoveDownEditClick(object sender, EventArgs e)
    {
      var view = viewDetail;
      var index = view.FocusedRowHandle;

      if (index < view.DataRowCount - 1 && !view.IsNewItemRow(index))
      {
        var val1 = view.GetRowCellValue(index, colArrangeDetail);
        var val2 = view.GetRowCellValue(index + 1, colArrangeDetail);

        view.SetRowCellValue(index, colArrangeDetail, val2);
        view.SetRowCellValue(index + 1, colArrangeDetail, val1);

        (view.GetRow(index) as Detail).SaveObject();
        (view.GetRow(index + 1) as Detail).SaveObject();

        view.FocusedRowHandle = index + 1;
      }
    }

    private void DescriptionControlValidating(object sender, CancelEventArgs e)
    {
      ValidateControl();
    }
  }
}