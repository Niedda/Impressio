using System;
using DevExpress.XtraEditors.Controls;
using Impressio.Models;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Controls
{
  public partial class Gender : ControlBase
  {
    public Gender()
    {
      InitializeComponent();
    }

    public void DeleteRow()
    {
      var gender = viewGender.GetFocusedRow() as Models.Gender;

      if(gender != null)
      {
        gender.DeleteObject();
        viewGender.DeleteSelectedRows();
      }
    }

    public void ReloadControl()
    {
      _gender.ClearObjectList();
      genderBindingSource.DataSource = _gender.LoadObjectList();
    }


    private readonly Models.Gender _gender = new Models.Gender();

    private void GenderControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewGenderInvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewGenderValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      viewGender.ClearColumnErrors();
      CheckColumn(colName);
      e.Valid = !viewGender.HasColumnErrors;
    }

    private void ViewGenderRowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
    {
      viewGender.SetFocusedRowCellValue(colIdentity, (e.Row as Models.Gender).SaveObject());
    }
  }
}
