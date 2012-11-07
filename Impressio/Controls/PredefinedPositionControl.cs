using System;
using System.Collections.Generic;
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
  public partial class PredefinedPositionControl : ControlBase, IControl, IGridControl<Position>, IRibbon
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
        FocusedRow.Identity = FocusedRow.SaveObject();
      }
    }

    public void OpenPosition()
    {
      if (FocusedRow != null)
      {
        var view = new EmptyView();

        switch (FocusedRow.Type)
        {
          case Type.Datenaufbereitung:
            view.mainPanel.Controls.Add(new DataControl
                                          {
                                            Data = new Data
                                                     {
                                                       Identity = FocusedRow.Identity,
                                                     }
                                          });
            view.Show();
            break;
          case Type.Digitaldruck:
            view.mainPanel.Controls.Add(new PrintControl
                                          {
                                            Print = new Print
                                                      {
                                                        Identity = FocusedRow.Identity,
                                                      }
                                          });
            view.Show();
            break;
          case Type.Weiterverarbeitung:
            view.mainPanel.Controls.Add(new FinishControl
                                          {
                                            Finish = new Finish
                                                       {
                                                         Identity = FocusedRow.Identity,
                                                       }
                                          });
            view.Show();
            break;
          case Type.Offsetdruck:
            view.mainPanel.Controls.Add(new OffsetControl
                                          {
                                            Offset = new Offset
                                                       {
                                                         Identity = FocusedRow.Identity,
                                                       },
                                          });
            view.Show();
            break;
        }
      }
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
      e.Valid = !ValidateRow();
    }

    private void ViewPositionInvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewPositionRowUpdated(object sender, RowObjectEventArgs e)
    {
      UpdateRow();
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