using System;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class FinishControl : FinishControlBase
  {
    public FinishControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override GridView GridView
    {
      get { return viewFinish; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                                         {
                                           colDescription,
                                           colQuantity,
                                           colPricePerQuantity,
                                         });
      }
    }

    public override RibbonPage RibbonPage
    {
      get
      {
        return _ribbonPage ?? (_ribbonPage = RibbonTools.GetSimplePage(new List<BarButtonItem>
                                                                         {
                                                                           RibbonTools.GetRefreshButton(ReloadControl),
                                                                           RibbonTools.GetDeleteButton(DeleteRow),
                                                                         }, "Weiterverarbeitung"));
      }
    }

    public override void ReloadControl()
    {
      if (Finish != null)
      {
        Finish.LoadSingleObject();
        _finishPosition.ClearObjectList();
        finishPositionBindingSource.DataSource = _finishPosition.LoadObjectList(FinishPosition.Columns.FkFinishFinishPosition, Finish.Identity);

        remarkEdit.Text = Finish.Remark;
      }
    }

    public Finish Finish;

    private void RemarkEditEditValueChanged(object sender, EventArgs e)
    {
      Finish.Remark = remarkEdit.Text;
      Finish.SaveObject();
    }

    private void ViewFinishInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewFinish.SetFocusedRowCellValue(colFkFinishFinishPosition, Finish.Identity);
    }

    private readonly FinishPosition _finishPosition = new FinishPosition();

    private List<GridColumn> _columns;

    private RibbonPage _ribbonPage;
  }
}