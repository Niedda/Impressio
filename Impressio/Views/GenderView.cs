using System;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using Impressio.Controls;

namespace Impressio.Views
{
  public partial class GenderView : XtraForm
  {
    private readonly GenderControl _genderControl = new GenderControl();

    public GenderView()
    {
      InitializeComponent();
    }

    private void GenderViewLoad(object sender, EventArgs e)
    {
      mainPanel.Controls.Add(_genderControl);
    }

    private void NavBarItem1LinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _genderControl.DeleteRow();
    }
  }
}