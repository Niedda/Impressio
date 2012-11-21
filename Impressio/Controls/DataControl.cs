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
  public partial class DataControl : DataControlBase
  {
    public DataControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override GridView GridView
    {
      get { return viewData; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                                         {
                                           colPricePerQuantity,
                                           colDescription,
                                           colQuantity,
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
                                                                         }, "Datenaufbereitung"));
      }
    }
    
    public override void ReloadControl()
    {
      if (Data != null)
      {
        _dataPosition.ClearObjectList();
        Data.LoadSingleObject();
        remarkEdit.Text = Data.Remark;
        dataPositionBindingSource.DataSource = _dataPosition.LoadObjectList(DataPosition.Columns.FkDataDataPosition, Data.Identity);
        viewData.RefreshData();
      }
    }

    public Data Data;

    private void RemarkEditEditValueChanged(object sender, EventArgs e)
    {
      Data.Remark = remarkEdit.Text;
      Data.SaveObject();
    }

    private void ViewDataInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewData.SetFocusedRowCellValue(colFkDataDataPosition, Data.Identity);
    }
   
    private readonly DataPosition _dataPosition = new DataPosition();

    private List<GridColumn> _columns;

    private RibbonPage _ribbonPage;
  }
}