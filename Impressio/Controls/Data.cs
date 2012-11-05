using System;
using System.ComponentModel;
using System.Linq;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class Data : ControlBase
  {
    public Data()
    {
      InitializeComponent();
    }

    public Models.Data Data = new Models.Data();
    
    private readonly DataPosition _dataPosition = new DataPosition();

    private void DataControlLoad(object sender, EventArgs e)
    {
      if (Data != null)
      {
        Data.LoadSingleObject();
        nameEdit.Text = Data.Name;
        remarkEdit.Text = Data.Remark;
        dataPositionBindingSource.DataSource = _dataPosition.LoadObjectList(Models.Data.Columns.FkDataOrder, Data.FkOrder);
      }
    }
    
    private void NameEditValidating(object sender, CancelEventArgs e)
    {
      CheckEditor(nameEdit);
    }

    private void ViewDataValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      viewData.ClearColumnErrors();
      CheckColumn(colDescription);
      e.Valid = !viewData.HasColumnErrors;
    }

    private void ViewDataCellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      if (e.Column.Name == colPricePerQuantity.Name || e.Column.Name == colQuantity.Name)
      {
        viewData.SetRowCellValue(e.RowHandle, colPriceTotal, (int)viewData.GetFocusedRowCellValue(colPricePerQuantity) * (int)viewData.GetFocusedRowCellValue(colQuantity));
      }
    }

    private void DataControlValidating(object sender, CancelEventArgs e)
    {
      Data.Name = nameEdit.Text;
      Data.Remark = remarkEdit.Text;
      Data.PositionTotal = _dataPosition.Objects.Sum(data => data.PositionTotal); ;
      Data.SaveObject();
    }

    private void ViewDataInitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
    {
      viewData.SetFocusedRowCellValue(colFkDataDataPosition, Data.Identity);
    }

    private void ViewDataRowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
    {
      (e.Row as DataPosition).SaveObject();
    }
  }
}
