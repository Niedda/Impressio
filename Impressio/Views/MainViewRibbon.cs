using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Impressio.Controls;
using Impressio.Models;

namespace Impressio.Views
{
  public partial class MainViewRibbon : RibbonForm
  {
    public MainViewRibbon()
    {
      InitializeComponent();
    }

    private readonly OrdersControl _ordersControl = new OrdersControl();

    private CompanyControl _companyControl;

    private AddressControl _addressControl;

    private ClientControl _clientControl;

    private Control _focusedControl;

    private PropertieControl _propertieControl;

    private PaperControl _paperControl;

    private MachineControl _machineControl;

    private ClickCostControl _clickCostControl;

    private GenderControl _genderControl;

    private StateControl _stateControl;

    private PredefinedPositionControl _predefinedPositionControl;

    private RibbonPage _customPage;
    
    private void SetControl<T>(ref T control) where T : Control, new()
    {
      if (control == null)
      {
        control = new T();
        mainPanel.Controls.Add(control);
      }
      control.BringToFront();
    }

    private void SetCustomRibbon(IRibbon ribbons)
    {
      DeleteCustomRibbon();
      _customPage = new RibbonPage
      {
        Text = ribbons.RibbonGroupName,
      };
      _customPage.Groups.Add(ribbons.GetRibbon());
      ribbon.Pages.Add(_customPage);
      ribbon.SelectedPage = _customPage;
    }

    private void DeleteCustomRibbon()
    {
      if (_customPage != null)
      {
        _customPage.Dispose();
      }
    }

    private void MainViewRibbonLoad(object sender, EventArgs e)
    {
      mainPanel.Controls.Add(_ordersControl);
      _focusedControl = _companyControl;
    }

    private void RibbonSelectedPageChanged(object sender, EventArgs e)
    {
      if (ribbon.SelectedPage == ribbonPageCustomer)
      {
        DeleteCustomRibbon();
        if (_companyControl == null)
        {
          _companyControl = new CompanyControl();
          mainPanel.Controls.Add(_companyControl);
        }
        _companyControl.BringToFront();
      }
      else if (ribbon.SelectedPage == ribbonPageOrder)
      {
        DeleteCustomRibbon();
        _ordersControl.BringToFront();
      }
      else if (ribbon.SelectedPage == ribbonPageProperties)
      {
        DeleteCustomRibbon();
        if (_propertieControl == null)
        {
          _propertieControl = new PropertieControl();
          mainPanel.Controls.Add(_propertieControl);
        }
        _propertieControl.BringToFront();
      }
    }

    private void ShowAddressItemClick(object sender, ItemClickEventArgs e)
    {
      if (_addressControl == null)
      {
        _addressControl = new AddressControl();
        mainPanel.Controls.Add(_addressControl);
      }
      _addressControl.Company = _companyControl.FocusedRow;
      _addressControl.ReloadControl();
      _addressControl.BringToFront();
      _focusedControl = _addressControl;
    }

    private void ShowPersonItemClick(object sender, ItemClickEventArgs e)
    {
      if (_clientControl == null)
      {
        _clientControl = new ClientControl();
        mainPanel.Controls.Add(_clientControl);
      }
      _clientControl.Company = _companyControl.FocusedRow;
      _clientControl.ReloadControl();
      _clientControl.BringToFront();
      _focusedControl = _clientControl;
    }

    private void ShowCompaniesItemClick(object sender, ItemClickEventArgs e)
    {
      _focusedControl = _companyControl;
      _companyControl.BringToFront();
    }

    private void DeleteEntryItemClick(object sender, ItemClickEventArgs e)
    {
      if (_focusedControl == _companyControl)
      {
        if (!_companyControl.FocusedRow.HasOrders())
        {
          _companyControl.DeleteRow();
        }
        else
        {
          XtraMessageBox.Show(
            "Der gewählte Kunde hat noch Aufträge. Bitte löschen Sie diese zuerst und versuchen Sie es erneut.",
            "Fehler");
        }
      }
      else if (_focusedControl == _addressControl)
      {
        _addressControl.DeleteRow();
      }
      else if (_focusedControl == _clientControl)
      {
        _clientControl.DeleteRow();
      }
    }

    private void PapersItemClick(object sender, ItemClickEventArgs e)
    {
      SetControl(ref _paperControl);
      SetCustomRibbon(_paperControl);
    }

    private void MachinesItemClick(object sender, ItemClickEventArgs e)
    {
      SetControl(ref _machineControl);
      SetCustomRibbon(_machineControl);
    }

    private void ClickCostsItemClick(object sender, ItemClickEventArgs e)
    {
      SetControl(ref _clickCostControl);
      SetCustomRibbon(_clickCostControl);
    }

    private void GendersItemClick(object sender, ItemClickEventArgs e)
    {
      SetControl(ref _genderControl);
      SetCustomRibbon(_genderControl);
    }

    private void StateItemClick(object sender, ItemClickEventArgs e)
    {
      SetControl(ref _stateControl);
      SetCustomRibbon(_stateControl);
    }

    private void PredefinedPositionsItemClick(object sender, ItemClickEventArgs e)
    {
      SetControl(ref _predefinedPositionControl);
      SetCustomRibbon(_predefinedPositionControl);
    }

    private void OpenOrderItemClick(object sender, ItemClickEventArgs e)
    {
      _ordersControl.OpenOrder();
    }

    private void DeleteOrderItemClick(object sender, ItemClickEventArgs e)
    {
      _ordersControl.DeleteRow();
    }
  }
}