using System;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using Impressio.Controls;
using Impressio.Models;

namespace Impressio.Views
{
  public partial class DescriptionView : XtraForm
  {
    private readonly DescriptionControl _descriptionControl = new DescriptionControl();
    public Order Order;

    public DescriptionView()
    {
      InitializeComponent();
    }

    private void DescriptionViewLoad(object sender, EventArgs e)
    {
      _descriptionControl.Order = Order;
      _descriptionControl.ReloadControl();
      mainPanel.Controls.Add(_descriptionControl);
    }

    private void NavDeleteLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _descriptionControl.DeleteRow();
    }

    private void NavDeleteDetailLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _descriptionControl.DeleteDetailRow();
    }

    private void NavRefreshLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _descriptionControl.ReloadControl();
    }
  }
}