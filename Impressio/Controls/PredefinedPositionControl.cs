using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Impressio.Models;
using Type = Impressio.Models.Type;

namespace Impressio.Controls
{
  public partial class PredefinedPositionControl : PositionControlBase
  {
    public PredefinedPositionControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override GridView GridView
    {
      get { return viewPosition; }
    }

    public override List<GridColumn> ColumnsToCheck
    {
      get
      {
        return _columns ?? (_columns = new List<GridColumn>
                                         {
                                           colName,
                                           colType,
                                         });
      }
    }
    
    public override void ReloadControl()
    {
      _position.ClearPredefinedObjects();
      typeCombo.Items.Clear();
      typeCombo.Items.AddEnum(typeof(Type));
      _position.LoadPredefined();
      positionBindingSource.DataSource = _position.PredefinedObjects;
      viewPosition.RefreshData();
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

    public override RibbonPage RibbonPage
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

    private List<GridColumn> _columns; 
    
    private readonly Position _position = new Position();
  }
}