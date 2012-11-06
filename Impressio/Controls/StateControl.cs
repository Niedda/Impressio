using System;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class StateControl : ControlBase, IControl, IGridControl<State>
  {
    public StateControl()
    {
      InitializeComponent();
    }

    public void ReloadControl()
    {
      _state.ClearObjectList();
      stateBindingSource.DataSource = _state.LoadObjectList();
      viewState.RefreshData();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }

    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewState.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      CheckColumn(colStateName);
      return !viewState.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    public State FocusedRow
    {
      get { return viewState.GetFocusedRow() as State; }
    }

    private readonly State _state = new State();

    private void StateControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewStateInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewStateRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void ViewStateValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = !ValidateRow();
    }

    private void StateControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }
  }
}