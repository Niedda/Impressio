using System;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class Delivery : ControlBase
  {
    public Delivery()
    {
      InitializeComponent();
    }

    public Models.Delivery Delivery;

    private readonly DeliveryPosition _deliveryPosition = new DeliveryPosition();
    
    public void ReloadControl()
    {
      if (Delivery != null)
      {
        _deliveryPosition.ClearObjectList();
        clientBindingSource.DataSource = Delivery.AvaibleClients;
        addressBindingSource.DataSource = Delivery.AvaibleAddresses;
        deliveryPositionBindingSource.DataSource = _deliveryPosition.LoadObjectList(DeliveryPosition.Columns.FkDeliveryPositionDelivery, Delivery.Identity);
        
        positionComboEdit.Items.AddRange(_deliveryPosition.LoadDescriptions(Delivery.FkDeliveryOrder));

        deliveryDate.Text = Delivery.DeliveryDate;
        clientLookUp.EditValue = Delivery.FkDeliveryClient;
        addressLookUp.EditValue = Delivery.FkDeliveryAddress;
      }
    }



    private void DeliveryControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewDeliveryPositionInitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
    {
      viewDeliveryPosition.SetFocusedRowCellValue(colFkDeliveryPositionDelivery, Delivery.Identity);
    }

    private void ViewDeliveryPositionValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      viewDeliveryPosition.ClearColumnErrors();
      CheckColumn(colQuantity);
      CheckColumn(colPosition);
      e.Valid = !viewDeliveryPosition.HasColumnErrors;
    }

    private void ViewDeliveryPositionRowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
    {
      viewDeliveryPosition.SetFocusedRowCellValue(colIdentity, (e.Row as DeliveryPosition).SaveObject());
    }

    private void ViewDeliveryPositionInvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void DeliveryControlValidating(object sender, CancelEventArgs e)
    {
      ErrorProvider.ClearErrors();
      CheckEditor(deliveryDate);
      e.Cancel = ErrorProvider.HasErrors && viewDeliveryPosition.HasColumnErrors;
    }

    private void ClientLookUpEditValueChanged(object sender, EventArgs e)
    {
      Delivery.FkDeliveryClient = (int)clientLookUp.EditValue;
      Delivery.SaveObject();
    }

    private void AddressLookUpEditValueChanged(object sender, EventArgs e)
    {
      Delivery.FkDeliveryAddress = (int) addressLookUp.EditValue;
      Delivery.SaveObject();
    }
  }
}
