using System;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class AddressControl : BaseControlImpressio, IControl, IGridControl<Address>
  {
    public AddressControl()
    {
      InitializeComponent();
    }

    public void ReloadControl()
    {
      if (Company != null)
      {
        _address.ClearObjectList();
        addressBindingSource.DataSource = _address.LoadObjectList(Address.Columns.FkAddressCompany, Company.Identity);
        viewAddress.RefreshData();
      }
    }

    public bool ValidateControl()
    {
      return ValidateRow();
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
    
    public Address FocusedRow
    {
      get { return viewAddress.GetFocusedRow() as Address; }
    }

    public Company Company = new Company();

    private readonly Address _address = new Address();

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