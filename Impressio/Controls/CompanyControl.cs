using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class CompanyControl : CompanyControlBase
  {
    public CompanyControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override GridView GridView
    {
      get { return viewCompany; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                                         {
                                           colCompanyName,
                                         });
      }
    }

    public ClientControl ClientControl;

    public AddressControl AddressControl;

    public override void ReloadControl()
    {
      _company.ClearObjectList();
      companiesBindingSource.DataSource = _company.LoadObjectList();
      viewCompany.RefreshData();
    }

    public bool ValidateAddressAndClient()
    {
      if (AddressControl != null && ClientControl != null)
      {
        return AddressControl.ValidateControl() || ClientControl.ValidateControl();
      }
      if (AddressControl == null && ClientControl != null)
      {
        return ClientControl.ValidateControl();
      }
      if (AddressControl != null && ClientControl == null)
      {
        return AddressControl.ValidateControl();
      }
      return true;
    }
    
    private readonly Company _company = new Company();

    private List<GridColumn> _columns;
  }
}