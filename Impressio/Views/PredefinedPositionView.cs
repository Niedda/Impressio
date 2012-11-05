using System;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using Impressio.Controls;

namespace Impressio.Views
{
  public partial class PredefinedPositionView : XtraForm
  {
    private readonly PredefinedPositionControl _predefinedPositionControl = new PredefinedPositionControl();

    public PredefinedPositionView()
    {
      InitializeComponent();
    }

    private void PredefinedPositionViewLoad(object sender, EventArgs e)
    {
      mainPanel.Controls.Add(_predefinedPositionControl);
    }

    private void NavOpenLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _predefinedPositionControl.OpenPosition();
    }

    private void NavDeleteLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _predefinedPositionControl.DeleteRow();
    }

    private void NavRefreshLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _predefinedPositionControl.ReloadControl();
    }
  }
}