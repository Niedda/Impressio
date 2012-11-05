using System;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using Impressio.Controls;
using Impressio.Models;
using Impressio.Reports;

namespace Impressio.Views
{
  public partial class DeliveryView : XtraForm
  {
    public DeliveryView()
    {
      InitializeComponent();
    }

    public Order Order = new Order();

    private readonly DeliveryControl _deliveryControl = new DeliveryControl();

    private readonly DeliveryOverviewControl _deliveryOverviewControl = new DeliveryOverviewControl();
    
    private void DeliveryViewLoad(object sender, EventArgs e)
    {
      _deliveryOverviewControl.Order = Order;
      mainPanel.Controls.Add(_deliveryOverviewControl);
      mainPanel.Controls.Add(_deliveryControl);
    }

    private void NavOpenLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      var delivery = _deliveryOverviewControl.viewDelivery.GetFocusedRow() as Delivery;

      if (delivery != null)
      {
        _deliveryControl.Delivery = delivery;
        _deliveryControl.ReloadControl();
        _deliveryControl.Show();
        _deliveryControl.BringToFront();
      }
    }

    private void NavOverviewLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _deliveryOverviewControl.Show();
      _deliveryOverviewControl.BringToFront();
    }

    private void NavPrintLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      if (_deliveryOverviewControl.FocusedRow != null)
      {
        var report = new DeliveryReport
                       {
                         deliveryBindingSource = {DataSource = _deliveryOverviewControl.FocusedRow,},
                       };
        report.ShowPreview();
      }
    }
  }
}