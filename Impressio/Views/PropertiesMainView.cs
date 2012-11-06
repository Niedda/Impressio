using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using Impressio.Controls;

namespace Impressio.Views
{
  public partial class PropertiesMainView : XtraForm
  {
    public PropertiesMainView()
    {
      InitializeComponent();
    }

    private void NavMachineLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      new MachineView().Show();
    }

    private void NavDescriptionLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      new DescriptionView().Show();
    }

    private void NavPaperLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      new PaperView
        {
          MdiParent = Program.MainView,
        }.Show();
    }

    private void NavClickCostLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      new ClickCostView().Show();
    }

    private void NavGenderLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      new GenderView().Show();
    }

    private void NavPositionLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      new PredefinedPositionView().Show();
    }

    private void NavPropertiesLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      var dia = new EmptyView
                  {
                    Width = 570, 
                    Height = 450,
                    MinimumSize = new System.Drawing.Size(570, 450),
                    MaximumSize = new System.Drawing.Size(570,450),
                  };
      dia.mainPanel.Controls.Add(new PropertieControl());
      dia.Show();
    }

    private void NavStateLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      var dia = new EmptyView();
      dia.mainPanel.Controls.Add(new StateControl());
      dia.Show();
    }
  }
}