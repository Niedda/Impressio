using System;
using DevExpress.XtraEditors.Controls;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Views;
using Type = Impressio.Models.Type;

namespace Impressio.Controls
{
  public partial class PredefinedPosition : ControlBase
  {
    public PredefinedPosition()
    {
      InitializeComponent();
    }

    public void ReloadControl()
    {
      _position.ClearPredefinedObjects();
      _position.LoadPredefined();
      positionBindingSource.DataSource = _position.PredefinedObjects;
      typeBindingSource.DataSource = Enum.GetNames(typeof(Type));
      viewPosition.RefreshData();
    }

    public void OpenPosition()
    {
      var position = viewPosition.GetFocusedRow() as Models.Position;

      if(position != null)
      {
        var view = new EmptyView();

        switch (position.Type)
        {
          case Type.Datenaufbereitung:
            view.mainPanel.Controls.Add(new Data
            {
              Data = new Models.Data
              {
                Identity = position.Identity,
              }
            });
            view.Show();
            break;
          case Type.Digitaldruck:
            view.mainPanel.Controls.Add(new Print
            {
              Print = new Models.Print
              {
                Identity = position.Identity,
              }
            });
            view.Show();
            break;
          case Type.Weiterverarbeitung:
            view.mainPanel.Controls.Add(new Finish
            {
              Finish = new Models.Finish
              {
                Identity = position.Identity,
              }
            });
            view.Show();
            break;
          case Type.Offsetdruck:
            view.mainPanel.Controls.Add(new Offset
            {
              Offset = new Models.Offset
              {
                Identity = position.Identity,
              },
            });
            view.Show();
            break;
        }
      }
    }

    public void DeletePosition()
    {
      var position = viewPosition.GetFocusedRow() as Models.Position;

      if(position != null)
      {
        position.DeleteObject();
        viewPosition.DeleteSelectedRows();
      }
    }
    
    private Type _type;

    private readonly Models.Position _position = new Models.Position();

    private void PredefinedPositionControlLoad(object sender, EventArgs e)
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

    private void TypeLookUpEditValueChanging(object sender, ChangingEventArgs e)
    {
      if (viewPosition.FocusedColumn == colType && !viewPosition.IsNewItemRow(viewPosition.FocusedRowHandle))
      {
        e.Cancel = true;
      }
    }

    private void ViewPositionRowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
    {
      viewPosition.SetFocusedRowCellValue(colIdentity, (e.Row as Models.Position).SaveObject());
    }

    private void ViewPositionInitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
    {
      viewPosition.SetFocusedRowCellValue(colIsPredefined, true);
    }

    private void ViewPositionRowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
    {
      if(e.Clicks == 2)
      {
        OpenPosition();
      }
    }
  }
}
