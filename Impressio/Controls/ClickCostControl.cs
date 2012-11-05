using System;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class ClickCostControl : ControlBase, IControl, IGridControl<ClickCost>
  {
    private readonly ClickCost _clickCost = new ClickCost();

    public ClickCostControl()
    {
      InitializeComponent();
    }

    #region IControl Members

    public void ReloadControl()
    {
      _clickCost.ClearObjectList();
      clickCostBindingSource.DataSource = _clickCost.LoadObjectList();
      viewClickCost.RefreshData();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }

    #endregion

    #region IGridControl<ClickCost> Members

    public ClickCost FocusedRow
    {
      get { return viewClickCost.GetFocusedRow() as ClickCost; }
    }

    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewClickCost.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewClickCost.ClearColumnErrors();
      CheckColumn(colName);
      CheckColumn(colCost);
      return !viewClickCost.HasColumnErrors;
    }

    public void UpdateRow()
    {
      viewClickCost.SetFocusedRowCellValue(colIdentity, FocusedRow.SaveObject());
    }

    #endregion

    private void ClickCostControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewClickCostInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewClickCostValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = !ValidateRow();
    }

    private void ViewClickCostRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void ClickCostControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }
  }
}