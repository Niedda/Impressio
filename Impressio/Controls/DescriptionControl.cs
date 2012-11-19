﻿using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class DescriptionControl : DescriptionControlBase
  {
    public DescriptionControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                                         {
                                           colJobTitel,
                                         });
      }
    }

    public override GridView GridView
    {
      get { return viewDescription; }
    }

    public override bool ValidateControl()
    {
      if (FocusedRowDetail != null)
      {
        return ValidateDetailRow() && ValidateRow();
      }
      return FocusedRow == null || ValidateRow();
    }

    public override void ReloadControl()
    {
      _description.ClearObjectList();
      _description.ClearPredefinedObjects();
      _description.LoadPredefined();

      if (IsPredefinedMode)
      {
        descriptionBindingSource.DataSource = _description.PredefinedObjects;
      }
      else
      {
        descriptionBindingSource.DataSource = _description.LoadObjectList(Description.Columns.FkDescriptionOrder, Order.Identity);
        predefinedDescriptionCombo.Items.Clear();
        predefinedDescriptionCombo.Items.AddRange(_description.PredefinedObjects.Select(a => a.JobTitle).ToList());
      }
      viewDescription.RefreshData();
    }

    public void DeleteDetailRow()
    {
      FocusedRowDetail.DeleteObject();
      viewDetail.DeleteSelectedRows();
    }

    public override void UpdateRow()
    {
      if (IsPredefinedMode)
      {
        FocusedRow.IsPredefined = true;
      }
      FocusedRow.Identity = FocusedRow.SaveObject();
    }

    public bool ValidateDetailRow()
    {
      if (FocusedRowDetail != null)
      {
        viewDetail.ClearColumnErrors();
        CheckColumn(colDetailTitle);
        CheckColumn(colDetailContent);
        if (!viewDetail.HasColumnErrors)
        {
          UpdateDetailRow();
        }
        return !viewDetail.HasColumnErrors;
      }
      return true;
    }

    public void UpdateDetailRow()
    {
      if (FocusedRowDetail != null)
      {
        if (IsPredefinedMode)
        {
          FocusedRow.IsPredefined = true;
        }
        FocusedRowDetail.Identity = FocusedRowDetail.SaveObject();
      }
    }

    public Detail FocusedRowDetail
    {
      get { return viewDetail.GetFocusedRow() as Detail; }
    }

    public bool IsPredefinedMode;

    public Order Order;

    private void ViewDescriptionFocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
    {
      detailsBindingSource.Clear();

      if (FocusedRow != null)
      {
        detailsBindingSource.DataSource = FocusedRow.Details;
        viewDetail.RefreshData();
      }

      gridDetail.Enabled = !viewDescription.IsNewItemRow(e.FocusedRowHandle);
    }

    private void ViewDescriptionInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewDescription.SetFocusedRowCellValue(colArrange, viewDescription.DataRowCount);

      if (!IsPredefinedMode)
      {
        viewDescription.SetFocusedRowCellValue(colFkDescriptionOrder, Order.Identity);
      }
      else
      {
        viewDescription.SetFocusedRowCellValue(colPredefinedDescription, true);
      }
    }

    private void DescriptionMoveUpEditClick(object sender, EventArgs e)
    {
      var index = viewDescription.FocusedRowHandle;

      if (index > 0 && !viewDescription.IsNewItemRow(index))
      {
        var row1 = viewDescription.GetRow(index) as Description;
        var row2 = viewDescription.GetRow(index - 1) as Description;
        row1.Arrange = (int)viewDescription.GetRowCellValue(index - 1, colArrange);
        row2.Arrange = index;
        row1.SaveObject();
        row2.SaveObject();

        viewDescription.RefreshData();
        viewDescription.FocusedRowHandle = index - 1;
      }
    }

    private void DescriptionMoveDownEditClick(object sender, EventArgs e)
    {
      var index = viewDescription.FocusedRowHandle;

      if (index < viewDescription.DataRowCount - 1 && !viewDescription.IsNewItemRow(index))
      {
        var row1 = viewDescription.GetRow(index) as Description;
        var row2 = viewDescription.GetRow(index + 1) as Description;

        row1.Arrange = (int)viewDescription.GetRowCellValue(index + 1, colArrange);
        row2.Arrange = index;
        row1.SaveObject();
        row2.SaveObject();

        viewDescription.RefreshData();
        viewDescription.FocusedRowHandle = index + 1;
      }
    }

    private void ViewDescriptionCellValueChanging(object sender, CellValueChangedEventArgs e)
    {
      if (!IsPredefinedMode)
      {
        var predef =
          (from det in _description.PredefinedObjects where det.JobTitle == e.Value as string select det).
            FirstOrDefault();

        if (predef != null)
        {
          var newDescription = new Description
                                 {
                                   Identity = 0,
                                   JobTitle = predef.JobTitle + " [Kopie]",
                                   FkDescriptionOrder = Order.Identity,
                                   Arrange = viewDescription.RowCount + 1
                                 };
          newDescription.Identity = newDescription.SaveObject();

          foreach (var detail in predef.Details)
          {
            detail.Identity = 0;
            detail.FkDetailDescription = newDescription.Identity;
            detail.Arrange = viewDetail.RowCount + 1;
            detail.Identity = detail.SaveObject();
          }

          if (viewDescription.IsNewItemRow(viewDescription.FocusedRowHandle))
          {
            viewDescription.DeleteSelectedRows();
          }

          ReloadControl();
        }
      }
    }

    private void ViewDetailValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateDetailRow();
    }

    private void ViewDetailInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewDetailInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewDetail.SetFocusedRowCellValue(colFkDetailDescription, FocusedRow.Identity);
      viewDetail.SetFocusedRowCellValue(colArrange, viewDetail.DataRowCount);
    }

    private void DetailMoveUpEditClick(object sender, EventArgs e)
    {
      var view = viewDetail;
      var index = view.FocusedRowHandle;

      if (index > 0 && !view.IsNewItemRow(index))
      {
        var row1 = view.GetFocusedRow() as Detail;
        var row2 = view.GetRow(index - 1) as Detail;
        row1.Arrange = (int)viewDescription.GetRowCellValue(index - 1, colArrangeDetail);
        row2.Arrange = index;
        row1.SaveObject();
        row2.SaveObject();

        view.RefreshData();
        view.FocusedRowHandle = index - 1;
      }
    }

    private void DetailMoveDownEditClick(object sender, EventArgs e)
    {
      var view = viewDetail;
      var index = view.FocusedRowHandle;

      if (index < view.DataRowCount - 1 && !view.IsNewItemRow(index))
      {
        var row1 = view.GetFocusedRow() as Detail;
        var row2 = view.GetRow(index + 1) as Detail;
        row1.Arrange = (int)viewDescription.GetRowCellValue(index + 1, colArrangeDetail);
        row2.Arrange = index;
        row1.SaveObject();
        row2.SaveObject();

        view.RefreshData();
        view.FocusedRowHandle = index + 1;
      }
    }

    #region Ribbons

    public void DeleteDetailRow(object sender, ItemClickEventArgs e)
    {
      DeleteDetailRow();
    }

    public void ReloadControl(object sender, ItemClickEventArgs e)
    {
      ReloadControl();
    }

    public override RibbonPage RibbonPage
    {
      get
      {
        if (_ribbonPage == null)
        {
          _ribbonPage = new RibbonPage("Beschreibungen");
        }
        if (_ribbonGroup == null)
        {
          _ribbonGroup = new RibbonPageGroup();
          DeleteButton.ItemClick += DeleteRow;
          DeleteDetailButton.ItemClick += DeleteDetailRow;
          RefreshButton.ItemClick += ReloadControl;

          _ribbonGroup.ItemLinks.Clear();
          _ribbonGroup.ItemLinks.Add(DeleteButton);
          _ribbonGroup.ItemLinks.Add(DeleteDetailButton);
          _ribbonGroup.ItemLinks.Add(RefreshButton);

          _ribbonPage.Groups.Add(_ribbonGroup);
        }
        return _ribbonPage;
      }
    }

    public BarButtonItem RefreshButton
    {
      get
      {
        return _refreshButton ?? (_refreshButton = new BarButtonItem
        {
          Caption = "Aktualisieren",
          Id = 3,
          LargeGlyph = Properties.Resources.refresh,
          LargeWidth = 80,
        });
      }
    }

    public BarButtonItem DeleteButton
    {
      get
      {
        return _deleteButton ?? (_deleteButton = new BarButtonItem
        {
          Caption = "Löschen",
          Id = 2,
          LargeGlyph = Properties.Resources.delete,
          LargeWidth = 80,
        });
      }
    }

    public BarButtonItem DeleteDetailButton
    {
      get
      {
        return _deleteDetailButton ?? (_deleteDetailButton = new BarButtonItem
                                                               {
                                                                 Caption = "Detail löschen",
                                                                 Id = 3,
                                                                 LargeGlyph = Properties.Resources.delete,
                                                                 LargeWidth = 80,
                                                               });
      }
    }

    private RibbonPageGroup _ribbonGroup;

    private RibbonPage _ribbonPage;

    private BarButtonItem _refreshButton;

    private BarButtonItem _deleteButton;

    private BarButtonItem _deleteDetailButton;

    #endregion

    private List<GridColumn> _columns;

    private readonly Description _description = new Description();
  }
}