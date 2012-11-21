using DevExpress.XtraReports.UI;
using Impressio.Models.Tools;

namespace Impressio.Reports
{
  public partial class OrderReport : XtraReport
  {
    public OrderReport()
    {
      InitializeComponent();
    }

    private void ReportDatasBeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
      if (reportDatas.GetCurrentColumnValue("Identity").GetInt() == 0)
      {
        e.Cancel = true;
      }
    }

    private void ReportPrintsBeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
      if(reportPrints.GetCurrentColumnValue("Identity").GetInt() == 0)
      {
        e.Cancel = true;
      }
    }

    private void ReportOffsetsBeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
      if(reportOffsets.GetCurrentColumnValue("Identity").GetInt() == 0)
      {
        e.Cancel = true;
      }
    }

    private void ReportFinishesBeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
      if(reportFinishes.GetCurrentColumnValue("Identity").GetInt() == 0)
      {
        e.Cancel = true;
      }
    }
  }
}