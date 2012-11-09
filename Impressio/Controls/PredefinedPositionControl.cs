using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Views;
using Subvento.DatabaseObject;
using Type = Impressio.Models.Type;

namespace Impressio.Controls
{
  public partial class PredefinedPositionControl : BaseControlImpressio, IControl, IGridControl<Position>, IRibbon
  {
    public PredefinedPositionControl()
    {
      InitializeComponent();
    }

    #region Ribbon

    public string RibbonGroupName { get { return "Vordefinierte Positionen"; } }

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
        Text = "Vordefinierte Positionen",
        Name = "predefinedPositionPageGroup"
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
        Id = 2,
        LargeGlyph = Properties.Resources.delete,
        LargeWidth = 80,
        Name = "positionDelete",
      };
      deleteButton.ItemClick += DeleteRow;

      var refreshButton = new BarButtonItem
      {
        Caption = "Aktualisieren",
        Id = 3,
        LargeGlyph = Properties.Resources.refresh,
        LargeWidth = 80,
        Name = "positionRefresh"
      };
      refreshButton.ItemClick += ReloadControl;

      var importButton = new BarButtonItem
      {
        Caption = "Position öffnen",
        Id = 1,
        LargeGlyph = Properties.Resources.open,
        LargeWidth = 80,
        Name = "positionOpen"
      };
      importButton.ItemClick += OpenPosition;

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

    public void OpenPosition(object sender, ItemClickEventArgs e)
    {
      OpenPosition();
    }

    #endregion

    public void ReloadControl()
    {
      _position.ClearPredefinedObjects();
      typeCombo.Items.Clear();
      typeCombo.Items.AddEnum(typeof(Type));
      _position.LoadPredefined();
      positionBindingSource.DataSource = _position.PredefinedObjects;
      viewPosition.RefreshData();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }

    public void DeleteRow()
    {
      FocusedRow.DeleteObject();
      viewPosition.DeleteSelectedRows();
    }

    public bool ValidateRow()
    {
      viewPosition.ClearColumnErrors();
      CheckColumn(colName);
      CheckColumn(colType);
      return !viewPosition.HasColumnErrors;
    }

    public void UpdateRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.IsPredefined = true;
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    private void OpenPosition()
    {
      if (FocusedRow != null)
      {
        var id = FocusedRow.Identity;
        switch (FocusedRow.Type)
        {
          case Type.Datenaufbereitung:
            var dataControl = new DataControl { Data = new Data { Identity = id, }, };
            dataControl.ReloadControl();
            OpenPosition(dataControl);
            break;
          case Type.Digitaldruck:
            var printControl = new PrintControl { Print = new Print { Identity = id } };
            OpenPosition(printControl);
            printControl.ReloadControl();
            break;
          case Type.Offsetdruck:
            var offsetControl = new OffsetControl { Offset = new Offset { Identity = id } };
            offsetControl.ReloadControl();
            OpenPosition(offsetControl);
            break;
          case Type.Weiterverarbeitung:
            var finishControl = new FinishControl { Finish = new Finish { Identity = id } };
            finishControl.ReloadControl();
            OpenPosition(finishControl);
            break;
        }
      }
    }

    private void OpenPosition(Control control)
    {
      MainViewRibbon.Instance.mainPanel.Controls.Add(control);
      control.BringToFront();
      MainViewRibbon.Instance.SetCustomRibbon(control as IRibbon, true);
      MainViewRibbon.Instance.FocusedDetailControl = control;
    }

    public Position FocusedRow
    {
      get { return viewPosition.GetFocusedRow() as Position; }
    }

    private readonly Position _position = new Position();

    private void PredefinedPositionControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void ViewPositionValidateRow(object sender, ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();

      if (e.Valid)
      {
        UpdateRow();
      }
    }

    private void ViewPositionInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewPositionInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewPosition.SetFocusedRowCellValue(colIsPredefined, true);
    }

    private void ViewPositionRowClick(object sender, RowClickEventArgs e)
    {
      if (e.Clicks == 2)
      {
        OpenPosition();
      }
    }
  }
}