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
  public partial class FinishControl : ControlBase, IControl, IGridControl<FinishPosition>
  {
    private readonly FinishPosition _finishPosition = new FinishPosition();
    public Finish Finish;

    public FinishControl()
    {
      InitializeComponent();
    }

    #region IControl Members

    public void ReloadControl()
    {
      _finishPosition.ClearObjectList();
      finishPositionBindingSource.DataSource =
        _finishPosition.LoadObjectList(FinishPosition.Columns.FkFinishFinishPosition, Finish.Identity);

      nameEdit.Text = Finish.Name;
      remarkEdit.Text = Finish.Remark;
    }

    public bool ValidateControl()
    {
      CheckEditor(nameEdit);

      if (ValidateRow() && !ErrorProvider.HasErrors)
      {
        Finish.Name = nameEdit.Text;
        Finish.PositionTotal = _finishPosition.Objects.Sum(position => position.PriceTotal);
        Finish.SaveObject();
        return true;
      }
      return false;
    }

    #endregion

    #region IGridControl<FinishPosition> Members

    public FinishPosition FocusedRow
    {
      get { return viewFinish.GetFocusedRow() as FinishPosition; }
    }

    public void DeleteRow()
    {
      viewFinish.DeleteSelectedRows();
      FocusedRow.DeleteObject();
    }

    public bool ValidateRow()
    {
      viewFinish.ClearColumnErrors();
      CheckColumn(colDescription);
      return !viewFinish.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    #endregion

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
                                   (int) viewFinish.GetRowCellValue(e.RowHandle, colPricePerQuantity)*
                                   (int) viewFinish.GetRowCellValue(e.RowHandle, colQuantity));
      }
    }

    private void ViewFinishValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewFinishInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewFinishInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewFinish.SetFocusedRowCellValue(colFkFinishFinishPosition, Finish.Identity);
    }

    private void ViewFinishRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }
  }
}