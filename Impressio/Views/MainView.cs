using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using Impressio.Models;
using Impressio.Models.Database;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Views
{
  public partial class MainView : XtraForm
  {
    private CustomerView _customerView = new CustomerView();

    private OrdersView _ordersView = new OrdersView();

    private PropertiesMainView _propertiesMainView = new PropertiesMainView();

    public MainView()
    {
      InitializeComponent();
    }

    private void NavCompanyLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      if (_customerView.IsDisposed)
      {
        _customerView = new CustomerView {MdiParent = this};
        _customerView.Show();
      }
      else
      {
        _customerView.Show();
        _customerView.BringToFront();
      }
    }

    private void NavOrderLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      if (_ordersView.IsDisposed)
      {
        _ordersView = new OrdersView();
        _ordersView.Show();
      }
      else
      {
        _ordersView.Show();
        _ordersView.BringToFront();
      }
    }

    private void NavPropertiesLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      if (_propertiesMainView.IsDisposed)
      {
        _propertiesMainView = new PropertiesMainView {MdiParent = this,};
        _propertiesMainView.Show();
      }
      else
      {
        _propertiesMainView.Show();
        _propertiesMainView.BringToFront();
      }
    }
  }
}