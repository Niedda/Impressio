using System;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class AddressControl : ControlBase, IControl, IGridControl<Address>
  {
    private readonly Address _address = new Address();
    public Company Company = new Company();

    public AddressControl()
    {
      InitializeComponent();
    }

    #region IControl Members

    public void ReloadControl()
    {
      _address.ClearObjectList();
      addressBindingSource.DataSource = _address.LoadObjectList(Address.Columns.FkAddressCompany, Company.Identity);
      viewAddress.RefreshData();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }

    #endregion

    #region IGridControl<Address> Members

    public Address FocusedRow
    {
      get { return viewAddress.GetFocusedRow() as Address; }
    }

    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewAddress.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewAddress.ClearColumnErrors();
      CheckColumn(colStreet);
      CheckColumn(colCity);
      return !viewAddress.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    #endregion

    private void AddressControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewAddressValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewAddressInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewAddressRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void ViewAddressInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewAddress.SetRowCellValue(e.RowHandle, colFkAddressCompany, Company.Identity);
    }

    private void AddressControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }
  }
}