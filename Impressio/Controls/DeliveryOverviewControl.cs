using System;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Views;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class DeliveryOverviewControl : ControlBase, IControl, IGridControl<Delivery>, IRibbon
  {
    public DeliveryOverviewControl()
    {
      InitializeComponent();
    }

    #region Ribbon

    public string RibbonGroupName { get { return "Lieferscheine"; } }

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
        Text = "Lieferscheine",
        Name = "deliveryPageGroup"
      };
      pageGroup.ItemLinks.AddRange(Buttons.ToArray());

      return pageGroup;
    }

    private List<BarButtonItem> _buttons;

    private List<BarButtonItem> LoadButtons()
    {
      var refreshButton = new BarButtonItem
      {
        Caption = "Aktualisieren",
        Id = 2,
        LargeGlyph = Properties.Resources.refresh,
        LargeWidth = 80,
        Name = "deliveryRefresh"
      };
      refreshButton.ItemClick += OpenDelivery;

      return new List<BarButtonItem> { refreshButton };
    }

    public virtual void OpenDelivery(object sender, ItemClickEventArgs e)
    {
      var del = new DeliveryControl {Delivery = new Delivery {Identity = FocusedRow.Identity}};
      Parent.Controls.Add(del);
      del.Show();
      del.BringToFront();
    }

    public void ReloadControl(object sender, ItemClickEventArgs e)
    {
      ReloadControl();
    }

    #endregion

    public void ReloadControl()
    {
      _company.ClearObjectList();
      _delivery.ClearObjectList();
      companyBindingSource.DataSource = _company.LoadObjectList();
      deliveryBindingSource.DataSource = _delivery.LoadObjectList(Delivery.Columns.FkDeliveryOrder, Order.Identity);
      viewDelivery.RefreshData();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }
    
    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewDelivery.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewDelivery.ClearColumnErrors();
      CheckColumn(colDeliveryDate);
      CheckColumn(colFkDeliveryCompany);
      return !viewDelivery.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    public Delivery FocusedRow
    {
      get { return viewDelivery.GetFocusedRow() as Delivery; }
    }

    public Order Order = new Order();

    private readonly Company _company = new Company();

    private readonly Delivery _delivery = new Delivery();

    private void DeliveryOverviewControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewDeliveryValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewDeliveryInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewDelivery.SetFocusedRowCellValue(colFkDeliveryOrder, Order.Identity);
    }

    private void ViewDeliveryRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void ViewDeliveryInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }
  }
}