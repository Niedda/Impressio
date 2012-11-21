using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Impressio.Models;
using Impressio.Models.Tools;

namespace Impressio.Controls
{
  public partial class PredefinedPositionControl : XtraUserControl, IControl
  {
    public PredefinedPositionControl()
    {
      InitializeComponent();
      Dock = DockStyle.Fill;
    }

    public IPosition FocusedRow
    {
      get { return viewPosition.GetFocusedRow() as IPosition; }
    }

    public RibbonPage RibbonPage
    {
      get
      {
        return _ribbonPage ?? (_ribbonPage = RibbonTools.GetSimplePage(new List<BarButtonItem>
                                                                         {
                                                                           RibbonTools.GetRefreshButton(ReloadControl),
                                                                           OpenPositionButton,
                                                                           RibbonTools.GetDeleteButton(DeleteRow),
                                                                         }, "Positionen"));
      }
    }

    public BarButtonItem OpenPositionButton
    {
      get
      {
        return _openPosition ?? (_openPosition = RibbonTools.GetOpenButton());
      }
    }

    public void ReloadControl()
    {
      _position.ClearPredefinedObjects();
      positionBindingSource.DataSource = _position.PredefinedPosition;
      lookUpTypes.DataSource = Position.AvailableTypes();
      lookUpTypes.DropDownRows = Position.AvailablePositions().Count > 10 ? 10 : Position.AvailablePositions().Count;
    }

    public void DeleteRow()
    {
      if (FocusedRow != null)
      {
        FocusedRow.DeletePosition();
        viewPosition.DeleteSelectedRows();
      }
    }

    public bool ValidateRow()
    {
      if(!viewPosition.FocusedRowModified)
      {
        return true;
      }
      if (FocusedRow != null)
      {
        if(string.IsNullOrEmpty(FocusedRow.Name))
        {
          viewPosition.SetColumnError(colName, "Bitte einen gültigen Namen eintragen");
        }
        else
        {
          viewPosition.SetColumnError(colName, "");
        }
        if(string.IsNullOrEmpty(FocusedRow.DisplayName))
        {
          viewPosition.SetColumnError(colDisplayName, "Bitte einen gültigen Typ eintragen");
        }
        else
        {
          viewPosition.SetColumnError(colDisplayName, "");
        }
        if (viewPosition.IsNewItemRow(viewPosition.FocusedRowHandle) && !viewPosition.HasColumnErrors)
        {
          var match = (from pos in _position.PredefinedPosition where pos.Name == FocusedRow.Name select pos).Count();
          if (match == 1)
          {
            viewPosition.SetColumnError(colName, "");
          }
          else
          {
            viewPosition.SetColumnError(colName, "Eine Position mit diesem Namen existiert bereits");
          }
        }
        if (!viewPosition.HasColumnErrors)
        {
          UpdateRow();
          return true;
        }
      }
      return false;
    }

    public void UpdateRow()
    {
      FocusedRow.IsPredefined = true;
      FocusedRow.Identity = FocusedRow.SavePosition();
    }

    public bool ValidateControl()
    {
      return ValidateRow();
    }

    private void ViewPositionValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      e.Valid = ValidateRow();
    }

    private void ViewPositionFocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    {
      colDisplayName.ColumnEdit = viewPosition.IsNewItemRow(e.FocusedRowHandle) ? lookUpTypes : null;
      colDisplayName.OptionsColumn.AllowEdit = viewPosition.IsNewItemRow(e.FocusedRowHandle);
    }

    private void ViewPositionInvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    public void DeleteRow(object sender, ItemClickEventArgs e)
    {
      DeleteRow();
    }

    public void ReloadControl(object sender, ItemClickEventArgs e)
    {
      ReloadControl();
    }

    private RibbonPage _ribbonPage;

    private BarButtonItem _openPosition;

    private readonly Position _position = new Position();
  }
}