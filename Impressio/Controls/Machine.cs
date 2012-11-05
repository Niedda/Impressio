using System;
using DevExpress.XtraEditors.Controls;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class Machine : ControlBase
  {
    public Machine()
    {
      InitializeComponent();
    }

    public void ReloadControl()
    {
      _machine.ClearObjectList();
      machineBindingSource.DataSource = _machine.LoadObjectList();
      viewMachine.RefreshData();
    }

    public void DeleteRow()
    {
      var machine = viewMachine.GetFocusedRow() as Models.Machine;
      
      if (machine != null)
      {
        machine.DeleteObject();
        viewMachine.DeleteSelectedRows();
      }
    }
    

    private readonly Models.Machine _machine = new Models.Machine();

    private void MachineControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewMachineInvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewMachineValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      viewMachine.ClearColumnErrors();
      CheckColumn(colName);
      CheckColumn(colCostPerHour);
      CheckColumn(colPlateCost);
      CheckColumn(colPricePerColor);
      CheckColumn(colSpeed);
      e.Valid = !viewMachine.HasColumnErrors;
    }

    private void ViewMachineRowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
    {
      viewMachine.SetFocusedRowCellValue(colIdentity, (e.Row as Models.Machine).SaveObject());
    }
  }
}
