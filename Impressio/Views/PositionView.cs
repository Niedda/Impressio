using System;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using Impressio.Models;

namespace Impressio.Views
{
  public partial class PositionView : XtraForm
  {
    public Order Order;

    public PositionView()
    {
      InitializeComponent();
    }

    private void PositionViewLoad(object sender, EventArgs e)
    {
      positionControl.Order = Order;
      positionControl.ReloadControl();
    }

    private void NavOpenPositionLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      positionControl.OpenPosition();
    }

    private void NavOpenDescriptionLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      var view = new DescriptionView
                   {
                     Order = Order,
                     Text = string.Format("Beschreibung: {0}", Order.OrderName),
                   };
      view.Show();
    }

    private void NavOpenDeliveryLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      var delivery = new DeliveryView
                       {
                         Text = "Lieferscheine: " + Order.OrderName,
                         Order = Order,
                       };
      delivery.Show();
    }

    private void NavDeletePositionLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      positionControl.DeleteRow();
    }

    private void NavPrintOrderLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      positionControl.Validate();
      Order.LoadOrderReport();
    }

    private void NavRefreshPositionLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      positionControl.ReloadControl();
    }

    private void NavPrintOfferLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      positionControl.Validate();
      Order.LoadOrderOffer();
    }
  }
}