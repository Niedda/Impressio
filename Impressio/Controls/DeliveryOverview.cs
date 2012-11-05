using System;
using DevExpress.XtraEditors.Controls;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class DeliveryOverview : Models.ControlBase
  {
    public DeliveryOverview()
    {
      InitializeComponent();
    }

    public Order Order;


    private readonly Models.Delivery _delivery = new Models.Delivery();

    private readonly Models.Company _company = new Models.Company();

    private void DeliveryOverviewControlLoad(object sender, EventArgs e)
    {
      companyBindingSource.DataSource = _company.LoadObjectList();
      deliveryBindingSource.DataSource = _delivery.LoadObjectList(Models.Delivery.Columns.FkDeliveryOrder, Order.Identity);
    }

    private void ViewDeliveryValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      viewDelivery.ClearColumnErrors();
      CheckColumn(colDeliveryDate);
      CheckColumn(colFkDeliveryCompany);
      e.Valid = !viewDelivery.HasColumnErrors;
    }

    private void ViewDeliveryInitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
    {
      viewDelivery.SetFocusedRowCellValue(colFkDeliveryOrder, Order.Identity);
    }

    private void ViewDeliveryRowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
    {
      viewDelivery.SetFocusedRowCellValue(colIdentity, (e.Row as Models.Delivery).SaveObject());
    }

    private void ViewDeliveryInvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }
  }
}
