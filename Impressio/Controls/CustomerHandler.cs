using System;
using Impressio.Models.Tools;
using Impressio.Views;

namespace Impressio.Controls
{
  public class CustomerHandler : IControlHandler
  {
    public CustomerHandler(MainViewRibbon view)
    {
      _mainView = view;
      ActiveControl = _companyControl;
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
        _mainView.UnregisterControl(DetailControl);
      }

      _companyControl.BringToFront();
      return true;
    }

    public void PageChanged(object sender, EventArgs e)
    {
      if (_mainView.ribbon.SelectedPage == _mainView.ribbonPageCustomer)
      {
        BringDefaultToFront();
      }
    }

    public void Company(object sender, EventArgs e)
    {
      if (DetailControl != null && DetailControl.ValidateControl())
      {
        BringDefaultToFront();
      }
    }

    public void Address(object sender, EventArgs e)
    {
      if (ActiveControl.ValidateControl() && _companyControl.FocusedRow.Usable())
      {
        DetailControl = new AddressControl { Company = _companyControl.FocusedRow };
        _mainView.RegisterControl(DetailControl);
      }
    }

    public void Client(object sender, EventArgs e)
    {
      if (ActiveControl.ValidateControl() && _companyControl.FocusedRow.Usable())
      {
        DetailControl = new ClientControl { Company = _companyControl.FocusedRow };
        _mainView.RegisterControl(DetailControl);
      }
    }

    public void Delete(object sender, EventArgs e)
    {
      if (DetailControl != null && DetailControl is ClientControl)
      {
        ((ClientControl)DetailControl).DeleteRow();
      }
      else if (DetailControl != null && DetailControl is AddressControl)
      {
        ((AddressControl)DetailControl).DeleteRow();
      }
      else
      {
        _companyControl.DeleteRow();
      }
    }

    private readonly CompanyControl _companyControl = new CompanyControl();

    private readonly MainViewRibbon _mainView;
  }
}
