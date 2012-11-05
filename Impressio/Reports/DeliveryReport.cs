using DevExpress.XtraReports.UI;
using Impressio.Models;

namespace Impressio.Reports
{
  public partial class DeliveryReport : XtraReport
  {
    public DeliveryReport()
    {
      InitializeComponent();
    }

    public void LoadReport(Order order, Delivery delivery)
    {
      //var deliveryPositions = new DeliveryPosition
      //                          {
      //                            FkDeliveryPositionDelivery = delivery.Identity,
      //                          };
      //deliveryPositionBindingSource.DataSource = deliveryPositions.DeliveryPositions;

      //deliveryDateLabel.Text += delivery.DeliveryDate;
      //orderNameLabel.Text = order.OrderName;
      //orderNumberLabel.Text += order.Identity;

      //var company = new Company();

      //company =
      //  (from co in company.Companies where co.Identity == delivery.FkDeliveryCompany select co).FirstOrDefault();
      //var client =
      //  (from cl in company.Clients where cl.Identity == delivery.FkDeliveryClient select cl).FirstOrDefault();
      //var address =
      //  (from ad in company.Addresses where ad.Identity == delivery.FkDeliveryAddress select ad).FirstOrDefault();

      //companyLabel.Text = company.CompanyName + Environment.NewLine;

      //if (client != null)
      //{
      //  companyLabel.Text += client.FullName + Environment.NewLine;
      //}
      //if (address != null)
      //{
      //  companyLabel.Text += string.Format("{0} {1}{2}{3} {4}", address.Street, address.StreetNumber, Environment.NewLine, address.ZipCode, address.City);
      //}

      //footerLabel.Text = Settings.Default.User;
    }
  }
}