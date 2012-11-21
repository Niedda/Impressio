using System;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Impressio.Models;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Views
{
  public partial class OrderWizard : XtraForm
  {
    public OrderWizard()
    {
      InitializeComponent();
    }

    public Order Order;

    private void DetailWizardPagePageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
    {
      e.Valid = ValidateDetailPage();
    }

    private bool ValidateDetailPage()
    {
      _errorProvider.SetError(orderTitle, string.IsNullOrEmpty(orderTitle.Text) ? "Bitte einen gültigen Wert eingeben" : "");
      _errorProvider.SetError(stateLookUp, stateLookUp.EditValue == null ? "Bitte einen gültigen Wert eingeben" : "");
      _errorProvider.SetError(companySearch, companySearch.EditValue == null ? "Bitte einen gültigen Wert eingeben" : "");
      return !_errorProvider.HasErrors;
    }

    private void OrderWizardLoad(object sender, EventArgs e)
    {
      _company.LoadObjectList();
      companyBindingSource.DataSource = _company.Objects;
      clientsBindingSource.DataSource = _client.Objects;
      addressesBindingSource.DataSource = _address.Objects;
      stateBindingSource.DataSource = _state.LoadObjectList();
      predefinedOrderBindingSource.DataSource = _predefinedOrder.LoadObjectList();
    }

    private void CompanySearchEditValueChanged(object sender, EventArgs e)
    {
      _company.Identity = (int)companySearch.EditValue;
      _client.ClearObjectList();
      _address.ClearObjectList();
      clientsBindingSource.DataSource = _client.LoadObjectList(Client.Columns.FkClientCompany, (int)companySearch.EditValue);
      addressesBindingSource.DataSource = _address.LoadObjectList(Address.Columns.FkAddressCompany, (int)companySearch.EditValue);
      viewClient.RefreshData();
      viewAddress.RefreshData();
    }

    private readonly Company _company = new Company();

    private readonly Client _client = new Client();

    private readonly Address _address = new Address();

    private readonly State _state = new State();

    private readonly PredefinedOrder _predefinedOrder = new PredefinedOrder();

    private readonly DXErrorProvider _errorProvider = new DXErrorProvider();

    private void OrderWizardPagePageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
    {
      if ((viewOrder.GetFocusedRow() as PredefinedOrder) != null)
      {
        var newOrder = new Order
        {
          Identity = (viewOrder.GetFocusedRow() as PredefinedOrder).FkOrderId,
        };
        newOrder.LoadSingleObject();
        newOrder.CopyOrder();
        newOrder.IsPredefined = false;
        newOrder.OrderName = orderTitle.Text;
        newOrder.FkOrderCompany = companySearch.EditValue.GetInt();
        newOrder.FkOrderClient = clientSearch.EditValue.GetInt();
        newOrder.FkOrderState = stateLookUp.EditValue.GetInt();
        newOrder.FkOrderAddress = addressSearch.EditValue.GetInt();
        newOrder.SaveObject();
        Order = newOrder;
        return;
      }
      e.Valid = false;
    }
  }
}