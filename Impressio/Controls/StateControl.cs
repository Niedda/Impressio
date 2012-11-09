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
  public partial class StateControl : BaseControlImpressio, IControl, IGridControl<State>, IRibbon
  {
    public StateControl()
    {
      InitializeComponent();
    }

    #region Ribbon

    public string RibbonGroupName { get { return "Auftragsstatus"; } }

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
        Text = "Auftragsstatus",
        Name = "statePageGroup"
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
        Name = "sateDelete",
      };
      deleteButton.ItemClick += DeleteRow;

      var refreshButton = new BarButtonItem
      {
        Caption = "Aktualisieren",
        Id = 2,
        LargeGlyph = Properties.Resources.refresh,
        LargeWidth = 80,
        Name = "stateRefresh"
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
      _state.ClearObjectList();
      stateBindingSource.DataSource = _state.LoadObjectList();
      viewState.RefreshData();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }

    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewState.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      CheckColumn(colStateName);
      return !viewState.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    public State FocusedRow
    {
      get { return viewState.GetFocusedRow() as State; }
    }

    private readonly State _state = new State();

    private void StateControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewStateInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewStateRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void ViewStateValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = !ValidateRow();
    }

    private void StateControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }
  }
}