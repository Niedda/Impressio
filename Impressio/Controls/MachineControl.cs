using System;
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
  public partial class MachineControl : BaseControlImpressio, IControl, IGridControl<Machine>, IRibbon
  {
    public MachineControl()
    {
      InitializeComponent();
    }
    
    #region Ribbon

    public string RibbonGroupName { get { return "Druckmaschinen"; } }

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
        Text = "Maschinen",
        Name = "machinePageGroup"
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
        Name = "machineDelete",
      };
      deleteButton.ItemClick += DeleteRow;

      var refreshButton = new BarButtonItem
      {
        Caption = "Aktualisieren",
        Id = 2,
        LargeGlyph = Properties.Resources.refresh,
        LargeWidth = 80,
        Name = "machineRefresh"
      };
      refreshButton.ItemClick += ReloadControl;

      return new List<BarButtonItem> { deleteButton, refreshButton };
    }

    public void DeleteRow(object sender, ItemClickEventArgs e)
    {
      DeleteRow();
    }

    public void ReloadControl(object sender, ItemClickEventArgs e)
    {
      ReloadControl();
    }

    #endregion

    public void ReloadControl()
    {
      _machine.ClearObjectList();
      machineBindingSource.DataSource = _machine.LoadObjectList();
      viewMachine.RefreshData();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }
    
    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewMachine.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewMachine.ClearColumnErrors();
      CheckColumn(colName);
      CheckColumn(colCostPerHour);
      CheckColumn(colPlateCost);
      CheckColumn(colPricePerColor);
      CheckColumn(colSpeed);
      return !viewMachine.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    public Machine FocusedRow
    {
      get { return viewMachine.GetFocusedRow() as Machine; }
    }

    private readonly Machine _machine = new Machine();

    private void MachineControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewMachineInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewMachineValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewMachineRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void MachineControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }
  }
}