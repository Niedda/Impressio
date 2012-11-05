using System;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraEditors.Controls;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Models.Tools;
using Impressio.Views;
using Type = Impressio.Models.Type;

namespace Impressio.Controls
{
  public partial class Position : ControlBase
  {
    public Position()
    {
      InitializeComponent();
    }

    public Order Order;

    public void OpenPosition()
    {
      if (FocusedPosition != null)
      {
        var view = new EmptyView {Text = string.Format("{0}: {1}", FocusedPosition.Type, Order.OrderName)};


        switch (FocusedPosition.Type)
        {
          case Type.Datenaufbereitung:
            view.mainPanel.Controls.Add(new Data
                              {
                                Data = new Models.Data
                                         {
                                           Identity = FocusedPosition.Identity,
                                         }
                              });
            view.Show();
            break;
          case Type.Digitaldruck:
            view.mainPanel.Controls.Add(new Print
                              {
                                Print = new Models.Print
                                         {
                                           Identity = FocusedPosition.Identity,
                                         }
                              });
            view.Show();
            break;
          case Type.Offsetdruck:
            view.mainPanel.Controls.Add(new Offset
                                                      {
                                                        Offset = new Models.Offset
                                                                   {
                                                                     Identity = FocusedPosition.Identity,
                                                                   },
                                                      });
            view.Show();
            break;
          case Type.Weiterverarbeitung:
            view.mainPanel.Controls.Add(new Finish
                              {
                                Finish = new Models.Finish
                                         {
                                           Identity = FocusedPosition.Identity,
                                         }
                              });
            view.Show();
            break;
        }
      }
    }

    public void DeletePosition()
    {
      if(FocusedPosition != null)
      {
        FocusedPosition.DeleteObject();
        viewPosition.DeleteSelectedRows();
        viewPosition.RefreshData();
      }
    }

    public void ReloadControl()
    {
      if (Order != null)
      {
        _position.ClearObjectList();
        _position.Type = Type.Datenaufbereitung;
        _position.LoadObjectList(_position.FkOrderColumn, Order.Identity);
        _position.Type = Type.Digitaldruck;
        _position.LoadObjectList(_position.FkOrderColumn, Order.Identity);
        _position.Type = Type.Offsetdruck;
        _position.LoadObjectList(_position.FkOrderColumn, Order.Identity);
        _position.Type = Type.Weiterverarbeitung;
        _position.LoadObjectList(_position.FkOrderColumn, Order.Identity);
        
        typeCombo.Items.AddRange(Enum.GetNames(typeof(Type)));
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
      }
    }

    private Models.Position FocusedPosition
    {
      get { return viewPosition.GetFocusedRow() as Models.Position; }
    }

    private readonly Models.Position _position = new Models.Position();

    private readonly Models.State _state = new Models.State();
    
    private void PositionControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewPositionValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      viewPosition.ClearColumnErrors();
      CheckColumn(colName);
      CheckColumn(colType);
      e.Valid = !viewPosition.HasColumnErrors;
    }

    private void ViewPositionInvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewPositionInitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
    {
      viewPosition.SetRowCellValue(e.RowHandle, colFkOrder, Order.Identity);
    }

    private void PositionControlValidating(object sender, CancelEventArgs e)
    {
      CheckEditor(orderNameEdit);
      CheckEditor(stateLookUp);
      e.Cancel = ErrorProvider.HasErrors;

      if (!e.Cancel)
      {
        Order.OrderName = orderNameEdit.Text;
        Order.FkOrderAddress = addressLookUp.EditValue.GetInt();
        Order.FkOrderClient = clientLookUp.EditValue.GetInt();
        Order.FkOrderState = stateLookUp.EditValue.GetInt();
        Order.SaveObject();
      }
    }

    private void ViewPositionRowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
    {
      viewPosition.SetFocusedRowCellValue(colIsPredefined, false);
      viewPosition.SetFocusedRowCellValue(colIdentity, (e.Row as Models.Position).SaveObject());
    }

    private void ViewPositionFocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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
          var position =
            (from pos in _position.PredefinedObjects where pos.Name == e.NewValue.ToString() select pos).
              FirstOrDefault();

          if (position != null)
          {
            var id = 0;

            switch (position.Type)
            {
              case Type.Datenaufbereitung:
                var data = new Models.Data { Identity = position.Identity, };
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
                var finish = new Models.Finish { Identity = position.Identity, };
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
                var print = new Models.Print { Identity = position.Identity, };
                print.LoadSingleObject();
                print.Identity = 0;
                print.FkOrder = Order.Identity;
                print.IsPredefined = false;
                id = print.SaveObject();
                break;
              case Type.Offsetdruck:
                var offset = new Models.Offset { Identity = position.Identity, };
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
      e.Cancel = !viewPosition.IsNewItemRow(viewPosition.FocusedRowHandle);
    }
  }
}
