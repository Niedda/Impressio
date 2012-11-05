using System;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class ClientControl : ControlBase, IControl, IGridControl<Client>
  {
    private readonly Client _client = new Client();

    private readonly Gender _gender = new Gender();
    public Company Company = new Company();

    public ClientControl()
    {
      InitializeComponent();
    }

    #region IControl Members

    public void ReloadControl()
    {
      _client.ClearObjectList();
      _gender.ClearObjectList();
      genderLookUp.DataSource = _gender.LoadObjectList();
      clientsBindingSource.DataSource = _client.LoadObjectList(Client.Columns.FkClientCompany, Company.Identity);
      viewClients.RefreshData();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }

    #endregion

    #region IGridControl<Client> Members

    public Client FocusedRow
    {
      get { return viewClients.GetFocusedRow() as Client; }
    }

    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewClients.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewClients.ClearColumnErrors();
      CheckColumn(colLastName);
      CheckColumn(colGender);
      return !viewClients.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    #endregion

    private void ClientControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewClientsValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewClientsInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewClientsRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void ViewClientsInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewClients.SetRowCellValue(e.RowHandle, colFkClientCompany, Company.Identity);
    }

    private void ClientControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }
  }
}