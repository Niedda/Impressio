using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Columns;
using Impressio.Models.Tools;

namespace Impressio.Controls
{
  public class ControlBase : XtraUserControl
  {
    public readonly DXErrorProvider ErrorProvider = new DXErrorProvider();

    protected ControlBase()
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
          if ((int) value <= 0)
          {
            column.View.SetColumnError(column, "Bitte einen gültigen Wert angeben", ErrorType.Warning);
          }
          break;
        case "Double":
          if ((double) value <= 0)
          {
            column.View.SetColumnError(column, "Bitte einen gültigen Wert angeben", ErrorType.Warning);
          }
          break;
        case "DateTime":
          break;
        case "Type":
          break;
        default:
          MessageBox.Show(type.Name + " unhandled type", "Possible Error");
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