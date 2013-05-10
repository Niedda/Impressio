using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Impressio.Controls;

namespace Impressio.Views
{
  public partial class MainViewRibbon : RibbonForm
  {
    public MainViewRibbon()
    {
      InitializeComponent();
    }

    public void RegisterControl(IControl controlBase)
    {
      if (!mainPanel.Controls.Contains((Control)controlBase))
      {
        mainPanel.Controls.Add((Control)controlBase);
        controlBase.ReloadControl();
        ((Control)controlBase).BringToFront();
      }
    }

    public void UnregisterControl(IControl controlBase)
    {
      if (mainPanel.Controls.Contains((Control)controlBase))
      {
        mainPanel.Controls.Remove((Control)controlBase);
        ((Control)controlBase).Dispose();
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

    private void MainViewRibbonLoad(object sender, EventArgs e)
    {
      _customerHandler = new CustomerHandler(this);
      showAddress.ItemClick += _customerHandler.Address;
      showPerson.ItemClick += _customerHandler.Client;
      showCompanies.ItemClick += _customerHandler.Company;
      deleteCustomer.ItemClick += _customerHandler.Delete;

      _propertyHandler = new PropertyHandler(this);
      properties.ItemClick += _propertyHandler.GetProperty;
      clickCosts.ItemClick += _propertyHandler.GetClickCost;
      genders.ItemClick += _propertyHandler.GetGender;
      state.ItemClick += _propertyHandler.GetState;
      papers.ItemClick += _propertyHandler.GetPaper;
      predefinedPositions.ItemClick += _propertyHandler.GetPredefined;
      predefinedDescription.ItemClick += _propertyHandler.GetDescription;
      machines.ItemClick += _propertyHandler.GetMachine;
      editOrder.ItemClick += _propertyHandler.GetOrderEdit;
      editOffer.ItemClick += _propertyHandler.GetOfferEdit;
      editDelivery.ItemClick += _propertyHandler.GetDeliveryEdit;
      predefinedOrder.ItemClick += _propertyHandler.GetPredefinedOrder;
      paperSizes.ItemClick += _propertyHandler.GetPaperSizes;
      
      RegisterControl(_ordersControl);
      ribbon.SelectedPage = ribbonPageOrder;
    }

    private void RibbonSelectedPageChanging(object sender, RibbonPageChangingEventArgs e)
    {
      e.Cancel = !(_customerHandler.Validate() && _propertyHandler.Validate() && _ordersControl.ValidateControl());
    }

    private void RibbonSelectedPageChanged(object sender, EventArgs e)
    {
      if (ribbon.SelectedPage == ribbonPageOrder)
      {
        _propertyHandler.PageChanged(sender, e);
        _customerHandler.PageChanged(sender, e);
        _ordersControl.BringToFront();
      }
      else if (ribbon.SelectedPage == ribbonPageCustomer)
      {
        _propertyHandler.PageChanged(sender, e);
        _customerHandler.PageChanged(sender, e);
      }
      else
      {
        _customerHandler.PageChanged(sender, e);
        _propertyHandler.PageChanged(sender, e);
      }
    }

    private void OpenOrderItemClick(object sender, ItemClickEventArgs e)
    {
      _ordersControl.OpenOrder();
    }

    private void DeleteOrderItemClick(object sender, ItemClickEventArgs e)
    {
      _ordersControl.DeleteRow();
    }

    private void PrintOrderItemClick(object sender, ItemClickEventArgs e)
    {
      if (_ordersControl.FocusedRow != null)
      {
        _ordersControl.FocusedRow.LoadOrderReport();
      }
    }

    private void PrintOfferItemClick(object sender, ItemClickEventArgs e)
    {
      if (_ordersControl.FocusedRow != null)
      {
        _ordersControl.FocusedRow.LoadOfferReport();
      }
    }

    private void RefreshOrderItemClick(object sender, ItemClickEventArgs e)
    {
      _ordersControl.ReloadControl();
    }

    private void CopyOrderItemClick(object sender, ItemClickEventArgs e)
    {
      if (_ordersControl.FocusedRow != null)
      {
        _ordersControl.FocusedRow.CopyOrder();
        _ordersControl.ReloadControl();
      }
    }

    private CustomerHandler _customerHandler;

    private PropertyHandler _propertyHandler;

    private readonly OrdersControl _ordersControl = new OrdersControl();

    private void CreateOrderWizardItemClick(object sender, ItemClickEventArgs e)
    {
      var wiz = new OrderWizard();
      if(wiz.ShowDialog() != DialogResult.Cancel)
      {
        new OrderRibbonView(wiz.Order).Show();
      }
    }
  }
}