using System;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class MachineControl : ControlBase, IControl, IGridControl<Machine>
  {
    private readonly Machine _machine = new Machine();

    public MachineControl()
    {
      InitializeComponent();
    }

    #region IControl Members

    public void ReloadControl()
    {
      _machine.ClearObjectList();
      machineBindingSource.DataSource = _machine.LoadObjectList();
      viewMachine.RefreshData();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }

    #endregion

    #region IGridControl<Machine> Members

    public Machine FocusedRow
    {
      get { return viewMachine.GetFocusedRow() as Machine; }
    }

    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewMachine.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewMachine.ClearColumnErrors();
      CheckColumn(colName);
      CheckColumn(colCostPerHour);
      CheckColumn(colPlateCost);
      CheckColumn(colPricePerColor);
      CheckColumn(colSpeed);
      return !viewMachine.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    #endregion

    private void MachineControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewMachineInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewMachineValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewMachineRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void MachineControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }
  }
}