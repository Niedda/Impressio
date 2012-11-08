using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Impressio.Controls;
using Impressio.Models;
using Type = Impressio.Models.Type;

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

    private DataControl _dataControl;

    private PrintControl _printControl;

    private OffsetControl _offsetControl;

    private FinishControl _finishControl;

    private RibbonPage _customPage;

    private RibbonPage _positionPage;

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
        if (_positionPage != null)
        {
          _positionPage.Dispose();
        }
        _companyControl.BringToFront();
      }
      else if (ribbon.SelectedPage == ribbonPageOrder)
      {
        if (_positionPage != null)
        {
          _positionPage.Dispose();
        }
        DeleteCustomRibbon();
        _ordersControl.BringToFront();
      }
      else if (ribbon.SelectedPage == ribbonPageProperties)
      {
        if (_positionPage != null)
        {
          _positionPage.Dispose();
        }
        DeleteCustomRibbon();
        if (_propertieControl == null)
        {
          _propertieControl = new PropertieControl();
          mainPanel.Controls.Add(_propertieControl);
        }
        _propertieControl.BringToFront();
      }
      else if (ribbon.SelectedPage == _positionPage)
      {
        DeleteCustomRibbon();
        _predefinedPositionControl.BringToFront();
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
      SetPositionRibbon();
    }

    private void OpenOrderItemClick(object sender, ItemClickEventArgs e)
    {
      _ordersControl.OpenOrder();
    }

    private void DeleteOrderItemClick(object sender, ItemClickEventArgs e)
    {
      _ordersControl.DeleteRow();
    }

    public string RibbonGroupName { get { return "Vordefinierte Positionen"; } }

    public void SetPositionRibbon()
    {
      var deleteButton = new BarButtonItem
      {
        Caption = "Löschen",
        Id = 2,
        LargeGlyph = Properties.Resources.delete,
        LargeWidth = 80,
        Name = "positionDelete",
      };
      deleteButton.ItemClick += DeleteRow;

      var refreshButton = new BarButtonItem
      {
        Caption = "Aktualisieren",
        Id = 3,
        LargeGlyph = Properties.Resources.refresh,
        LargeWidth = 80,
        Name = "positionRefresh"
      };
      refreshButton.ItemClick += ReloadControl;

      var openPosition = new BarButtonItem
      {
        Caption = "Position öffnen",
        Id = 1,
        LargeGlyph = Properties.Resources.open,
        LargeWidth = 80,
        Name = "positionOpen"
      };
      openPosition.ItemClick += OpenPosition;

      var pageGroup = new RibbonPageGroup
      {
        Text = "Vordefinierte Positionen",
        Name = "predefinedPositionPageGroup"
      };
      pageGroup.ItemLinks.Add(refreshButton);
      pageGroup.ItemLinks.Add(deleteButton);
      pageGroup.ItemLinks.Add(openPosition);

      _positionPage = new RibbonPage
                        {
                          Text = "Positionen",
                        };
      _positionPage.Groups.Add(pageGroup);
      ribbon.Pages.Add(_positionPage);
      ribbon.SelectedPage = _positionPage;
    }

    public void DeleteRow(object sender, ItemClickEventArgs e)
    {
      _predefinedPositionControl.DeleteRow();
    }

    public void ReloadControl(object sender, ItemClickEventArgs e)
    {
      _predefinedPositionControl.ReloadControl();
    }

    public void OpenPosition(object sender, ItemClickEventArgs e)
    {
      switch (_predefinedPositionControl.FocusedRow.Type)
      {
        case Type.Datenaufbereitung:
          SetControl(ref _dataControl);
          _dataControl.Data = new Data { Identity = _predefinedPositionControl.FocusedRow.Identity };
          _dataControl.ReloadControl();
          SetCustomRibbon(_dataControl);
          break;
        case Type.Digitaldruck:
          SetControl(ref _printControl);
          _printControl.Print = new Print { Identity = _predefinedPositionControl.FocusedRow.Identity };
          _printControl.ReloadControl();
          SetCustomRibbon(_printControl);
          break;
        case Type.Offsetdruck:
          SetControl(ref _offsetControl);
          _offsetControl.Offset = new Offset { Identity = _predefinedPositionControl.FocusedRow.Identity };
          _offsetControl.ReloadControl();
          SetCustomRibbon(_offsetControl);
          break;
        case Type.Weiterverarbeitung:
          SetControl(ref _finishControl);
          _finishControl.Finish = new Finish { Identity = _predefinedPositionControl.FocusedRow.Identity };
          _finishControl.ReloadControl();
          SetCustomRibbon(_finishControl);
          break;
      }
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