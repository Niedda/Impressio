using System;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Impressio.Models;
using Impressio.Views;
using Type = Impressio.Models.Type;

namespace Impressio.Controls
{
  public class OrderHandler : IControlHandler
  {
    public OrderHandler(OrderRibbonView view, Order order)
    {
      _orderView = view;
      _order = order;
      ActiveControl = (_positionControl = new PositionControl { Order = order, });
      view.RegisterControl(_positionControl);
    }

    public IControl ActiveControl { get; set; }

    public IControl DetailControl { get; set; }

    public bool Validate()
    {
      if (DetailControl == null)
      {
        return ActiveControl.ValidateControl();
      }
      return DetailControl.ValidateControl();
    }

    public bool BringDefaultToFront()
    {
      if (DetailControl != null)
      {
        _orderView.UnregisterRibbon(DetailControl.RibbonPage);
        _orderView.UnregisterControl(DetailControl);
      }
      if (ActiveControl != _positionControl)
      {
        _orderView.UnregisterRibbon(ActiveControl.RibbonPage);
        _orderView.UnregisterControl(ActiveControl);
      }

      ActiveControl = _positionControl;
      _positionControl.ReloadControl();
      _positionControl.BringToFront();
      return true;
    }

    public void PageChanged(object sender, EventArgs e)
    {
      if (_orderView.ribbon.SelectedPage == _orderView.orderPage)
      {
        BringDefaultToFront();
      }
      else if (ActiveControl == _deliveryOverviewControl && DetailControl != null && _orderView.ribbon.SelectedPage != DetailControl.RibbonPage)
      {
        _orderView.UnregisterRibbon(DetailControl.RibbonPage);
        _orderView.UnregisterControl(DetailControl);
      }
    }

    public void PageChanging(object sender, RibbonPageChangingEventArgs e)
    {
      e.Cancel = !Validate();
    }

    public void Refresh(object sender, EventArgs e)
    {
      _positionControl.ReloadControl();
    }

    public void OpenPosition(object sender, ItemClickEventArgs itemClickEventArgs)
    {
      if (_positionControl.FocusedRow != null)
      {
        switch (_positionControl.FocusedRow.Type)
        {
          case Type.Datenaufbereitung:
            ActiveControl = new DataControl { Data = new Data { Identity = _positionControl.FocusedRow.Identity, } };
            break;
          case Type.Digitaldruck:
            ActiveControl = new PrintControl { Print = new Print { Identity = _positionControl.FocusedRow.Identity, } };
            break;
          case Type.Offsetdruck:
            ActiveControl = new OffsetControl { Offset = new Offset { Identity = _positionControl.FocusedRow.Identity, } };
            break;
          case Type.Weiterverarbeitung:
            ActiveControl = new FinishControl { Finish = new Finish { Identity = _positionControl.FocusedRow.Identity, } };
            break;
        }
        _orderView.RegisterControl(ActiveControl);
        _orderView.RegisterRibbon(ActiveControl.RibbonPage);
      }
    }

    public void DeletePosition(object sender, ItemClickEventArgs e)
    {
      _positionControl.DeleteRow();
    }

    public void PrintOrder(object sender, ItemClickEventArgs e)
    {
      _order.LoadOrderReport();
    }

    public void PrintOffer(object sender, ItemClickEventArgs e)
    {
      _order.LoadOfferReport();
    }

    public void Description(object sender, ItemClickEventArgs e)
    {
      ActiveControl = new DescriptionControl { Order = _order };
      _orderView.RegisterControl(ActiveControl);
      _orderView.RegisterRibbon(ActiveControl.RibbonPage);
    }

    public void Delivery(object sender, ItemClickEventArgs e)
    {
      ActiveControl = (_deliveryOverviewControl = new DeliveryOverviewControl { Order = _order, });
      _orderView.RegisterControl(ActiveControl);
      _orderView.RegisterRibbon(ActiveControl.RibbonPage);
      _deliveryOverviewControl.OpenDelivery.ItemClick += OpenDelivery;
    }

    public void OpenDelivery(object sender, EventArgs e)
    {
      if (_deliveryOverviewControl.FocusedRow != null && _deliveryOverviewControl.ValidateControl())
      {
        DetailControl = new DeliveryControl {Delivery = _deliveryOverviewControl.FocusedRow};
        _orderView.RegisterControl(DetailControl);
        _orderView.RegisterRibbon(DetailControl.RibbonPage);
      }
    }

    private DeliveryOverviewControl _deliveryOverviewControl;

    private readonly Order _order;

    private readonly PositionControl _positionControl;

    private readonly OrderRibbonView _orderView;
  }
}
