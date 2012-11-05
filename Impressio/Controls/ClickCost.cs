using System;
using DevExpress.XtraEditors.Controls;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class ClickCost : ControlBase
  {
    public ClickCost()
    {
      InitializeComponent();
    }

    public void ReloadControl()
    {
      _clickCost.ClearObjectList();
      clickCostBindingSource.DataSource = _clickCost.LoadObjectList();
      viewClickCost.RefreshData();
    }

    public void DeleteRow()
    {
      var clickCost = viewClickCost.GetFocusedRow() as Models.ClickCost;

      if(clickCost != null)
      {
        clickCost.DeleteObject();
        viewClickCost.DeleteSelectedRows();
      }
    }


    private readonly Models.ClickCost _clickCost = new Models.ClickCost();

    private void ClickCostControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewClickCostInvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewClickCostValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      viewClickCost.ClearColumnErrors();
      CheckColumn(colName);
      CheckColumn(colCost);
      e.Valid = !viewClickCost.HasColumnErrors;
    }

    private void ViewClickCostRowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
    {
      viewClickCost.SetFocusedRowCellValue(colIdentity, (e.Row as Models.ClickCost).SaveObject());
    }
  }
}
