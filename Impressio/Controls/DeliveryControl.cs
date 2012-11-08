using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Reports;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class DeliveryControl : ControlBase, IControl, IGridControl<DeliveryPosition>, IRibbon
  {
    public DeliveryControl()
    {
      InitializeComponent();
    }

    #region Ribbon

    public string RibbonGroupName { get { return "Lieferschein"; } }

    public List<BarButtonItem> Buttons
    {
      get
      {
        return _buttons ?? (_buttons = LoadButtons());
      }
    }

    public RibbonPageGroup GetRibbon()
    {
      var pageGroup = new RibbonPageGroup
      {
        Text = "Lieferschein",
        Name = "deliveryPageGroup"
      };
      pageGroup.ItemLinks.AddRange(Buttons.ToArray());

      return pageGroup;
    }

    private List<BarButtonItem> _buttons;

    private List<BarButtonItem> LoadButtons()
    {
      var deleteDelivery = new BarButtonItem
      {
        Caption = "Löschen",
        Id = 1,
        LargeGlyph = Properties.Resources.delete,
        LargeWidth = 80,
        Name = "deliveryOpen"
      };
      deleteDelivery.ItemClick += DeleteRow;

      var refreshButton = new BarButtonItem
      {
        Caption = "Aktualisieren",
        Id = 2,
        LargeGlyph = Properties.Resources.refresh,
        LargeWidth = 80,
        Name = "deliveryRefresh"
      };
      refreshButton.ItemClick += ReloadControl;

      var printDelivery = new BarButtonItem
      {
        Caption = "Drucken",
        Id = 3,
        LargeGlyph = Properties.Resources.printglyph,
        LargeWidth = 80,
        Name = "printDelivery"
      };
      printDelivery.ItemClick += PrintDelivery;

      return new List<BarButtonItem> { refreshButton, deleteDelivery, printDelivery };
    }

    public void PrintDelivery(object sender, ItemClickEventArgs e)
    {
      Delivery.LoadDeliveryReport();
    }

    public void ReloadControl(object sender, ItemClickEventArgs e)
    {
      ReloadControl();
    }

    public void DeleteRow(object sender, ItemClickEventArgs e)
    {
      DeleteRow();
    }

    #endregion

    public void ReloadControl()
    {
      if (Delivery != null)
      {
        _deliveryPosition.ClearObjectList();
        Delivery.LoadSingleObject();
        clientBindingSource.DataSource = Delivery.AvaibleClients;
        addressBindingSource.DataSource = Delivery.AvaibleAddresses;
        deliveryPositionBindingSource.DataSource = _deliveryPosition.LoadObjectList(DeliveryPosition.Columns.FkDeliveryPositionDelivery, Delivery.Identity);

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
      e.Cancel = !ValidateControl();
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