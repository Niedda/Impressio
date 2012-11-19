using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;
using Type = Impressio.Models.Type;

namespace Impressio.Controls
{
  public partial class PredefinedPositionControl : XtraUserControl, IControl
  {
    public PredefinedPositionControl()
    {
      InitializeComponent();
      Dock = DockStyle.Fill;
    }

    public Position FocusedRow
    {
      get { return viewPosition.GetFocusedRow() as Position; }
    }

    public void ReloadControl()
    {
      _position.ClearPredefinedObjects();
      typeCombo.Items.Clear();
      typeCombo.Items.AddEnum(typeof(Type));
      _position.LoadPredefinedObjects();
      positionBindingSource.DataSource = _position.PredefinedObjects;
      viewPosition.RefreshData();
    }

    public void DeleteRow()
    {
      if (FocusedRow != null)
      {
        switch (FocusedRow.Type)
        {
          case Type.Datenaufbereitung:
            FocusedRow.ToType<Data>().DeleteObject();
            break;
          case Type.Digitaldruck:
            FocusedRow.ToType<Print>().DeleteObject();
            break;
          case Type.Offsetdruck:
            FocusedRow.ToType<Offset>().DeleteObject();
            break;
          case Type.Weiterverarbeitung:
            FocusedRow.ToType<Finish>().DeleteObject();
            break;
        }
      }
    }

    public bool ValidateRow()
    {
      if (FocusedRow != null && !string.IsNullOrEmpty(FocusedRow.Name))
      {
        UpdateRow();
        return true;
      }
      return FocusedRow == null;
    }

    public void UpdateRow()
    {
      switch (FocusedRow.Type)
      {
        case Type.Datenaufbereitung:
          FocusedRow.ToType<Data>().SaveObject();
          break;
        case Type.Digitaldruck:
          FocusedRow.ToType<Print>().SaveObject();
          break;
        case Type.Offsetdruck:
          FocusedRow.ToType<Offset>().SaveObject();
          break;
        case Type.Weiterverarbeitung:
          FocusedRow.ToType<Finish>().SaveObject();
          break;
      }
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }

    private void ViewPositionValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      ValidateRow();
    }

    private void ViewPositionInitNewRow(object sender, InitNewRowEventArgs e)
    {
      viewPosition.SetFocusedRowCellValue(colIsPredefined, true);
    }

    #region Ribbon

    public void DeleteRow(object sender, ItemClickEventArgs e)
    {
      DeleteRow();
    }

    public void ReloadControl(object sender, ItemClickEventArgs e)
    {
      ReloadControl();
    }

    public RibbonPage RibbonPage
    {
      get
      {
        if (_ribbonPage == null)
        {
          _ribbonPage = new RibbonPage("Vordefinierte Positionen");
        }
        if (_ribbonGroup == null)
        {
          _ribbonGroup = new RibbonPageGroup();
        }
        _ribbonGroup.ItemLinks.Clear();
        _ribbonGroup.ItemLinks.Add(DeleteButton);
        _ribbonGroup.ItemLinks.Add(RefreshButton);
        _ribbonGroup.ItemLinks.Add(OpenPositionButton);
        _refreshButton.ItemClick += ReloadControl;
        _deleteButton.ItemClick += DeleteRow;

        _ribbonPage.Groups.Add(_ribbonGroup);

        return _ribbonPage;
      }
    }

    public BarButtonItem OpenPositionButton
    {
      get
      {
        return _openPosition ?? (_openPosition = new BarButtonItem
        {
          Caption = "Position öffnen",
          Id = 1,
          LargeGlyph = Properties.Resources.open,
          LargeWidth = 80,
          Name = "positionOpen"
        });
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
          Name = "positionRefresh"
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
          Name = "positionDelete",
        });
      }
    }

    private RibbonPageGroup _ribbonGroup;

    private RibbonPage _ribbonPage;

    private BarButtonItem _openPosition;

    private BarButtonItem _refreshButton;

    private BarButtonItem _deleteButton;

    #endregion

    private readonly Position _position = new Position();
  }
}