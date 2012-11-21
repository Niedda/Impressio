using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class PositionControl : ControlBase, IGridControl
  {
    public PositionControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public IPosition FocusedRow
    {
      get { return viewPosition.GetFocusedRow() as IPosition; }
    }

    public override List<object> EditorsToCheck
    {
      get
      {
        return _editors ?? (_editors = new List<object>
                             {
                               orderNameEdit,
                               stateLookUp,
                             });
      }
    }

    public override void ReloadControl()
    {
      if (Order == null || Order.Identity <= 0)
      {
        throw new InvalidOperationException("Order cannot be null");
      }

      _position.ClearObjects();
      _position.ClearPredefinedObjects();
      predefinedCombo.Items.Clear();
      _state.ClearObjectList();

      Order.LoadSingleObject();
      orderBindingSource.DataSource = Order;
      _position.FkOrder = Order.Identity;
      lookUpTypes.DataSource = Position.AvailableTypes();
      lookUpTypes.DropDownRows = Position.AvailablePositions().Count > 10 ? 10 : Position.AvailablePositions().Count;
      positionBindingSource.DataSource = _position.Positions;
      predefinedCombo.Items.AddRange(_position.PredefinedPosition.Select(a => a.Name).Distinct().ToList());
      predefinedCombo.DropDownRows = _position.PredefinedPosition.Count > 10 ? 10 : _position.PredefinedPosition.Count;
      stateBindingSource.DataSource = _state.LoadObjectList();
      clientBindingSource.DataSource = Order.AvaibleClients;
      addressBindingSource.DataSource = Order.AvaibleAddress;
      viewPosition.RefreshData();
    }

    public override bool ValidateControl()
    {
      CheckEditors();

      if (ValidateRow() && !ErrorProvider.HasErrors)
      {
        return true;
      }
      return false;
    }

    public void DeleteRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.DeletePosition();
        viewPosition.DeleteSelectedRows();
        viewPosition.RefreshData();
      }
    }

    public bool ValidateRow()
    {
      if (!viewPosition.FocusedRowModified)
      {
        return true;
      }
      if (string.IsNullOrEmpty(FocusedRow.Name))
      {
        viewPosition.SetColumnError(colName, "Bitte einen gültigen Wert angeben");
      }
      else
      {
        viewPosition.SetColumnError(colName, "");
      }
      if (string.IsNullOrEmpty(FocusedRow.DisplayName))
      {
        viewPosition.SetColumnError(colDisplayName, "Bitte einen gültigen Wert angeben");
      }
      else
      {
        viewPosition.SetColumnError(colDisplayName, "");
      }
      if (viewPosition.HasColumnErrors)
      {
        return false;
      }
      UpdateRow();
      return true;
    }

    public void UpdateRow()
    {
      FocusedRow.FkOrder = Order.Identity;
      FocusedRow.Identity = FocusedRow.SavePosition();
    }

    public Order Order;

    private void PositionControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewPositionFocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
    {
      if (viewPosition.IsNewItemRow(viewPosition.FocusedRowHandle))
      {
        colName.ColumnEdit = predefinedCombo;
        colDisplayName.OptionsColumn.AllowEdit = true;
        colDisplayName.ColumnEdit = lookUpTypes;
      }
      else
      {
        colName.ColumnEdit = null;
        colDisplayName.OptionsColumn.AllowEdit = false;
        colDisplayName.ColumnEdit = null;
      }
    }

    private void PredefinedComboEditValueChanging(object sender, ChangingEventArgs e)
    {
      if (viewPosition.IsNewItemRow(viewPosition.FocusedRowHandle))
      {
        if (e.NewValue != null)
        {
          var position = (from pos in _position.PredefinedPosition where pos.Name == e.NewValue.ToString() select pos).FirstOrDefault();

          if (position != null)
          {
            position.CopyPosition(Order.Identity);
            viewPosition.DeleteSelectedRows();
            ReloadControl();
          }
        }
      }
    }

    private void PositionControlValidated(object sender, System.EventArgs e)
    {
      Order.SaveObject();
    }

    private void ViewPositionValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewPositionInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private readonly State _state = new State();

    private readonly Position _position = new Position();

    private List<object> _editors;
  }
}