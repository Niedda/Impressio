using System;
using Impressio.Models;
using Impressio.Models.Tools;
using Impressio.Views;
using Type = Impressio.Models.Type;

namespace Impressio.Controls
{
  public class PropertyHandler : IControlHandler
  {
    public PropertyHandler(MainViewRibbon view)
    {
      _mainView = view;
      ActiveControl = (_propertieControl = new PropertieControl());
      _mainView.RegisterControl(ActiveControl);
    }

    public IControl ActiveControl { get; set; }

    public IControl DetailControl { get; set; }

    public bool Validate()
    {
      if (DetailControl != null)
      {
        return DetailControl.ValidateControl();
      }
      return ActiveControl.ValidateControl();
    }

    public bool BringDefaultToFront()
    {
      if (DetailControl != null)
      {
        _mainView.UnregisterRibbon(DetailControl.RibbonPage);
        _mainView.UnregisterControl(DetailControl);
      }

      if (ActiveControl != _propertieControl)
      {
        _mainView.UnregisterRibbon(ActiveControl.RibbonPage);
        _mainView.UnregisterControl(ActiveControl);
      }

      ActiveControl = _propertieControl;
      _propertieControl.BringToFront();
      return true;
    }

    public void PageChanged(object sender, EventArgs e)
    {
      if (_mainView.ribbon.SelectedPage == _mainView.ribbonPageProperties)
      {
        BringDefaultToFront();
      }
      else if (_mainView.ribbon.SelectedPage == ActiveControl.RibbonPage && DetailControl != null)
      {
        _mainView.UnregisterRibbon(DetailControl.RibbonPage);
        _mainView.UnregisterControl(DetailControl);
      }
      else if (DetailControl != null && _mainView.ribbon.SelectedPage == DetailControl.RibbonPage)
      {
      }
      else if (ActiveControl != null && _mainView.ribbon.SelectedPage != ActiveControl.RibbonPage)
      {
        BringDefaultToFront();
      }
    }

    public void GetProperty(object sender, EventArgs e)
    {
      if (Validate() && ActiveControl != _propertieControl)
      {
        BringDefaultToFront();
      }
    }

    public void GetDescription(object sender, EventArgs e)
    {
      if (Validate())
      {
        if (ActiveControl != _propertieControl)
        {
          _mainView.UnregisterRibbon(ActiveControl.RibbonPage);
          _mainView.UnregisterControl(ActiveControl);
        }
        ActiveControl = (new DescriptionControl { IsPredefinedMode = true, });
        _mainView.RegisterControl(ActiveControl);
        _mainView.RegisterRibbon(ActiveControl.RibbonPage);
      }
    }

    public void GetClickCost(object sender, EventArgs e)
    {
      if (Validate())
      {
        if (ActiveControl != _propertieControl)
        {
          _mainView.UnregisterRibbon(ActiveControl.RibbonPage);
          _mainView.UnregisterControl(ActiveControl);
        }
        ActiveControl = (new ClickCostControl());
        _mainView.RegisterControl(ActiveControl);
        _mainView.RegisterRibbon(ActiveControl.RibbonPage);
      }
    }

    public void GetGender(object sender, EventArgs e)
    {
      if (Validate())
      {
        if (ActiveControl != _propertieControl)
        {
          _mainView.UnregisterRibbon(ActiveControl.RibbonPage);
          _mainView.UnregisterControl(ActiveControl);
        }
        ActiveControl = (new GenderControl());
        _mainView.RegisterControl(ActiveControl);
        _mainView.RegisterRibbon(ActiveControl.RibbonPage);
      }
    }

    public void GetPaper(object sender, EventArgs e)
    {
      if (Validate())
      {
        if (ActiveControl != _propertieControl)
        {
          _mainView.UnregisterRibbon(ActiveControl.RibbonPage);
          _mainView.UnregisterControl(ActiveControl);
        }
        ActiveControl = (new PaperControl());
        _mainView.RegisterControl(ActiveControl);
        _mainView.RegisterRibbon(ActiveControl.RibbonPage);
      }
    }

    public void GetMachine(object sender, EventArgs e)
    {
      if (Validate())
      {
        if (ActiveControl != _propertieControl)
        {
          _mainView.UnregisterRibbon(ActiveControl.RibbonPage);
          _mainView.UnregisterControl(ActiveControl);
        }
        ActiveControl = (new MachineControl());
        _mainView.RegisterControl(ActiveControl);
        _mainView.RegisterRibbon(ActiveControl.RibbonPage);
      }
    }

    public void GetState(object sender, EventArgs e)
    {
      if (Validate())
      {
        if (ActiveControl != _propertieControl)
        {
          _mainView.UnregisterRibbon(ActiveControl.RibbonPage);
          _mainView.UnregisterControl(ActiveControl);
        }
        ActiveControl = (new StateControl());
        _mainView.RegisterControl(ActiveControl);
        _mainView.RegisterRibbon(ActiveControl.RibbonPage);
      }
    }

    public void GetOfferEdit(object sender, EventArgs e)
    {
      Order.LoadOfferDesigner();
    }

    public void GetOrderEdit(object sender, EventArgs e)
    {
      Order.LoadOrderDesigner();
    }

    public void GetDeliveryEdit(object sender, EventArgs e)
    {
      Delivery.LoadDeliveryDesigner();
    }

    public void GetPredefined(object sender, EventArgs e)
    {
      if (Validate())
      {
        if (ActiveControl != _propertieControl)
        {
          _mainView.UnregisterRibbon(ActiveControl.RibbonPage);
          _mainView.UnregisterControl(ActiveControl);
        }

        ActiveControl = (_predefinedPositionControl = new PredefinedPositionControl());
        _mainView.RegisterControl(_predefinedPositionControl);
        _predefinedPositionControl.OpenPositionButton.ItemClick += OpenPositionClick;
        _mainView.RegisterRibbon(_predefinedPositionControl.RibbonPage);        
      }
    }

    public void OpenPositionClick(object sender, EventArgs e)
    {
      if (_predefinedPositionControl.FocusedRow != null && _predefinedPositionControl.FocusedRow.Usable())
      {
        switch (_predefinedPositionControl.FocusedRow.Type)
        {
          case Type.Datenaufbereitung:
            DetailControl = ((new DataControl { Data = new Data { Identity = _predefinedPositionControl.FocusedRow.Identity } }));
            break;
          case Type.Digitaldruck:
            DetailControl = ((new PrintControl { Print = new Print { Identity = _predefinedPositionControl.FocusedRow.Identity } }));
            break;
          case Type.Offsetdruck:
            DetailControl = ((new OffsetControl { Offset = new Offset { Identity = _predefinedPositionControl.FocusedRow.Identity } }));
            break;
          case Type.Weiterverarbeitung:
            DetailControl = (new FinishControl { Finish = new Finish { Identity = _predefinedPositionControl.FocusedRow.Identity } });
            break;
        }
        _mainView.RegisterControl(DetailControl);
        _mainView.RegisterRibbon(DetailControl.RibbonPage);
      }
    }

    private PredefinedPositionControl _predefinedPositionControl;

    private readonly PropertieControl _propertieControl;

    private readonly MainViewRibbon _mainView;
  }
}
