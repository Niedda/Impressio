using System;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraEditors.Controls;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class Finish : ControlBase
  {
    public Finish()
    {
      InitializeComponent();
    }

    public Models.Finish Finish;
  
    public void ReloadControl()
    {
      _finishPosition.ClearObjectList();
      finishPositionBindingSource.DataSource = _finishPosition.LoadObjectList(FinishPosition.Columns.FkFinishFinishPosition, Finish.Identity);

      nameEdit.Text = Finish.Name;
      remarkEdit.Text = Finish.Remark;
    }
    
    private readonly FinishPosition _finishPosition = new FinishPosition();

    private void FinishControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }
    
    private void FinishControlValidating(object sender, CancelEventArgs e)
    {
      Finish.PositionTotal = _finishPosition.Objects.Sum(position => position.PriceTotal);
      Finish.SaveObject();
    }

    private void NameEditValidating(object sender, CancelEventArgs e)
    {
      CheckEditor(nameEdit);
    }
    
    private void ViewFinishCellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      if (e.Column.Name == colPricePerQuantity.Name || e.Column.Name == colQuantity.Name)
      {
        viewFinish.SetRowCellValue(e.RowHandle, colPriceTotal, (int)viewFinish.GetRowCellValue(e.RowHandle, colPricePerQuantity) * (int)viewFinish.GetRowCellValue(e.RowHandle, colQuantity));
      }
    }

    private void ViewFinishValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      viewFinish.ClearColumnErrors();
      CheckColumn(colDescription);
      e.Valid = !viewFinish.HasColumnErrors;
    }

    private void ViewFinishInvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewFinishInitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
    {
      viewFinish.SetFocusedRowCellValue(colFkFinishFinishPosition, Finish.Identity);
    }

    private void ViewFinishRowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
    {
      (e.Row as FinishPosition).SaveObject();
    }
  }
}
