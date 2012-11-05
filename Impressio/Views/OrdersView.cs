using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;

namespace Impressio.Views
{
  public partial class OrdersView : XtraForm
  {
    public OrdersView()
    {
      InitializeComponent();
    }

    private void NavDeleteOrderLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      ordersControl.DeleteRow();
    }

    private void NavCopyOrderLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      //TODO: implement
    }

    private void NavOpenOrderLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      ordersControl.OpenOrder();
    }

    private void NavPrintOverviewLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      ordersControl.LoadReport();
    }

    private void NavPrintOfferLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      ordersControl.LoadOffer();
    }

    private void NavRefreshLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      ordersControl.ReloadControl();
    }
  }
}