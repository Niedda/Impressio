using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;
using Type = Impressio.Models.Type;

namespace Impressio.Controls
{
  public partial class PositionControl : ControlBase, IGridControl
  {
    public PositionControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public Position FocusedRow
    {
      get { return viewPosition.GetFocusedRow() as Position; }
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
      if (Order == null) { throw new InvalidOperationException("Order cannot be null"); }

      _position.OrderId = Order.Identity;

      _state.ClearObjectList();
      _position.ClearPositions();
      _position.ClearPredefinedObjects();

      Order.LoadSingleObject();
      orderBindingSource.DataSource = Order;
      typeCombo.Items.Clear();
      typeCombo.Items.AddEnum(typeof(Type));
      var predefObjects = _position.PredefinedObjects.Select(b => b.Name).Distinct();
      predefinedCombo.Items.AddRange(predefObjects.ToArray());
      _position.LoadPositions();
      positionBindingSource.DataSource = _position.Objects;

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
        switch (FocusedRow.Type)
        {
          case Type.Datenaufbereitung:
            FocusedRow.ToType<Data>().DeleteObject();
            break;
          case Type.Digitaldruck:
            FocusedRow.ToType<Print>().DeleteObject();
            break;
          case Type.Offsetdruck:
            FocusedRow.ToType<Offset>().DeleteObject();
            break;
          case Type.Weiterverarbeitung:
            FocusedRow.ToType<Finish>().DeleteObject();
            break;
        }
        viewPosition.RefreshData();
      }
    }

    public bool ValidateRow()
    {
      if (!string.IsNullOrEmpty(FocusedRow.Name))
      {
        UpdateRow();
        return true;
      }
      return false;
    }

    public void UpdateRow()
    {
      FocusedRow.FkOrder = Order.Identity;

      switch (FocusedRow.Type)
      {
        case Type.Datenaufbereitung:
          FocusedRow.ToType<Data>().SaveObject();
          break;
        case Type.Digitaldruck:
          FocusedRow.ToType<Print>().SaveObject();
          break;
        case Type.Offsetdruck:
          FocusedRow.ToType<Offset>().SaveObject();
          break;
        case Type.Weiterverarbeitung:
          FocusedRow.ToType<Finish>().SaveObject();
          break;
      }
    }

    public Order Order;

    private void PositionControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewPositionInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewPosition.SetRowCellValue(e.RowHandle, colFkOrder, Order.Identity);
    }

    private void ViewPositionFocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
    {
      if (viewPosition.IsNewItemRow(e.FocusedRowHandle))
      {
        foreach (var predefinedPosition in _position.PredefinedObjects)
        {
          predefinedCombo.Items.Add(predefinedPosition.Name);
        }
      }
      else
      {
        predefinedCombo.Items.Clear();
      }
    }

    private void PredefinedComboEditValueChanging(object sender, ChangingEventArgs e)
    {
      if (viewPosition.IsNewItemRow(viewPosition.FocusedRowHandle))
      {
        if (e.NewValue != null)
        {
          var position = (from pos in _position.PredefinedObjects where pos.Name == e.NewValue.ToString() select pos).FirstOrDefault();

          if (position != null)
          {
            int id;

            switch (position.Type)
            {
              case Type.Datenaufbereitung:
                var data = new Data { Identity = position.Identity, };
                data.LoadSingleObject();
                var dataPositions = data.DataPositions;
                data.Identity = 0;
                data.FkOrder = Order.Identity;
                data.IsPredefined = false;
                id = data.SaveObject();

                foreach (var dataPosition in dataPositions)
                {
                  dataPosition.FkDataDataPosition = id;
                  dataPosition.Identity = 0;
                  dataPosition.SaveObject();
                }
                break;
              case Type.Weiterverarbeitung:
                var finish = new Finish { Identity = position.Identity, };
                finish.LoadSingleObject();
                var finishPositions = finish.FinishPositions;
                finish.Identity = 0;
                finish.FkOrder = Order.Identity;
                finish.IsPredefined = false;
                id = finish.SaveObject();

                foreach (var finishPosition in finishPositions)
                {
                  finishPosition.FkFinishFinishPosition = id;
                  finishPosition.Identity = 0;
                  finishPosition.SaveObject();
                }
                break;
              case Type.Digitaldruck:
                var print = new Print { Identity = position.Identity, };
                print.LoadSingleObject();
                print.Identity = 0;
                print.FkOrder = Order.Identity;
                print.IsPredefined = false;
                print.SaveObject();
                break;
              case Type.Offsetdruck:
                var offset = new Offset { Identity = position.Identity, };
                offset.LoadSingleObject();
                offset.Identity = 0;
                offset.FkOrder = Order.Identity;
                offset.IsPredefined = false;
                offset.SaveObject();
                break;
            }
            viewPosition.DeleteSelectedRows();
            ReloadControl();
          }
        }
      }
    }

    private void TypeComboEditValueChanging(object sender, ChangingEventArgs e)
    {
      if (!viewPosition.IsNewItemRow(viewPosition.FocusedRowHandle))
      {
        e.Cancel = true;
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

    private readonly Position _position = new Position();

    private readonly State _state = new State();
    
    private List<object> _editors;
  }
}