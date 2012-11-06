using System;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class DeliveryControl : ControlBase, IControl, IGridControl<DeliveryPosition>
  {
    public DeliveryControl()
    {
      InitializeComponent();
    }

    public void ReloadControl()
    {
      if (Delivery != null)
      {
        _deliveryPosition.ClearObjectList();
        clientBindingSource.DataSource = Delivery.AvaibleClients;
        addressBindingSource.DataSource = Delivery.AvaibleAddresses;
        deliveryPositionBindingSource.DataSource =
          _deliveryPosition.LoadObjectList(DeliveryPosition.Columns.FkDeliveryPositionDelivery, Delivery.Identity);

        positionComboEdit.Items.AddRange(_deliveryPosition.LoadDescriptions(Delivery.FkDeliveryOrder));

        deliveryDate.Text = Delivery.DeliveryDate.ToShortDateString();
        clientLookUp.EditValue = Delivery.FkDeliveryClient;
        addressLookUp.EditValue = Delivery.FkDeliveryAddress;
      }
    }

    public bool ValidateControl()
    {
      CheckEditor(deliveryDate);

      if (!ErrorProvider.HasErrors)
      {
        Delivery.DeliveryDate = Convert.ToDateTime(deliveryDate.Text);
        Delivery.SaveObject();
        return true;
      }
      return false;
    }

    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewDeliveryPosition.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewDeliveryPosition.ClearColumnErrors();
      CheckColumn(colQuantity);
      CheckColumn(colPosition);
      return !viewDeliveryPosition.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    public DeliveryPosition FocusedRow
    {
      get { return viewDeliveryPosition.GetFocusedRow() as DeliveryPosition; }
    }

    public Delivery Delivery;

    private readonly DeliveryPosition _deliveryPosition = new DeliveryPosition();

    private void DeliveryControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewDeliveryPositionInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewDeliveryPosition.SetFocusedRowCellValue(colFkDeliveryPositionDelivery, Delivery.Identity);
    }

    private void ViewDeliveryPositionValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewDeliveryPositionRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void ViewDeliveryPositionInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void DeliveryControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = ValidateControl();
    }

    private void ClientLookUpEditValueChanged(object sender, EventArgs e)
    {
      Delivery.FkDeliveryClient = (int) clientLookUp.EditValue;
      Delivery.SaveObject();
    }

    private void AddressLookUpEditValueChanged(object sender, EventArgs e)
    {
      Delivery.FkDeliveryAddress = (int) addressLookUp.EditValue;
      Delivery.SaveObject();
    }
  }
}