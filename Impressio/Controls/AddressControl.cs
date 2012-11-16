using System;
using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class AddressControl : AddressControlBase
  {
    public AddressControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override GridView GridView
    {
      get { return viewAddress; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                 {
                   colStreet,
                   colCity,
                 });
      }
    }

    public override void ReloadControl()
    {
      if (Company.Usable())
      {
        _address.ClearObjectList();
        addressBindingSource.DataSource = _address.LoadObjectList(Address.Columns.FkAddressCompany, Company.Identity);
        viewAddress.RefreshData();
      }
      else
      {
        gridAddress.Enabled = false;
      }
    }
    
    public Company Company;
    
    private void AddressControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewAddressInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewAddress.SetRowCellValue(e.RowHandle, colFkAddressCompany, Company.Identity);
    }

    private List<GridColumn> _columns;

    private readonly Address _address = new Address();
  }
}