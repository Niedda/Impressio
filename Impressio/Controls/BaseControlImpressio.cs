using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Columns;
using Impressio.Models.Tools;

namespace Impressio.Controls
{
  public class BaseControlImpressio : XtraUserControl
  {
    public readonly DXErrorProvider ErrorProvider = new DXErrorProvider();

    protected BaseControlImpressio()
    {
      SetDockStyle();
    }

    public virtual void CheckColumn(GridColumn column)
    {
      object value = column.View.GetFocusedRowCellValue(column);
      Type type = column.ColumnType;

      switch (type.Name)
      {
        case "String":
          if (string.IsNullOrWhiteSpace(value as string))
          {
            column.View.SetColumnError(column, "Bitte einen Wert angeben", ErrorType.Warning);
          }
          break;
        case "Int32":
          if (Convert.ToInt32(value) <= 0)
          {
            column.View.SetColumnError(column, "Bitte einen gültigen Wert angeben", ErrorType.Warning);
          }
          break;
        case "Double":
          if (Convert.ToDouble(value) <= 0)
          {
            column.View.SetColumnError(column, "Bitte einen gültigen Wert angeben", ErrorType.Warning);
          }
          break;
        case "DateTime":
          break;
        case "Type":
          break;
      }
    }

    public virtual void CheckEditor(TextEdit editor)
    {
      if (string.IsNullOrWhiteSpace(editor.Text))
      {
        ErrorProvider.SetError(editor, "Bitte einen Wert angeben", ErrorType.Warning);
      }
    }

    public virtual void CheckEditor(SpinEdit editor)
    {
      if (editor.Value.GetInt() <= 0)
      {
        ErrorProvider.SetError(editor, "Bitte einen gültigen Wert angeben", ErrorType.Warning);
      }
    }

    public virtual void CheckEditor(LookUpEdit editor)
    {
      if (editor.EditValue.GetInt() <= 0)
      {
        ErrorProvider.SetError(editor, "Bitte einen gültigen Wert angeben", ErrorType.Warning);
      }
    }

    public virtual void CheckEditor(SearchLookUpEdit editor)
    {
      if (editor.EditValue.GetInt() <= 0)
      {
        ErrorProvider.SetError(editor, "Bitte einen gültigen Wert angeben", ErrorType.Warning);
      }
    }

    private void SetDockStyle()
    {
      Dock = DockStyle.Fill;
    }
  }
}