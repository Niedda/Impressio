using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class CompanyControl : ControlBase, IControl, IGridControl<Company>
  {
    private readonly Company _company = new Company();

    public CompanyControl()
    {
      InitializeComponent();
    }

    #region IControl Members

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

    #endregion

    #region IGridControl<Company> Members

    public Company FocusedRow
    {
      get { return viewCompany.GetFocusedRow() as Company; }
    }

    public void DeleteRow()
    {
      if (!FocusedRow.HasOrders())
      {
        FocusedRow.DeleteObject();
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

    #endregion

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