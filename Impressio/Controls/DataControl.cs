using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Base;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class DataControl : ControlBase, IControl, IGridControl<DataPosition>, IRibbon
  {
    public DataControl()
    {
      InitializeComponent();
    }

    #region Ribbon

    public string RibbonGroupName { get { return "Datenaufbereitung"; } }

    public List<BarButtonItem> Buttons
    {
      get
      {
        return _buttons ?? (_buttons = LoadButtons());
      }
    }

    public RibbonPageGroup GetRibbon()
    {
      var pageGroup = new RibbonPageGroup
      {
        Text = "Datenaufbereitung",
        Name = "dataPageGroup"
      };
      pageGroup.ItemLinks.AddRange(Buttons.ToArray());

      return pageGroup;
    }

    private List<BarButtonItem> _buttons;

    private List<BarButtonItem> LoadButtons()
    {
      var deleteButton = new BarButtonItem
                           {
                             Caption = "Löschen",
                             Id = 1,
                             LargeGlyph = Properties.Resources.delete,
                             LargeWidth = 80,
                             Name = "dataDeletePosition",
                           };
      deleteButton.ItemClick += DeleteRow;

      var refreshButton = new BarButtonItem
                            {
                              Caption = "Aktualisieren",
                              Id = 2,
                              LargeGlyph = Properties.Resources.refresh,
                              LargeWidth = 80,
                              Name = "dataRefresh"
                            };
      refreshButton.ItemClick += ReloadControl;

      return new List<BarButtonItem> {deleteButton, refreshButton};
    }

    public void ReloadControl(object sender, ItemClickEventArgs e)
    {
      ReloadControl();
    }

    public void DeleteRow(object sender, ItemClickEventArgs e)
    {
      DeleteRow();
    }

    #endregion

    public void ReloadControl()
    {
      if (Data != null)
      {
        _dataPosition.ClearObjectList();
        Data.LoadSingleObject();
        nameEdit.Text = Data.Name;
        remarkEdit.Text = Data.Remark;
        dataPositionBindingSource.DataSource = _dataPosition.LoadObjectList(DataPosition.Columns.FkDataDataPosition,
                                                                            Data.Identity);
        viewData.RefreshData();
      }
    }

    public bool ValidateControl()
    {
      CheckEditor(nameEdit);

      if (ValidateRow() && !ErrorProvider.HasErrors)
      {
        Data.Name = nameEdit.Text;
        Data.Remark = remarkEdit.Text;
        Data.PositionTotal = _dataPosition.Objects.Sum(data => data.PositionTotal);
        Data.SaveObject();
        return true;
      }
      return false;
    }
    
    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewData.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewData.ClearColumnErrors();
      CheckColumn(colDescription);
      return !viewData.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.FkDataDataPosition = Data.Identity;
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    public DataPosition FocusedRow
    {
      get { return viewData.GetFocusedRow() as DataPosition; }
    }

    public Data Data = new Data();

    private readonly DataPosition _dataPosition = new DataPosition();

    private void DataControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewDataValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewDataCellValueChanged(object sender, CellValueChangedEventArgs e)
    {
      if (e.Column.Name == colPricePerQuantity.Name || e.Column.Name == colQuantity.Name)
      {
        viewData.SetRowCellValue(e.RowHandle, colPriceTotal,
                                 (int) viewData.GetFocusedRowCellValue(colPricePerQuantity)*
                                 (int) viewData.GetFocusedRowCellValue(colQuantity));
      }
    }

    private void DataControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }

    private void ViewDataRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void RemarkEditEditValueChanged(object sender, EventArgs e)
    {
      Data.Remark = remarkEdit.Text;
      Data.SaveObject();
    }
  }
}