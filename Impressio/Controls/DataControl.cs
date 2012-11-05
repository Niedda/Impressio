using System;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraGrid.Views.Base;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class DataControl : ControlBase, IControl, IGridControl<DataPosition>
  {
    private readonly DataPosition _dataPosition = new DataPosition();
    public Data Data = new Data();

    public DataControl()
    {
      InitializeComponent();
    }

    #region IControl Members

    public void ReloadControl()
    {
      if (Data != null)
      {
        _dataPosition.ClearObjectList();
        Data.LoadSingleObject();
        nameEdit.Text = Data.Name;
        remarkEdit.Text = Data.Remark;
        dataPositionBindingSource.DataSource = _dataPosition.LoadObjectList(DataPosition.Columns.FkDataDataPosition,
                                                                            Data.Identity);
        viewData.RefreshData();
      }
    }

    public bool ValidateControl()
    {
      CheckEditor(nameEdit);

      if (ValidateRow() && !ErrorProvider.HasErrors)
      {
        Data.Name = nameEdit.Text;
        Data.Remark = remarkEdit.Text;
        Data.PositionTotal = _dataPosition.Objects.Sum(data => data.PositionTotal);
        Data.SaveObject();
        return true;
      }
      return false;
    }

    #endregion

    #region IGridControl<DataPosition> Members

    public DataPosition FocusedRow
    {
      get { return viewData.GetFocusedRow() as DataPosition; }
    }

    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewData.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewData.ClearColumnErrors();
      CheckColumn(colDescription);
      return !viewData.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.FkDataDataPosition = Data.Identity;
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    #endregion

    private void DataControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewDataValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewDataCellValueChanged(object sender, CellValueChangedEventArgs e)
    {
      if (e.Column.Name == colPricePerQuantity.Name || e.Column.Name == colQuantity.Name)
      {
        viewData.SetRowCellValue(e.RowHandle, colPriceTotal,
                                 (int) viewData.GetFocusedRowCellValue(colPricePerQuantity)*
                                 (int) viewData.GetFocusedRowCellValue(colQuantity));
      }
    }

    private void DataControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }

    private void ViewDataRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void RemarkEditEditValueChanged(object sender, EventArgs e)
    {
      Data.Remark = remarkEdit.Text;
      Data.SaveObject();
    }
  }
}