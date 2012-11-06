using System;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class PaperControl : ControlBase, IControl, IGridControl<Paper>
  {
    public PaperControl()
    {
      InitializeComponent();
    }

    public void ReloadControl()
    {
      _paper.ClearObjectList();
      paperBindingSource.DataSource = _paper.LoadObjectList();
      viewPaper.RefreshData();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }

    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewPaper.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewPaper.ClearColumnErrors();
      CheckColumn(colName);
      CheckColumn(colPrice1);
      CheckColumn(colSizeB);
      CheckColumn(colSizeL);
      return !viewPaper.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    public Paper FocusedRow
    {
      get { return viewPaper.GetFocusedRow() as Paper; }
    }

    private readonly Paper _paper = new Paper();

    private void PaperControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewPaperInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewPaperValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewPaperRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void PaperControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }
  }
}