using System.Collections.Generic;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Views;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class OrdersControl : OrderControlBase
  {
    public OrdersControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override GridView GridView
    {
      get { return viewOrder; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                                         {
                                           colOrderName,
                                           colState,
                                           colCompany,
                                         });
      }
    }

    public override void ReloadControl()
    {
      Order.ClearObjectList();
      _company.ClearObjectList();
      _state.ClearObjectList();

      companiesBindingSource.DataSource = _company.LoadObjectList();
      orderBindingSource.DataSource = Order.LoadObjectList();
      stateBindingSource.DataSource = _state.LoadObjectList();
      viewOrder.RefreshData();
    }

    public void OpenOrder()
    {
      if (FocusedRow != null)
      {
        new OrderRibbonView(FocusedRow).Show();
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
        FocusedRow.LoadOfferReport();
      }
    }

    public Order Order = new Order();

    private void CompanySearchLookUpEditEditValueChanging(object sender, ChangingEventArgs e)
    {
      Order.FkOrderCompany = (int)e.NewValue;
      Order.FkOrderClient = 0;
      Order.FkOrderAddress = 0;
    }
    
    private List<GridColumn> _columns;

    private readonly Company _company = new Company();

    private readonly State _state = new State();
  }
}