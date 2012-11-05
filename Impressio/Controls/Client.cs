using System;
using DevExpress.XtraEditors.Controls;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class Client : ControlBase
  {
    public Client()
    {
      InitializeComponent();
    }
    
    public Models.Company Company;
    
    public void ReloadControl()
    {
      if (Company != null)
      {
        _client.ClearObjectList();
        genderLookUp.DataSource = _gender.LoadObjectList();
        clientsBindingSource.DataSource = _client.LoadObjectList(Models.Client.Columns.FkClientCompany, Company.Identity);
        viewClients.RefreshData();
      }
    }
    
    private readonly Models.Client _client = new Models.Client();

    private readonly Models.Gender _gender = new Models.Gender();

    private void ClientControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }
    
    private void ViewClientsValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      viewClients.ClearColumnErrors();
      CheckColumn(colLastName);
      CheckColumn(colGender);

      e.Valid = !viewClients.HasColumnErrors;
    }

    private void ViewClientsInvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewClientsRowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
    {
      var client = e.Row as Models.Client;

      if (client != null)
      {
        viewClients.SetRowCellValue(e.RowHandle, colIdentity, client.SaveObject());
      }
    }

    private void ViewClientsInitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
    {
      viewClients.SetRowCellValue(e.RowHandle, colFkClientCompany, Company.Identity);
    }

    private void ViewClientsValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
    {
      viewClients.ClearColumnErrors();
      CheckColumn(colGender);
      CheckColumn(colLastName);
    }
  }
}
