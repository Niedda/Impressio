using System;
using System.Collections.Generic;
using System.Data.OleDb;
using DevExpress.XtraEditors;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Views
{
  public partial class ExcelImportView : XtraForm
  {
    public ExcelImportView()
    {
      InitializeComponent();
    }

    public List<string> ExcelSheets;

    public OleDbConnection Connection;

    private void ClearColumns()
    {
      nameRow.Properties.Value = null;
      price1.Properties.Value = null;
      price2.Properties.Value = null;
      price3.Properties.Value = null;
      price4.Properties.Value = null;
      quantity1.Properties.Value = null;
      quantity2.Properties.Value = null;
      quantity3.Properties.Value = null;
      directionRow.Properties.Value = null;
      numberRow.Properties.Value = null;
      widthRow.Properties.Value = null;
      lenghtRow.Properties.Value = null;
      vendorRow.Properties.Value = null;
      weightRow.Properties.Value = null;
    }

    private void LoadExcelColumns()
    {
      var command = new OleDbCommand(string.Format("SELECT * FROM [{0}]", excelSheet.Text), Connection);
      var reader = command.ExecuteReader();
      _columns.Clear();

      if (reader != null && reader.HasRows)
      {
        for (var i = 0; i <= reader.FieldCount - 1; i++)
        {
          _columns.Add(reader.GetName(i));
        }
      }
      ClearColumns();
      comboExcelColumn.Items.Clear();
      comboExcelColumn.Items.AddRange(_columns);
    }

    private void GeneratePreview()
    {
      if (ValidateColumnInput())
      {
        paperBindingSource.Clear();
        var command = new OleDbCommand(string.Format("SELECT * FROM [{0}]", excelSheet.Text), Connection);
        var reader = command.ExecuteReader();
        var counter = 0;

        while (reader != null && reader.Read())
        {
          if (counter > 210) { break; }
          var paper = new Paper
                        {
                          ItemNumber = numberRow.Properties.Value == null ? 0 : Convert.ToInt32(reader[numberRow.Properties.Value.ToString()]),
                          Name = reader[nameRow.Properties.Value.ToString()].ToString(),
                          Direction = directionRow.Properties.Value == null ? 0 : Convert.ToInt32(reader[directionRow.Properties.Value.ToString()]),
                          Amount1 = quantity1.Properties.Value == null ? 0 : Convert.ToInt32(reader[quantity1.Properties.Value.ToString()]),
                          Amount2 = quantity2.Properties.Value == null ? 0 : Convert.ToInt32(reader[quantity2.Properties.Value.ToString()]),
                          Amount3 = quantity3.Properties.Value == null ? 0 : Convert.ToInt32(reader[quantity3.Properties.Value.ToString()]),
                          Price1 = Convert.ToInt32(reader[price1.Properties.Value.ToString()]),
                          Price2 = price2.Properties.Value == null ? 0 : Convert.ToInt32(reader[price2.Properties.Value.ToString()]),
                          Price3 = price3.Properties.Value == null ? 0 : Convert.ToInt32(reader[price3.Properties.Value.ToString()]),
                          Price4 = price4.Properties.Value == null ? 0 : Convert.ToInt32(reader[price4.Properties.Value.ToString()]),
                          SizeB = widthRow.Properties.Value == null ? 0 : Convert.ToInt32(reader[widthRow.Properties.Value.ToString()]),
                          SizeL = lenghtRow.Properties.Value == null ? 0 : Convert.ToInt32(reader[lenghtRow.Properties.Value.ToString()]),
                          Vendor = vendorRow.Properties.Value == null ? null : reader[vendorRow.Properties.Value.ToString()].ToString(),
                          Weight = weightRow.Properties.Value == null ? 0 : Convert.ToInt32(reader[weightRow.Properties.Value.ToString()])
                        };
          paperBindingSource.Add(paper);
          counter++;
        }
      }
    }

    private void ImportExcel()
    {
      if (ValidateColumnInput())
      {
        var command = new OleDbCommand(string.Format("SELECT * FROM [{0}]", excelSheet.Text), Connection);
        var reader = command.ExecuteReader();
        var errorMsg = string.Empty;

        while (reader != null && reader.Read())
        {
          try
          {
            var paper = new Paper
            {
              ItemNumber = numberRow.Properties.Value == null ? 0 : Convert.ToInt32(reader[numberRow.Properties.Value.ToString()]),
              Name = reader[nameRow.Properties.Value.ToString()].ToString(),
              Direction = directionRow.Properties.Value == null ? 0 : Convert.ToInt32(reader[directionRow.Properties.Value.ToString()]),
              Amount1 = quantity1.Properties.Value == null ? 0 : Convert.ToInt32(reader[quantity1.Properties.Value.ToString()]),
              Amount2 = quantity2.Properties.Value == null ? 0 : Convert.ToInt32(reader[quantity2.Properties.Value.ToString()]),
              Amount3 = quantity3.Properties.Value == null ? 0 : Convert.ToInt32(reader[quantity3.Properties.Value.ToString()]),
              Price1 = Convert.ToInt32(reader[price1.Properties.Value.ToString()]),
              Price2 = price2.Properties.Value == null ? 0 : Convert.ToInt32(reader[price2.Properties.Value.ToString()]),
              Price3 = price3.Properties.Value == null ? 0 : Convert.ToInt32(reader[price3.Properties.Value.ToString()]),
              Price4 = price4.Properties.Value == null ? 0 : Convert.ToInt32(reader[price4.Properties.Value.ToString()]),
              SizeB = widthRow.Properties.Value == null ? 0 : Convert.ToInt32(reader[widthRow.Properties.Value.ToString()]),
              SizeL = lenghtRow.Properties.Value == null ? 0 : Convert.ToInt32(reader[lenghtRow.Properties.Value.ToString()]),
              Vendor = vendorRow.Properties.Value == null ? null : reader[vendorRow.Properties.Value.ToString()].ToString(),
              Weight = weightRow.Properties.Value == null ? 0 : Convert.ToInt32(reader[weightRow.Properties.Value.ToString()])
            };
            paper.SaveObject();
          }
          catch (Exception exception)
          {
            errorMsg += exception + Environment.NewLine;
          }
        }
        if (!string.IsNullOrEmpty(errorMsg))
        {
          XtraMessageBox.Show(errorMsg, "Aufgetretene Fehler beim Import");
        }
        Close();
      }
    }

    private bool ValidateColumnInput()
    {
      vGridColumns.SetRowError(price1.Properties, string.IsNullOrEmpty(price1.Properties.Value as string) ? "Bitte einen gültigen Wert eingeben" : "");
      vGridColumns.SetRowError(nameRow.Properties, string.IsNullOrEmpty(nameRow.Properties.Value as string) ? "Bitte einen gültigen Wert eingeben" : "");
      return !vGridColumns.HasRowErrors;
    }

    private void ImportClick(object sender, EventArgs e)
    {
      ImportExcel();
    }

    private void ExcelImportViewLoad(object sender, EventArgs e)
    {
      excelSheet.Properties.Items.AddRange(ExcelSheets);
      excelSheet.SelectedIndex = 0;
      LoadExcelColumns();
    }

    private void ExcelSheetSelectedIndexChanged(object sender, EventArgs e)
    {
      LoadExcelColumns();
    }

    private void PreviewButtonClick(object sender, EventArgs e)
    {
      GeneratePreview();
    }

    private void ViewExcelFocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    {
      viewExcel.OptionsBehavior.ReadOnly = !viewExcel.IsNewItemRow(e.FocusedRowHandle);
    }

    private readonly List<string> _columns = new List<string>();
  }
}