using System;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class DeliveryOverviewControl : ControlBase, IControl, IGridControl<Delivery>
  {
    private readonly Company _company = new Company();
    private readonly Delivery _delivery = new Delivery();
    public Order Order = new Order();

    public DeliveryOverviewControl()
    {
      InitializeComponent();
    }

    #region IControl Members

    public void ReloadControl()
    {
      _company.ClearObjectList();
      _delivery.ClearObjectList();
      companyBindingSource.DataSource = _company.LoadObjectList();
      deliveryBindingSource.DataSource = _delivery.LoadObjectList(Delivery.Columns.FkDeliveryOrder, Order.Identity);
      viewDelivery.RefreshData();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }

    #endregion

    #region IGridControl<Delivery> Members

    public Delivery FocusedRow
    {
      get { return viewDelivery.GetFocusedRow() as Delivery; }
    }

    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewDelivery.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewDelivery.ClearColumnErrors();
      CheckColumn(colDeliveryDate);
      CheckColumn(colFkDeliveryCompany);
      return !viewDelivery.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    #endregion

    private void DeliveryOverviewControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewDeliveryValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewDeliveryInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewDelivery.SetFocusedRowCellValue(colFkDeliveryOrder, Order.Identity);
    }

    private void ViewDeliveryRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void ViewDeliveryInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }
  }
}