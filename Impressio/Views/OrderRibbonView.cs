using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Impressio.Controls;
using Impressio.Models;
using Type = Impressio.Models.Type;

namespace Impressio.Views
{
  public partial class OrderRibbonView : RibbonForm
  {
    public OrderRibbonView()
    {
      InitializeComponent();
    }

    public Order Order = new Order();

    private readonly PositionControl _positionControl = new PositionControl();

    private DataControl _dataControl;

    private PrintControl _printControl;

    private OffsetControl _offsetControl;

    private FinishControl _finishControl;

    private DeliveryOverviewControl _deliveryOverviewControl;

    private DeliveryControl _deliveryControl;

    private DescriptionControl _descriptionControl;

    private RibbonPage _customPage;

    private RibbonPage _deliveryPage;

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

    private void OrderRibbonViewLoad(object sender, EventArgs e)
    {
      _positionControl.Order = Order;
      _positionControl.ReloadControl();
      mainPanel.Controls.Add(_positionControl);
    }

    private void OpenPositionItemClick(object sender, ItemClickEventArgs e)
    {
      switch (_positionControl.FocusedRow.Type)
      {
        case Type.Datenaufbereitung:
          SetControl(ref _dataControl);
          _dataControl.Data = new Data { Identity = _positionControl.FocusedRow.Identity };
          _dataControl.ReloadControl();
          SetCustomRibbon(_dataControl);
          break;
        case Type.Digitaldruck:
          SetControl(ref _printControl);
          _printControl.Print = new Print { Identity = _positionControl.FocusedRow.Identity };
          _printControl.ReloadControl();
          SetCustomRibbon(_printControl);
          break;
        case Type.Offsetdruck:
          SetControl(ref _offsetControl);
          _offsetControl.Offset = new Offset { Identity = _positionControl.FocusedRow.Identity };
          _offsetControl.ReloadControl();
          SetCustomRibbon(_offsetControl);
          break;
        case Type.Weiterverarbeitung:
          SetControl(ref _finishControl);
          _finishControl.Finish = new Finish { Identity = _positionControl.FocusedRow.Identity };
          _finishControl.ReloadControl();
          SetCustomRibbon(_finishControl);
          break;
        default:
          return;
      }
    }

    private void PrintOrderItemClick(object sender, ItemClickEventArgs e)
    {
      _positionControl.Order.LoadOrderReport();
    }

    private void PrintOfferItemClick(object sender, ItemClickEventArgs e)
    {
      _positionControl.Order.LoadOrderOffer();
    }

    private void DeletePositionItemClick(object sender, ItemClickEventArgs e)
    {
      _positionControl.DeleteRow();
    }

    private void DeliveryItemClick(object sender, ItemClickEventArgs e)
    {
      SetControl(ref _deliveryOverviewControl);
      SetDeliveryOverview();
      _deliveryOverviewControl.Order = Order;
      _deliveryOverviewControl.ReloadControl();
    }

    private void DescriptionItemClick(object sender, ItemClickEventArgs e)
    {
      SetControl(ref _descriptionControl);
      _descriptionControl.Order = Order;
      _descriptionControl.ReloadControl();
      SetCustomRibbon(_descriptionControl);
    }

    private void SetDeliveryOverview()
    {
      DeleteCustomRibbon();

      var pageGroup = new RibbonPageGroup
      {
        Text = "Lieferscheine",
        Name = "deliveryPageGroup"
      };

      var openDelivery = new BarButtonItem
      {
        Caption = "Aktualisieren",
        Id = 2,
        LargeGlyph = Properties.Resources.refresh,
        LargeWidth = 80,
        Name = "deliveryRefresh"
      };
      openDelivery.ItemClick += _deliveryOverviewControl.ReloadControl;

      var refreshButton = new BarButtonItem
      {
        Caption = "Öffnen",
        Id = 2,
        LargeGlyph = Properties.Resources.open,
        LargeWidth = 80,
        Name = "deliveryRefresh"
      };
      refreshButton.ItemClick += OpenDeliveryLinkClick;
      
      pageGroup.ItemLinks.Add(openDelivery);
      pageGroup.ItemLinks.Add(refreshButton);

      _deliveryPage = new RibbonPage
      {
        Text = "Lieferscheine",
      };
      _deliveryPage.Groups.Add(pageGroup);
      ribbon.Pages.Add(_deliveryPage);
      ribbon.SelectedPage = _deliveryPage;
    }

    private void OpenDeliveryLinkClick(object sender, ItemClickEventArgs e)
    {
      SetControl(ref _deliveryControl);
      SetCustomRibbon(_deliveryControl);
      _deliveryControl.Delivery = _deliveryOverviewControl.FocusedRow;
      _deliveryControl.ReloadControl();
    }
    
    private void RibbonSelectedPageChanged(object sender, EventArgs e)
    {
      if (ribbon.SelectedPage == ribbonPageOrder)
      {
        DeleteCustomRibbon();
        _positionControl.BringToFront();

        if(_deliveryPage != null)
        {
          _deliveryPage.Dispose();
        }
      }
      else if(ribbon.SelectedPage == _deliveryPage)
      {
        DeleteCustomRibbon();
        _deliveryOverviewControl.BringToFront();
      }
    }
  }
}