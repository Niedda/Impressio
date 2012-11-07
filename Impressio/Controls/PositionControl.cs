using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Models.Tools;
using Impressio.Views;
using Subvento.DatabaseObject;
using Type = Impressio.Models.Type;

namespace Impressio.Controls
{
  public partial class PositionControl : ControlBase, IControl, IGridControl<Position>
  {
    public PositionControl()
    {
      InitializeComponent();
    }

    public void ReloadControl()
    {
      if (Order != null)
      {
        _position.ClearObjectList();
        _position.Identity = Order.Identity;
        _position.LoadPositions();

        typeCombo.Items.Clear();
        typeCombo.Items.AddEnum(typeof(Type));
        positionBindingSource.DataSource = _position.Objects;
        stateBindingSource.DataSource = _state.LoadObjectList();
        clientBindingSource.DataSource = Order.AvaibleClients;
        addressBindingSource.DataSource = Order.AvaibleAddress;

        orderNameEdit.Text = Order.OrderName;
        clientLookUp.EditValue = Order.FkOrderClient;
        addressLookUp.EditValue = Order.FkOrderAddress;
        stateLookUp.EditValue = Order.FkOrderState;
        userCreated.Text = Order.UserCreated;
        userEdited.Text = Order.UserModified;
        dateEdited.Text = Order.DateModified;
        dateCreated.Text = Order.DateCreated;

        viewPosition.RefreshData();
      }
    }

    public bool ValidateControl()
    {
      CheckEditor(orderNameEdit);
      CheckEditor(stateLookUp);

      if (!ErrorProvider.HasErrors && ValidateRow())
      {
        Order.OrderName = orderNameEdit.Text;
        Order.FkOrderAddress = addressLookUp.EditValue.GetInt();
        Order.FkOrderClient = clientLookUp.EditValue.GetInt();
        Order.FkOrderState = stateLookUp.EditValue.GetInt();
        Order.SaveObject();
      }
      return !ErrorProvider.HasErrors && ValidateRow();
    }

    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewPosition.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewPosition.ClearColumnErrors();
      CheckColumn(colName);
      CheckColumn(colType);
      return !viewPosition.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    public void OpenPosition()
    {
      if (FocusedRow != null)
      {
        var view = new EmptyView { Text = string.Format("{0}: {1}", FocusedRow.Type, Order.OrderName) };


        switch (FocusedRow.Type)
        {
          case Type.Datenaufbereitung:
            view.mainPanel.Controls.Add(new DataControl
                                          {
                                            Data = new Data
                                                     {
                                                       Identity = FocusedRow.Identity,
                                                     }
                                          });
            view.Show();
            break;
          case Type.Digitaldruck:
            view.mainPanel.Controls.Add(new PrintControl
                                          {
                                            Print = new Print
                                                      {
                                                        Identity = FocusedRow.Identity,
                                                      }
                                          });
            view.Show();
            break;
          case Type.Offsetdruck:
            view.mainPanel.Controls.Add(new OffsetControl
                                          {
                                            Offset = new Offset
                                                       {
                                                         Identity = FocusedRow.Identity,
                                                       },
                                          });
            view.Show();
            break;
          case Type.Weiterverarbeitung:
            view.mainPanel.Controls.Add(new FinishControl
                                          {
                                            Finish = new Finish
                                                       {
                                                         Identity = FocusedRow.Identity,
                                                       }
                                          });
            view.Show();
            break;
        }
      }
    }

    public Position FocusedRow
    {
      get { return viewPosition.GetFocusedRow() as Position; }
    }

    public Order Order = new Order();

    private readonly Position _position = new Position();

    private readonly State _state = new State();

    private void PositionControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewPositionValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewPositionInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewPositionInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewPosition.SetRowCellValue(e.RowHandle, colFkOrder, Order.Identity);
    }

    private void PositionControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }

    private void ViewPositionRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void ViewPositionFocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
    {
      if (viewPosition.IsNewItemRow(e.FocusedRowHandle))
      {
        foreach (Position predefinedPosition in _position.PredefinedObjects)
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
          Position position =
            (from pos in _position.PredefinedObjects where pos.Name == e.NewValue.ToString() select pos).
              FirstOrDefault();

          if (position != null)
          {
            int id = 0;

            switch (position.Type)
            {
              case Type.Datenaufbereitung:
                var data = new Data { Identity = position.Identity, };
                data.LoadSingleObject();
                List<DataPosition> dataPositions = data.DataPositions;
                data.Identity = 0;
                data.FkOrder = Order.Identity;
                data.IsPredefined = false;
                id = data.SaveObject();

                foreach (DataPosition dataPosition in dataPositions)
                {
                  dataPosition.FkDataDataPosition = id;
                  dataPosition.Identity = 0;
                  dataPosition.SaveObject();
                }
                break;
              case Type.Weiterverarbeitung:
                var finish = new Finish { Identity = position.Identity, };
                finish.LoadSingleObject();
                List<FinishPosition> finishPositions = finish.FinishPositions;
                finish.Identity = 0;
                finish.FkOrder = Order.Identity;
                finish.IsPredefined = false;
                id = finish.SaveObject();

                foreach (FinishPosition finishPosition in finishPositions)
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
                id = print.SaveObject();
                break;
              case Type.Offsetdruck:
                var offset = new Offset { Identity = position.Identity, };
                offset.LoadSingleObject();
                offset.Identity = 0;
                offset.FkOrder = Order.Identity;
                offset.IsPredefined = false;
                id = offset.SaveObject();
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
      if(!viewPosition.IsNewItemRow(viewPosition.FocusedRowHandle))
      {
        e.Cancel = true;
      }
    }
  }
}