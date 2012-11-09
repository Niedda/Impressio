using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
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

    public static MainViewRibbon Instance { get { return _instance ?? (_instance = new MainViewRibbon()); } }

    private static MainViewRibbon _instance;

    public Control FocusedControl
    {
      get { return _focusedControl; }
      set
      {
        _focusedControl = value;
        _focusedControl.BringToFront();
      }
    }

    private Control _focusedControl;

    public Control FocusedDetailControl;

    private RibbonPage _customPage;

    private RibbonPage _customPageLevel2;

    #region Main Controls

    private readonly OrdersControl _ordersControl = new OrdersControl();

    private readonly CompanyControl _companyControl = new CompanyControl();

    private readonly PropertieControl _propertieControl = new PropertieControl();

    private PaperControl _paperControl;

    private MachineControl _machineControl;

    private ClickCostControl _clickCostControl;

    private GenderControl _genderControl;

    private StateControl _stateControl;

    private PredefinedPositionControl _predefinedPositionControl;

    private DescriptionControl _descriptionControl;

    #endregion

    public void SetControl<T>(ref T control) where T : Control, new()
    {
      if (control == null)
      {
        control = new T();
        mainPanel.Controls.Add(control);
      }
      control.BringToFront();
      FocusedControl = control;
    }

    public void SetCustomRibbon(IRibbon ribbons)
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

    public void SetCustomRibbon(IRibbon ribbons, bool append)
    {
      if (!append)
      {
        SetCustomRibbon(ribbons);
      }
      else
      {
        _customPageLevel2 = new RibbonPage
                              {
                                Text = ribbons.RibbonGroupName,
                              };
        _customPageLevel2.Groups.Add(ribbons.GetRibbon());
        ribbon.Pages.Add(_customPageLevel2);
        ribbon.SelectedPage = _customPageLevel2;
      }
    }

    public void DeleteCustomRibbon()
    {
      if (_customPage != null)
      {
        _customPage.Dispose();
      }
      DeleteCustomRibbonLevel2();
    }

    public void DeleteCustomRibbonLevel2()
    {
      if (_customPageLevel2 != null)
      {
        _customPageLevel2.Dispose();
      }
    }

    public void DeleteCustomControlLevel2()
    {
      if (FocusedDetailControl != null)
      {
        FocusedDetailControl.Dispose();
      }
    }

    private void MainViewRibbonLoad(object sender, EventArgs e)
    {
      mainPanel.Controls.Add(_ordersControl);
      mainPanel.Controls.Add(_propertieControl);
      mainPanel.Controls.Add(_companyControl);
    }

    private void RibbonSelectedPageChanged(object sender, EventArgs e)
    {
      if (ribbon.SelectedPage == ribbonPageCustomer)
      {
        DeleteCustomRibbon();
        FocusedControl = _companyControl;
      }
      else if (ribbon.SelectedPage == ribbonPageOrder)
      {
        DeleteCustomRibbon();
        FocusedControl = _ordersControl;
      }
      else if (ribbon.SelectedPage == ribbonPageProperties)
      {
        DeleteCustomRibbon();
        FocusedControl = _propertieControl;
      }
      else if (ribbon.SelectedPage == _customPage)
      {
        if (FocusedDetailControl != null)
        {
          FocusedDetailControl.Refresh();
          FocusedDetailControl.Dispose();
        }
        DeleteCustomRibbonLevel2();
        DeleteCustomControlLevel2();
      }
    }

    private void ShowAddressItemClick(object sender, ItemClickEventArgs e)
    {
      if (_companyControl.OpenAddress())
      {
        FocusedControl = _companyControl.AddressControl;
      }
    }

    private void ShowPersonItemClick(object sender, ItemClickEventArgs e)
    {
      if (_companyControl.OpenClient())
      {
        FocusedControl = _companyControl.ClientControl;
      }
    }

    private void ShowCompaniesItemClick(object sender, ItemClickEventArgs e)
    {
      if (_companyControl.ValidateAddressAndClient())
      {
        FocusedControl = _companyControl;
      }
    }

    private void DeleteEntryItemClick(object sender, ItemClickEventArgs e)
    {
      if (FocusedControl == _companyControl)
      {
        _companyControl.DeleteRow();
      }
      else if (FocusedControl == _companyControl.AddressControl)
      {
        _companyControl.AddressControl.DeleteRow();
      }
      else if (FocusedControl == _companyControl.ClientControl)
      {
        _companyControl.ClientControl.DeleteRow();
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

    private void PredefinedDescriptionItemClick(object sender, ItemClickEventArgs e)
    {
      _descriptionControl = new DescriptionControl { IsPredefinedMode = true };
      mainPanel.Controls.Add(_descriptionControl);
      SetControl(ref _descriptionControl);
      SetCustomRibbon(_descriptionControl);
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

    private void PrintOrderItemClick(object sender, ItemClickEventArgs e)
    {
      _ordersControl.FocusedRow.LoadOrderReport();
    }

    private void PrintOfferItemClick(object sender, ItemClickEventArgs e)
    {
      _ordersControl.FocusedRow.LoadOrderOffer();
    }
  }
}