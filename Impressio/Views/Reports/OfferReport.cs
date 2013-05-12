using DevExpress.XtraReports.UI;
using Impressio.Properties;

namespace Impressio.Reports
{
  public partial class OfferReport : XtraReport
  {
    public OfferReport()
    {
      InitializeComponent();
    }

    private void OfferReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
      logoBox.ImageUrl = Settings.Default.logoImage;
      userName.Text = Settings.Default.User;
    }
  }
}