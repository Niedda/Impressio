using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class ClickCostControl : ControlBase, IControl, IGridControl<ClickCost>, IRibbon
  {
    public ClickCostControl()
    {
      InitializeComponent();
    }

    #region Ribbon
    
    public string RibbonGroupName { get { return "Klickkosten"; } }

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
        Text = "Klickkosten",
        Name = "clickCostPageGroup"
      };
      pageGroup.ItemLinks.AddRange(Buttons.ToArray());

      return pageGroup;
    }

    private List<BarButtonItem> _buttons;

    private List<BarButtonItem> LoadButtons()
    {
      var deleteButton = new BarButtonItem
      {
        Caption = "Löschen",
        Id = 1,
        LargeGlyph = Properties.Resources.delete,
        LargeWidth = 80,
        Name = "clickCostDelete",
      };
      deleteButton.ItemClick += DeleteRow;

      var refreshButton = new BarButtonItem
      {
        Caption = "Aktualisieren",
        Id = 2,
        LargeGlyph = Properties.Resources.refresh,
        LargeWidth = 80,
        Name = "clickCostRefresh"
      };
      refreshButton.ItemClick += ReloadControl;

      return new List<BarButtonItem> { deleteButton, refreshButton };
    }
    
    #endregion

    public void ReloadControl()
    {
      _clickCost.ClearObjectList();
      clickCostBindingSource.DataSource = _clickCost.LoadObjectList();
      viewClickCost.RefreshData();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }

    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewClickCost.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewClickCost.ClearColumnErrors();
      CheckColumn(colName);
      CheckColumn(colCost);
      return !viewClickCost.HasColumnErrors;
    }

    public void UpdateRow()
    {
      viewClickCost.SetFocusedRowCellValue(colIdentity, FocusedRow.SaveObject());
    }

    public void DeleteRow(object sender, ItemClickEventArgs e)
    {
      DeleteRow();
    }

    public void ReloadControl(object sender, ItemClickEventArgs e)
    {
      ReloadControl();
    }

    public ClickCost FocusedRow
    {
      get { return viewClickCost.GetFocusedRow() as ClickCost; }
    }

    private readonly ClickCost _clickCost = new ClickCost();

    private void ClickCostControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewClickCostInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewClickCostValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewClickCostRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void ClickCostControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }
  }
}