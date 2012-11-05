using System;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using Impressio.Controls;

namespace Impressio.Views
{
  public partial class MachineView : XtraForm
  {
    private readonly MachineControl _machineControl = new MachineControl();

    public MachineView()
    {
      InitializeComponent();
    }

    private void MachineViewLoad(object sender, EventArgs e)
    {
      mainPanel.Controls.Add(_machineControl);
    }

    private void NavDeleteMachineLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _machineControl.DeleteRow();
    }

    private void NavRefreshLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _machineControl.ReloadControl();
    }
  }
}