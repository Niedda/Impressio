using System;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class DescriptionControl : ControlBase, IControl, IGridControl<Description>
  {
    private readonly Description _description = new Description();
    public bool IsPredefinedMode;
    public Order Order = new Order();

    public DescriptionControl()
    {
      InitializeComponent();
    }

    public Detail FocusedRowDetail
    {
      get { return viewDetail.GetFocusedRow() as Detail; }
    }

    #region IControl Members

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

    #endregion

    #region IGridControl<Description> Members

    public Description FocusedRow
    {
      get { return viewDescription.GetFocusedRow() as Description; }
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

    #endregion

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
      GridView view = viewDescription;
      int index = view.FocusedRowHandle;

      if (index > 0 && !view.IsNewItemRow(index))
      {
        object rowArrange1 = viewDescription.GetRowCellValue(index, colArrange);
        object rowArrange2 = viewDescription.GetRowCellValue(index - 1, colArrange);

        viewDescription.SetRowCellValue(index, colArrange, rowArrange2);
        viewDescription.SetRowCellValue(index - 1, colArrange, rowArrange1);

        (view.GetRow(index) as Description).SaveObject();
        (view.GetRow(index - 1) as Description).SaveObject();

        view.FocusedRowHandle = index - 1;
      }
    }

    private void DescriptionMoveDownEditClick(object sender, EventArgs e)
    {
      GridView view = viewDescription;
      int index = view.FocusedRowHandle;

      if (index < view.DataRowCount - 1 && !view.IsNewItemRow(index))
      {
        object val1 = viewDescription.GetRowCellValue(index, colArrange);
        object val2 = viewDescription.GetRowCellValue(index + 1, colArrange);

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
        Description predef =
          (from det in _description.PredefinedObjects where det.JobTitle == e.Value as string select det).
            FirstOrDefault();

        if (predef != null)
        {
          Description newDescription = predef;
          newDescription.Identity = 0;
          newDescription.FkDescriptionOrder = _description.FkDescriptionOrder;
          newDescription.Arrange = viewDescription.RowCount + 1;
          newDescription.Identity = newDescription.SaveObject();

          foreach (Detail detail in predef.Details)
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
      GridView view = viewDetail;
      int index = view.FocusedRowHandle;

      if (index > 0 && !view.IsNewItemRow(index))
      {
        object val1 = view.GetRowCellValue(index, colArrangeDetail);
        object val2 = view.GetRowCellValue(index - 1, colArrangeDetail);

        view.SetRowCellValue(index, colArrangeDetail, val2);
        view.SetRowCellValue(index - 1, colArrangeDetail, val1);

        (view.GetRow(index) as Detail).SaveObject();
        (view.GetRow(index - 1) as Detail).SaveObject();

        view.FocusedRowHandle = index - 1;
      }
    }

    private void DetailMoveDownEditClick(object sender, EventArgs e)
    {
      GridView view = viewDetail;
      int index = view.FocusedRowHandle;

      if (index < view.DataRowCount - 1 && !view.IsNewItemRow(index))
      {
        object val1 = view.GetRowCellValue(index, colArrangeDetail);
        object val2 = view.GetRowCellValue(index + 1, colArrangeDetail);

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