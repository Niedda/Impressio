using System;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Views;
using Type = Impressio.Models.Type;

namespace Impressio.Controls
{
  public partial class PredefinedPositionControl : ControlBase, IControl, IGridControl<Position>
  {
    private readonly Position _position = new Position();

    public PredefinedPositionControl()
    {
      InitializeComponent();
    }

    #region IControl Members

    public void ReloadControl()
    {
      _position.ClearPredefinedObjects();
      _position.LoadPredefined();
      positionBindingSource.DataSource = _position.PredefinedObjects;
      typeBindingSource.DataSource = Enum.GetNames(typeof (Type));
      viewPosition.RefreshData();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }

    #endregion

    #region IGridControl<Position> Members

    public Position FocusedRow
    {
      get { return viewPosition.GetFocusedRow() as Position; }
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

    #endregion

    public void OpenPosition()
    {
      if (FocusedRow != null)
      {
        var view = new EmptyView();

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
        }
      }
    }

    private void PredefinedPositionControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewPositionValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = !ValidateRow();
    }

    private void ViewPositionInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
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

    private void ViewPositionRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void ViewPositionInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewPosition.SetFocusedRowCellValue(colIsPredefined, true);
    }

    private void ViewPositionRowClick(object sender, RowClickEventArgs e)
    {
      if (e.Clicks == 2)
      {
        OpenPosition();
      }
    }
  }
}