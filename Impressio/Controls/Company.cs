using System;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class Company : ControlBase
  {
    public Company()
    {
      InitializeComponent();
    }

    public void ReloadControl()
    {
      _company.ClearObjectList();
      companiesBindingSource.DataSource = _company.LoadObjectList();
      viewCompany.RefreshData();
    }

    private readonly Models.Company _company = new Models.Company();

    private void CompanyControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewCompanyValidateRow(object sender, ValidateRowEventArgs e)
    {
      viewCompany.ClearColumnErrors();
      CheckColumn(colCompanyName);

      e.Valid = !viewCompany.HasColumnErrors;
    }

    private void ViewCompanyInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewCompanyRowUpdated(object sender, RowObjectEventArgs e)
    {
      var company = e.Row as Models.Company;

      if (company != null)
      {
        viewCompany.SetFocusedRowCellValue(colIdentity, company.SaveObject());
      }
    }
  }
}
