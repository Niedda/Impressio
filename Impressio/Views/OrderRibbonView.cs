using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using Impressio.Controls;
using Impressio.Models;

namespace Impressio.Views
{
  public partial class OrderRibbonView : RibbonForm
  {
    public OrderRibbonView(Order order)
    {
      InitializeComponent();

      _orderHandler = new OrderHandler(this, order);
      openPosition.ItemClick += _orderHandler.OpenPosition;
      deletePosition.ItemClick += _orderHandler.DeletePosition;
      refresh.ItemClick += _orderHandler.Refresh;
      delivery.ItemClick += _orderHandler.Delivery;
      description.ItemClick += _orderHandler.Description;
      printOffer.ItemClick += _orderHandler.PrintOffer;
      printOrder.ItemClick += _orderHandler.PrintOrder;
      ribbon.SelectedPageChanging += _orderHandler.PageChanging;
      ribbon.SelectedPageChanged += _orderHandler.PageChanged;
    }

    public void RegisterControl(IControl control)
    {
      if (!mainPanel.Controls.Contains((Control)control))
      {
        mainPanel.Controls.Add((Control)control);
        control.ReloadControl();
        ((Control)control).BringToFront();
      }
    }

    public void UnregisterControl(IControl control)
    {
      if (mainPanel.Controls.Contains((Control)control))
      {
        mainPanel.Controls.Remove((Control)control);
        ((Control)control).Dispose();
      }
    }

    public void RegisterRibbon(RibbonPage ribbonPage)
    {
      if (!ribbon.Pages.Contains(ribbonPage) && ribbonPage != null)
      {
        ribbon.Pages.Add(ribbonPage);
        ribbon.SelectedPage = ribbonPage;
      }
    }

    public void UnregisterRibbon(RibbonPage ribbonPage)
    {
      if (ribbon.Pages.Contains(ribbonPage))
      {
        ribbon.Pages.Remove(ribbonPage);
      }
    }

    private readonly OrderHandler _orderHandler;
  }
}