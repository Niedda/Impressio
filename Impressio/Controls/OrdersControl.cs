using System;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Views;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class OrdersControl : ControlBase, IControl, IGridControl<Order>
  {
    public OrdersControl()
    {
      InitializeComponent();
    }

    public void ReloadControl()
    {
      Order.ClearObjectList();
      _company.ClearObjectList();
      _state.ClearObjectList();
      companiesBindingSource.DataSource = _company.LoadObjectList();
      orderBindingSource.DataSource = Order.LoadObjectList();
      stateBindingSource.DataSource = _state.LoadObjectList();
      viewOrder.RefreshData();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }

    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewOrder.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewOrder.ClearColumnErrors();
      CheckColumn(colOrderName);
      CheckColumn(colState);
      CheckColumn(colCompany);
      return !viewOrder.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    public void OpenOrder()
    {
      if (FocusedRow != null)
      {
        new PositionView
          {
            Order = FocusedRow,
          }.Show();
      }
    }

    public void LoadReport()
    {
      if (FocusedRow != null)
      {
        FocusedRow.LoadOrderReport();
      }
    }

    public void LoadOffer()
    {
      if (FocusedRow != null)
      {
        FocusedRow.LoadOrderOffer();
      }
    }
    
    public Order FocusedRow
    {
      get { return viewOrder.GetFocusedRow() as Order; }
    }

    public Order Order = new Order();

    private readonly Company _company = new Company();
    
    private readonly State _state = new State();

    private void OrderControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewOrderValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void CompanySearchLookUpEditEditValueChanging(object sender, ChangingEventArgs e)
    {
      Order.FkOrderCompany = (int) e.NewValue;
      Order.FkOrderClient = 0;
      Order.FkOrderAddress = 0;
    }

    private void ViewOrderInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewOrderRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void ViewOrderRowClick(object sender, RowClickEventArgs e)
    {
      if (e.Clicks == 2)
      {
        OpenOrder();
      }
    }

    private void OrdersControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }
  }
}