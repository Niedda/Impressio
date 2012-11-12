using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class GenderControl : BaseControlImpressio, IControl, IGridControl<Gender>, IRibbon
  {
    public GenderControl()
    {
      InitializeComponent();
    }

    #region Ribbon

    public string RibbonGroupName { get { return "Anreden"; } }

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
        Text = "Anreden",
        Name = "genderPageGroup"
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
        Name = "genderDelete",
      };
      deleteButton.ItemClick += DeleteRow;

      var refreshButton = new BarButtonItem
      {
        Caption = "Aktualisieren",
        Id = 2,
        LargeGlyph = Properties.Resources.refresh,
        LargeWidth = 80,
        Name = "genderRefresh"
      };
      refreshButton.ItemClick += ReloadControl;

      return new List<BarButtonItem> { deleteButton, refreshButton };
    }

    public void DeleteRow(object sender, ItemClickEventArgs e)
    {
      DeleteRow();
    }

    public void ReloadControl(object sender, ItemClickEventArgs e)
    {
      ReloadControl();
    }

    #endregion

    public void ReloadControl()
    {
      _gender.ClearObjectList();
      genderBindingSource.DataSource = _gender.LoadObjectList();
      viewGender.RefreshData();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }

    public void DeleteRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.DeleteObject();
        viewGender.DeleteSelectedRows();
      }
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

    public Gender FocusedRow
    {
      get { return viewGender.GetFocusedRow() as Gender; }
    }

    private readonly Gender _gender = new Gender();

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
      if (ValidateRow())
      {
        UpdateRow();
      }
      else
      {
        e.Valid = false;
      }
    }

    private void GenderControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }

    private void GridGenderKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        if (viewGender.IsNewItemRow(viewGender.FocusedRowHandle))
        {
          viewGender.FocusedRowHandle = 0;
        }
      }
    }
  }
}