using System;
using DevExpress.XtraEditors.Controls;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class AddressControl : ControlBase
  {
    public AddressControl()
    {
      InitializeComponent();
    }

    public Company Company;

    private readonly Address _address = new Address();

    public void ReloadControl()
    {
      if (Company != null)
      {
        addressBindingSource.DataSource = _address.LoadObjectList(Address.Columns.FkAddressCompany, Company.Identity);
        viewAddress.RefreshData();
      }
    }

    private void AddressControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewAddressValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      viewAddress.ClearColumnErrors();
      CheckColumn(colStreet);
      CheckColumn(colCity);
      e.Valid = !viewAddress.HasColumnErrors;
    }

    private void ViewAddressInvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewAddressRowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
    {
      var address = e.Row as Address;
      if (address != null)
      {
        //address.SaveObject();
      }
    }

    private void ViewAddressInitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
    {
      viewAddress.SetRowCellValue(e.RowHandle, colFkAddressCompany, Company.Identity);
    }

    private void ViewAddressValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
    {
      viewAddress.ClearColumnErrors();
      CheckColumn(colCity);
      CheckColumn(colStreet);
    }
  }
}
