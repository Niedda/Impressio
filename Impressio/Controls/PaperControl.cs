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
  public partial class PaperControl : BaseControlImpressio, IControl, IGridControl<Paper>, IRibbon
  {
    public PaperControl()
    {
      InitializeComponent();
    }

    #region Ribbon

    public string RibbonGroupName { get { return "Papierverwaltung"; } }

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
        Text = "Papierverwaltung",
        Name = "paperPageGroup"
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
        Name = "paperDelete",
      };
      deleteButton.ItemClick += DeleteRow;

      var refreshButton = new BarButtonItem
      {
        Caption = "Aktualisieren",
        Id = 2,
        LargeGlyph = Properties.Resources.refresh,
        LargeWidth = 80,
        Name = "paperRefresh"
      };
      refreshButton.ItemClick += ReloadControl;

      var importButton = new BarButtonItem
      {
        Caption = "Importieren",
        Id = 3,
        LargeGlyph = Properties.Resources.excel,
        LargeWidth = 80,
        Name = "paperImport"
      };
      importButton.ItemClick += ImportPaper;

      return new List<BarButtonItem> { deleteButton, refreshButton, importButton };
    }

    public void DeleteRow(object sender, ItemClickEventArgs e)
    {
      DeleteRow();
    }
    
    public void ReloadControl(object sender, ItemClickEventArgs e)
    {
      ReloadControl();
    }

    public void ImportPaper(object sender, ItemClickEventArgs e)
    {
      var fileDialog = new OpenFileDialog
                         {
                           Filter = "Excel (*.xls; *.xlsx) | *.xls; *.xlsx",
                         };
      var dialogResult = fileDialog.ShowDialog();

      if(dialogResult == DialogResult.OK)
      {
        Paper.LoadFromExcel(fileDialog.FileName);
      }
    }

    #endregion

    public void ReloadControl()
    {
      _paper.ClearObjectList();
      paperBindingSource.DataSource = _paper.LoadObjectList();
      viewPaper.RefreshData();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }

    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewPaper.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewPaper.ClearColumnErrors();
      CheckColumn(colName);
      CheckColumn(colPrice1);
      CheckColumn(colSizeB);
      CheckColumn(colSizeL);
      return !viewPaper.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    public Paper FocusedRow
    {
      get { return viewPaper.GetFocusedRow() as Paper; }
    }

    private readonly Paper _paper = new Paper();

    private void PaperControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewPaperInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewPaperValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewPaperRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
    }

    private void PaperControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }
  }
}