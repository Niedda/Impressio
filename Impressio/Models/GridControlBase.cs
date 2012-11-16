using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  public class GridControlBase<T> : XtraUserControl, IControl, IGridControl where T : DatabaseObjectBase<T>, new()
  {
    protected void InitializeBase()
    {
      Dock = DockStyle.Fill;
      
      if (GridView != null)
      {
        GridView.ValidateRow += ValidateRow;
        GridView.CellValueChanged += CheckColumn;
        GridView.InvalidRowException += InvalidRowException;
        GridView.KeyDown += GridKeyDown;
        Load += LoadControl;
      }
    }

    public T FocusedRow { get { return GridView.GetFocusedRow() as T; } }

    public virtual GridView GridView { get; set; }

    public virtual List<GridColumn> ColumnsToCheck { get; set; }

    public virtual List<object> EditorsToCheck { get; set; }

    public void CheckColumn(GridColumn column)
    {
      if (column == null || column.View == null)
      {
        return;
      }

      object value = column.View.GetFocusedRowCellValue(column);
      System.Type type = column.ColumnType;

      switch (type.Name)
      {
        case "String":
          if (string.IsNullOrWhiteSpace(value as string))
          {
            column.View.SetColumnError(column, "Bitte einen Wert angeben", ErrorType.Warning);
          }
          else
          {
            column.View.SetColumnError(column, "");
          }
          break;
        case "Int32":
          if (Convert.ToInt32(value) <= 0)
          {
            column.View.SetColumnError(column, "Bitte einen gültigen Wert angeben", ErrorType.Warning);
          }
          else
          {
            column.View.SetColumnError(column, "");
          }
          break;
        case "Double":
          if (Convert.ToDouble(value) <= 0)
          {
            column.View.SetColumnError(column, "Bitte einen gültigen Wert angeben", ErrorType.Warning);
          }
          else
          {
            column.View.SetColumnError(column, "");
          }
          break;
        case "DateTime":
          break;
        case "Type":
          break;
      }
    }

    public void CheckColumn(object sener, CellValueChangedEventArgs e)
    {
      if (ColumnsToCheck.Contains(e.Column))
      {
        CheckColumn(e.Column);
      }
    }

    public void InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    public void GridKeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        if (GridView.IsNewItemRow(GridView.FocusedRowHandle))
        {
          GridView.CancelUpdateCurrentRow();
          GridView.FocusedRowHandle = 0;
        }
      }
    }

    public void CheckEditors()
    {
      if(EditorsToCheck == null)
      {
        return;
      }
      foreach (var baseEdit in EditorsToCheck)
      {
        if (baseEdit is TextEdit)
        {
          CheckEditor(baseEdit as TextEdit);
        }
        if (baseEdit is SpinEdit)
        {
          CheckEditor(baseEdit as SpinEdit);
        }
        if (baseEdit is LookUpEdit)
        {
          CheckEditor(baseEdit as LookUpEdit);
        }
        if (baseEdit is SearchLookUpEdit)
        {
          CheckEditor(baseEdit as SearchLookUpEdit);
        }
      }
    }

    public void CheckEditor(TextEdit editor)
    {
      if (string.IsNullOrWhiteSpace(editor.Text))
      {
        ErrorProvider.SetError(editor, "Bitte einen Wert angeben", ErrorType.Warning);
      }
    }

    public void CheckEditor(SpinEdit editor)
    {
      if (editor.Value.GetInt() <= 0)
      {
        ErrorProvider.SetError(editor, "Bitte einen gültigen Wert angeben", ErrorType.Warning);
      }
    }

    public void CheckEditor(LookUpEdit editor)
    {
      if (editor.EditValue.GetInt() <= 0)
      {
        ErrorProvider.SetError(editor, "Bitte einen gültigen Wert angeben", ErrorType.Warning);
      }
    }

    public void CheckEditor(SearchLookUpEdit editor)
    {
      if (editor.EditValue.GetInt() <= 0)
      {
        ErrorProvider.SetError(editor, "Bitte einen gültigen Wert angeben", ErrorType.Warning);
      }
    }

    public bool ValidateRow()
    {
      foreach (var gridColumn in ColumnsToCheck)
      {
        CheckColumn(gridColumn);
      }
      return !GridView.HasColumnErrors;
    }

    public void ValidateRow(object sender, ValidateRowEventArgs e)
    {
      if (ValidateRow())
      {
        UpdateRow();
      }
      else
      {
        e.Valid = false;
      }
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    public void DeleteRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.DeleteObject();
        GridView.DeleteSelectedRows();
      }
    }

    public void DeleteRow(object sender, EventArgs e)
    {
      DeleteRow();
    }

    public bool ValidateControl()
    {
      CheckEditors();
      return ValidateRow() && !ErrorProvider.HasErrors;
    }

    public virtual void ReloadControl()
    {
      Update();
    }

    public void LoadControl(object sender, EventArgs e)
    {
      ReloadControl();
    }
    
    public virtual RibbonPage RibbonPage { get; set; }

    public readonly DXErrorProvider ErrorProvider = new DXErrorProvider();
  }

  //TODO Workaround to show files in the designer - find a proper solution...
  #region Designer Files

  public class ClientControlBase : GridControlBase<Client>
  { }

  public class AddressControlBase : GridControlBase<Address>
  { }

  public class CompanyControlBase : GridControlBase<Company>
  { }

  public class ClickCostControlBase : GridControlBase<ClickCost>
  { }

  public class OrderControlBase : GridControlBase<Order>
  { }

  public class DataControlBase : GridControlBase<DataPosition>
  { }

  public class DescriptionControlBase : GridControlBase<Description>
  { }

  public class FinishControlBase : GridControlBase<FinishPosition>
  { }
  
  public class GenderControlBase : GridControlBase<Gender>
  { }

  public class MachineControlBase : GridControlBase<Machine>
  { }

  public class PaperControlBase : GridControlBase<Paper>
  { }

  public class PositionControlBase : GridControlBase<Position>
  { }

  public class PredefinedPositionControl : GridControlBase<Position>
  { }

  public class StateControlBase : GridControlBase<State>
  { }

  public class DeliveryControlBase : GridControlBase<DeliveryPosition>
  { }

  public class DeliveryOverviewBase : GridControlBase<Delivery>
  { }
  
  #endregion
}
