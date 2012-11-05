using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Columns;
using Impressio.Models.Tools;

namespace Impressio.Models
{
  public class BaseControl : XtraUserControl
  {
    protected BaseControl()
    {
      SetDockStyle();
    }

    public void CheckColumn(GridColumn column)
    {
      var value = column.View.GetFocusedRowCellValue(column);
      var type = column.ColumnType;

      switch (type.Name)
      {
        case "String":
          if (string.IsNullOrWhiteSpace(value as string))
          {
            column.View.SetColumnError(column, "Bitte einen Wert angeben", ErrorType.Warning);
          }
          break;
        case "Int32":
          if ((int)value <= 0)
          {
            column.View.SetColumnError(column, "Bitte einen gültigen Wert angeben", ErrorType.Warning);
          }
          break;
        case "Double":
          if((double)value <= 0)
          {
            column.View.SetColumnError(column, "Bitte einen gültigen Wert angeben", ErrorType.Warning);
          }
          break;
        case "Type":
          break;
        default:
          MessageBox.Show(type.Name + " unhandled type", "Possible Error");
          break;
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

    private void SetDockStyle()
    {
      Dock = DockStyle.Fill;
    }

    public readonly DXErrorProvider ErrorProvider = new DXErrorProvider();
  }
}
