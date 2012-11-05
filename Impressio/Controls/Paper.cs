using System;
using DevExpress.XtraEditors.Controls;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class Paper : ControlBase
  {
    public Paper()
    {
      InitializeComponent();
    }

    public void ReloadControl()
    {
      _paper.ClearObjectList();
      paperBindingSource.DataSource = _paper.LoadObjectList();
      viewPaper.RefreshData();
    }
    
    private readonly Models.Paper _paper = new Models.Paper();

    private void PaperControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewPaperInvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewPaperValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      viewPaper.ClearColumnErrors();
      CheckColumn(colName);
      CheckColumn(colPrice1);
      CheckColumn(colSizeB);
      CheckColumn(colSizeL);
      e.Valid = !viewPaper.HasColumnErrors;
    }

    private void ViewPaperRowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
    {
      viewPaper.SetFocusedRowCellValue(colIdentity, (e.Row as Models.Paper).SaveObject());
    }
  }
}
