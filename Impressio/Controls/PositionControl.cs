using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Subvento.DatabaseObject;
using Type = Impressio.Models.Type;

namespace Impressio.Controls
{
  public partial class PositionControl : PositionControlBase
  {
    public PositionControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override GridView GridView
    {
      get { return viewPosition; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                                             {
                                               colName,
                                               colType,
                                             });
      }
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
      if (Order != null)
      {
        _position.ClearObjectList();
        _position.ClearPredefinedObjects();
        _position.Identity = Order.Identity;
        _position.LoadPositions();
        _position.LoadPredefined();
        _state.ClearObjectList();

        orderBindingSource.DataSource = Order;
        typeCombo.Items.Clear();
        typeCombo.Items.AddEnum(typeof(Type));
        var predefObjects = _position.PredefinedObjects.Select(b => b.Name).Distinct();
        predefinedCombo.Items.AddRange(predefObjects.ToArray());
        positionBindingSource.DataSource = _position.Objects;
        stateBindingSource.DataSource = _state.LoadObjectList();
        clientBindingSource.DataSource = Order.AvaibleClients;
        addressBindingSource.DataSource = Order.AvaibleAddress;

        viewPosition.RefreshData();
      }
    }

    public Order Order;

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

    private readonly Position _position = new Position();

    private readonly State _state = new State();

    private List<GridColumn> _columns;

    private List<object> _editors;
  }
}