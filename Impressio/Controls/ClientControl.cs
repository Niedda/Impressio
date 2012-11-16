using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class ClientControl : ClientControlBase
  {
    public ClientControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override GridView GridView
    {
      get { return viewClients; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                                         {
                                           colGender,
                                           colLastName,
                                         });
      }
    }

    public override void ReloadControl()
    {
      if (Company.Usable())
      {
        _client.ClearObjectList();
        _gender.ClearObjectList();
        genderLookUp.DataSource = _gender.LoadObjectList();
        clientsBindingSource.DataSource = _client.LoadObjectList(Client.Columns.FkClientCompany, Company.Identity);
        viewClients.RefreshData(); 
      }
    }

    public Company Company;
    
    private void ViewClientsInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewClients.SetRowCellValue(e.RowHandle, colFkClientCompany, Company.Identity);
    }

    private List<GridColumn> _columns;

    private readonly Client _client = new Client();

    private readonly Gender _gender = new Gender();
  }
}