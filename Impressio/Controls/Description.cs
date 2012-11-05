using System;
using System.Linq;
using DevExpress.XtraEditors.Controls;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class Description : ControlBase
  {
    public Description()
    {
      InitializeComponent();
    }

    public Order Order = new Order();

    public bool IsPredefinedMode;

    private readonly Models.Description _description = new Models.Description();
    
    public void ReloadControl()
    {
      _description.LoadPredefined();

      if (IsPredefinedMode)
      {
        IsPredefinedMode = true;
        descriptionBindingSource.DataSource = _description.PredefinedObjects;
      }
      else
      {
        descriptionBindingSource.DataSource = _description.LoadObjectList(Models.Description.Columns.FkDescriptionOrder, Order.Identity);
        predefinedDescriptionCombo.Items.Clear();
        predefinedDescriptionCombo.Items.AddRange(_description.PredefinedObjects.Select(a => a.JobTitel).ToList());
      }
    }

    public void DeleteRow()
    {
      if (FocusedRowDescription != null)
      {
        FocusedRowDescription.DeleteObject();
        viewDescription.DeleteSelectedRows();
      }
    }

    public void DeleteDetailRow()
    {
      if (FocusedRowDetail != null)
      {
        FocusedRowDetail.DeleteObject();
        viewDetail.DeleteSelectedRows();
      }
    }

    private Models.Description FocusedRowDescription
    {
      get { return viewDescription.GetFocusedRow() as Models.Description; }
    }
    
    private Detail FocusedRowDetail
    {
      get { return viewDetail.GetFocusedRow() as Detail; }
    }

    private void DescriptionControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewDescriptionValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      viewDescription.ClearColumnErrors();
      CheckColumn(colJobTitel);
      e.Valid = !viewDescription.HasColumnErrors;

      if (e.Valid)
      {
        var description = FocusedRowDescription;

        if (description != null)
        {
          if (IsPredefinedMode)
          {
            description.IsPredefined = true;
          }
          if (viewDescription.IsNewItemRow(e.RowHandle))
          {
            description.Arrange = viewDescription.RowCount;
          }
          description.SaveObject();
          ReloadControl();
        }
      }
    }

    private void ViewDescriptionInvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewDescriptionFocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    {
      var description = FocusedRowDescription;
      detailsBindingSource.Clear();

      if (description != null)
      {
        detailsBindingSource.DataSource = description.Details;
        viewDetail.RefreshData();
      }

      gridDetail.Enabled = !viewDescription.IsNewItemRow(e.FocusedRowHandle);
    }

    private void ViewDescriptionInitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
    {
      viewDescription.SetFocusedRowCellValue(colFkDescriptionOrder, Order.Identity);
    }

    private void DescriptionMoveUpEditClick(object sender, EventArgs e)
    {
      var view = viewDescription;
      var index = view.FocusedRowHandle;

      if (index > 0 && !view.IsNewItemRow(index))
      {
        var rowArrange1 = viewDescription.GetRowCellValue(index, colArrange);
        var rowArrange2 = viewDescription.GetRowCellValue(index - 1, colArrange);

        viewDescription.SetRowCellValue(index, colArrange, rowArrange2);
        viewDescription.SetRowCellValue(index - 1, colArrange, rowArrange1);

        (view.GetRow(index) as Models.Description).SaveObject();
        (view.GetRow(index - 1) as Models.Description).SaveObject();

        view.FocusedRowHandle = index - 1;
      }
    }

    private void DescriptionMoveDownEditClick(object sender, EventArgs e)
    {
      var view = viewDescription;
      var index = view.FocusedRowHandle;

      if (index < view.DataRowCount - 1 && !view.IsNewItemRow(index))
      {
        var val1 = viewDescription.GetRowCellValue(index, colArrange);
        var val2 = viewDescription.GetRowCellValue(index + 1, colArrange);

        viewDescription.SetRowCellValue(index, colArrange, val2);
        viewDescription.SetRowCellValue(index + 1, colArrange, val1);

        (view.GetRow(index) as Models.Description).SaveObject();
        (view.GetRow(index + 1) as Models.Description).SaveObject();

        view.FocusedRowHandle = index + 1;
      }
    }

    private void ViewDescriptionCellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      if (!IsPredefinedMode)
      {
        var predef =
          (from det in _description.PredefinedObjects where det.JobTitel == e.Value as string select det).
            FirstOrDefault();

        if (predef != null)
        {
          var newDescription = predef;
          newDescription.Identity = 0;
          newDescription.FkDescriptionOrder = _description.FkDescriptionOrder;
          newDescription.Arrange = viewDescription.RowCount + 1;
          newDescription.Identity = newDescription.SaveObject();

          foreach (var detail in predef.Details)
          {
            detail.Identity = 0;
            detail.FkDetailDescription = predef.Identity;
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


    private void ViewDetailValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      viewDetail.ClearColumnErrors();
      CheckColumn(colDetailTitle);
      CheckColumn(colDetailContent);
      e.Valid = !viewDetail.HasColumnErrors;
    }

    private void ViewDetailInvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewDetailInitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
    {
      viewDetail.SetFocusedRowCellValue(colFkDetailDescription, viewDescription.GetFocusedRowCellValue(colIdentity));
    }

    private void ViewDetailRowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
    {
      if (viewDetail.IsNewItemRow(e.RowHandle))
      {
        viewDetail.SetFocusedRowCellValue(colArrangeDetail, viewDetail.DataRowCount);
      }
      viewDetail.SetFocusedRowCellValue(colIdentityDetail, (e.Row as Detail).SaveObject());
    }

    private void DetailMoveUpEditClick(object sender, EventArgs e)
    {
      var view = viewDetail;
      var index = view.FocusedRowHandle;

      if (index > 0 && !view.IsNewItemRow(index))
      {
        var val1 = view.GetRowCellValue(index, colArrangeDetail);
        var val2 = view.GetRowCellValue(index - 1, colArrangeDetail);

        view.SetRowCellValue(index, colArrangeDetail, val2);
        view.SetRowCellValue(index - 1, colArrangeDetail, val1);

        (view.GetRow(index) as Detail).SaveObject();
        (view.GetRow(index - 1) as Detail).SaveObject();

        view.FocusedRowHandle = index - 1;
      }
    }

    private void DetailMoveDownEditClick(object sender, EventArgs e)
    {
      var view = viewDetail;
      var index = view.FocusedRowHandle;

      if (index < view.DataRowCount - 1 && !view.IsNewItemRow(index))
      {
        var val1 = view.GetRowCellValue(index, colArrangeDetail);
        var val2 = view.GetRowCellValue(index + 1, colArrangeDetail);

        view.SetRowCellValue(index, colArrangeDetail, val2);
        view.SetRowCellValue(index + 1, colArrangeDetail, val1);

        (view.GetRow(index) as Detail).SaveObject();
        (view.GetRow(index + 1) as Detail).SaveObject();

        view.FocusedRowHandle = index + 1;
      }
    }
  }
}
