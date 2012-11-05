using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using Impressio.Controls;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Views
{
  public partial class CustomerView : XtraForm
  {
    private readonly AddressControl _addressControl = new AddressControl();
    private readonly ClientControl _clientControl = new ClientControl();
    private readonly CompanyControl _companyControl = new CompanyControl();

    private Control _activeControl;

    private Company _company = new Company();

    public CustomerView()
    {
      InitializeComponent();
    }

    private void CustomerViewLoad(object sender, EventArgs e)
    {
      mainPanel.Controls.Add(_companyControl);
      mainPanel.Controls.Add(_addressControl);
      mainPanel.Controls.Add(_clientControl);
      _activeControl = _companyControl;
    }

    private void NavCompanyLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _companyControl.BringToFront();
      _activeControl = _companyControl;
    }

    private void NavAddressLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _company = _companyControl.viewCompany.GetFocusedRow() as Company;

      if (_company != null)
      {
        _addressControl.Company = _company;
        _addressControl.ReloadControl();
        _addressControl.BringToFront();
        _activeControl = _addressControl;
      }
    }

    private void NavClientLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _company = _companyControl.viewCompany.GetFocusedRow() as Company;

      if (_company != null)
      {
        _clientControl.Company = _company;
        _clientControl.ReloadControl();
        _clientControl.BringToFront();
        _activeControl = _clientControl;
      }
    }

    private void NavDeleteLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      if (_activeControl == _companyControl)
      {
        var company = _companyControl.viewCompany.GetFocusedRow() as Company;
        if (company != null)
        {
          if (!company.HasOrders())
          {
            company.DeleteObject();
            _companyControl.viewCompany.DeleteSelectedRows();
          }
          else
          {
            XtraMessageBox.Show("Der zu löschende Kunde hat noch Aufträge offen. Bitte löschen Sie diese zuerst.",
                                "Fehler");
          }
        }
      }
      if (_activeControl == _clientControl)
      {
        var client = _clientControl.viewClients.GetFocusedRow() as Client;
        if (client != null)
        {
          client.DeleteObject();
          _clientControl.viewClients.DeleteSelectedRows();
        }
      }
      if (_activeControl == _addressControl)
      {
        var addresss = _addressControl.viewAddress.GetFocusedRow() as Address;

        if (addresss != null)
        {
          addresss.DeleteObject();
          _addressControl.viewAddress.DeleteSelectedRows();
        }
      }
    }
  }
}