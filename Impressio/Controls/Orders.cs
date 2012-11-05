using System;
using DevExpress.XtraEditors.Controls;
using Impressio.Models;
using Impressio.Views;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class Orders : ControlBase
  {
    public Orders()
    {
      InitializeComponent();
    }

    public Order Order = new Order();

    public void ReloadControl()
    {
      companiesBindingSource.DataSource = _company.LoadObjectList();
      orderBindingSource.DataSource = Order.LoadObjectList();
      stateBindingSource.DataSource = _state.LoadObjectList();
    }

    public void OpenOrder()
    {
      if (FocusedOrder != null)
      {
        new PositionView
          {
            Order = FocusedOrder,
          }.Show();
      }
    }

    public void DeleteOrder()
    {
      if (FocusedOrder != null)
      {
        FocusedOrder.DeleteObject();
        viewOrder.DeleteSelectedRows();
        viewOrder.RefreshData();
      }
    }

    public void LoadReport()
    {
      if (FocusedOrder != null)
      {
        FocusedOrder.LoadOrderReport();
      }
    }

    public void LoadOffer()
    {
      if (FocusedOrder != null)
      {
        FocusedOrder.LoadOrderOffer();
      }
    }

    private Order FocusedOrder
    {
      get { return viewOrder.GetFocusedRow() as Order; }
    }

    private readonly Models.State _state = new Models.State();

    private readonly Models.Company _company = new Models.Company();

    private void OrderControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewOrderValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      viewOrder.ClearColumnErrors();
      CheckColumn(colOrderName);
      CheckColumn(colState);
      CheckColumn(colCompany);
      e.Valid = !viewOrder.HasColumnErrors;
    }

    private void CompanySearchLookUpEditEditValueChanging(object sender, ChangingEventArgs e)
    {
      Order = viewOrder.GetFocusedRow() as Order;

      if (Order != null && e.NewValue != null)
      {
        Order.FkOrderCompany = (int)e.NewValue;
        Order.FkOrderClient = 0;
        Order.FkOrderAddress = 0;
      }
    }

    private void ViewOrderInvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewOrderRowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
    {
      viewOrder.SetFocusedRowCellValue(colIdentity, (e.Row as Order).SaveObject());
    }

    private void ViewOrderRowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
    {
      if (e.Clicks == 2)
      {
        OpenOrder();
      }
    }
  }
}
