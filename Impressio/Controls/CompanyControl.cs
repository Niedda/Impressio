using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Impressio.Models;
using Impressio.Views;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class CompanyControl : BaseControlImpressio, IControl, IGridControl<Company>
  {
    public CompanyControl()
    {
      InitializeComponent();
    }

    public ClientControl ClientControl;

    public AddressControl AddressControl;

    public void ReloadControl()
    {
      _company.ClearObjectList();
      companiesBindingSource.DataSource = _company.LoadObjectList();
      viewCompany.RefreshData();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }

    public void DeleteRow()
    {
      if (!FocusedRow.HasOrders())
      {
        FocusedRow.DeleteObject();
        viewCompany.DeleteSelectedRows();
      }
      else
      {
        XtraMessageBox.Show("Bitte erst alle verknüpften Aufträge löschen.", "Löschen nicht möglich");
      }
    }

    public bool ValidateRow()
    {
      viewCompany.ClearColumnErrors();
      CheckColumn(colCompanyName);
      return !viewCompany.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    public bool OpenClient()
    {
      if (FocusedRow != null)
      {
        ClientControl = new ClientControl { Company = FocusedRow };
        MainViewRibbon.Instance.mainPanel.Controls.Add(ClientControl);
        MainViewRibbon.Instance.FocusedControl = AddressControl;
        ClientControl.ReloadControl();
        return true;
      }
      return false;
    }

    public bool OpenAddress()
    {
      if (FocusedRow != null)
      {
        AddressControl = new AddressControl { Company = FocusedRow };
        MainViewRibbon.Instance.mainPanel.Controls.Add(AddressControl);
        MainViewRibbon.Instance.FocusedControl = AddressControl;
        AddressControl.ReloadControl();
        return true;
      }
      return false;
    }

    public bool ValidateAddressAndClient()
    {
      if(AddressControl != null && ClientControl != null)
      {
        return AddressControl.ValidateControl() || ClientControl.ValidateControl();
      }
      if(AddressControl == null && ClientControl != null)
      {
        return ClientControl.ValidateControl();
      }
      if (AddressControl != null && ClientControl == null)
      {
        return AddressControl.ValidateControl();
      }
      return true;
    }

    public Company FocusedRow
    {
      get { return viewCompany.GetFocusedRow() as Company; }
    }

    private readonly Company _company = new Company();

    private void CompanyControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewCompanyValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewCompanyInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewCompanyRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void CompanyControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }
  }
}