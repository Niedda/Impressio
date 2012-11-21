using System;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Views
{
  public partial class OrderParam : XtraForm
  {
    public OrderParam()
    {
      InitializeComponent();
    }

    public int OrderId;

    private void SaveOrderClick(object sender, EventArgs e)
    {
      _errorProvider.SetError(orderTitle, string.IsNullOrEmpty(orderTitle.Text) ? "Bitte einen gültigen Wert eingeben" : "");
      _errorProvider.SetError(orderTitle, string.IsNullOrEmpty(orderKind.Text) ? "Bitte einen gültigen Wert eingeben" : "");

      if(!_errorProvider.HasErrors)
      {
        var order = new Order
                   {
                     Identity = OrderId,
                   };
        order.LoadSingleObject();
        var newId = order.CopyOrder();
        order.OrderName = order.OrderName.Replace("[Kopie]", "[Vordefiniert]");
        order.IsPredefined = true;
        order.SaveObject();

        new PredefinedOrder
        {
          Name = orderTitle.Text,
          Kind = orderKind.Text,
          Pages = (int)pages.Value,
          ColorBack = (int)colorBack.Value,
          ColorFront = (int)colorFront.Value,
          FkOrderId = newId,
          Quantity = (int)quantity.Value,
        }.SaveObject();
        Close();
      }
    }

    private readonly DXErrorProvider _errorProvider = new DXErrorProvider();
  }
}