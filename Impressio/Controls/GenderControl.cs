using System;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class GenderControl : ControlBase, IControl, IGridControl<Gender>
  {
    private readonly Gender _gender = new Gender();

    public GenderControl()
    {
      InitializeComponent();
    }

    #region IControl Members

    public void ReloadControl()
    {
      _gender.ClearObjectList();
      genderBindingSource.DataSource = _gender.LoadObjectList();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }

    #endregion

    #region IGridControl<Gender> Members

    public Gender FocusedRow
    {
      get { return viewGender.GetFocusedRow() as Gender; }
    }

    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewGender.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewGender.ClearColumnErrors();
      CheckColumn(colName);
      return !viewGender.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    #endregion

    private void GenderControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewGenderInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewGenderValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewGenderRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void GenderControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }
  }
}