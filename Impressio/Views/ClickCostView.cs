using System;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using Impressio.Controls;

namespace Impressio.Views
{
  public partial class ClickCostView : XtraForm
  {
    private readonly ClickCostControl _clickCostControl = new ClickCostControl();

    public ClickCostView()
    {
      InitializeComponent();
    }

    private void ClickCostViewLoad(object sender, EventArgs e)
    {
      mainPanel.Controls.Add(_clickCostControl);
    }

    private void NavDeleteLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _clickCostControl.DeleteRow();
    }

    private void NavRefreshLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _clickCostControl.ReloadControl();
    }
  }
}