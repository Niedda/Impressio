using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using Impressio.Controls;

namespace Impressio.Views
{
  public partial class OrdersView : XtraForm
  {
    public OrdersView()
    {
      InitializeComponent();
      mainPanel.Controls.Add(_ordersControl);
    }

    private readonly OrdersControl _ordersControl = new OrdersControl();

    private void NavDeleteOrderLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _ordersControl.DeleteRow();
    }

    private void NavCopyOrderLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      //TODO: implement
    }

    private void NavOpenOrderLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _ordersControl.OpenOrder();
    }

    private void NavPrintOverviewLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _ordersControl.LoadReport();
    }

    private void NavPrintOfferLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _ordersControl.LoadOffer();
    }

    private void NavRefreshLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _ordersControl.ReloadControl();
    }
  }
}