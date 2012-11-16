using System;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class OffsetControl : ControlBase
  {
    public OffsetControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override void ReloadControl()
    {
      if (Offset != null)
      {
        _isLoaded = false;

        _machine.ClearObjectList();
        _paper.ClearObjectList();

        machineBindingSource.DataSource = _machine.LoadObjectList();
        paperBindingSource.DataSource = _paper.LoadObjectList();
        Offset.LoadSingleObject();

        _isLoaded = true;
      }
    }

    public Offset Offset;

    private void PaperSearchLookUpEditValueChanged(object sender, EventArgs e)
    {
      if (paperSearchLookUp.EditValue != null && _isLoaded)
      {
        if (Offset.Paper != null)
        {
          labelPricePaper.Text += string.Format("{0}{1}{0}{2} ab {3} Bogen{0}{4} ab {5} Bogen{0}{6} ab {7} Bogen",
                                                Environment.NewLine, Offset.Paper.Price1, Offset.Paper.Price2,
                                                Offset.Paper.Amount1, Offset.Paper.Price3, Offset.Paper.Amount2,
                                                Offset.Paper.Price4, Offset.Paper.Amount3);
          Offset.SaveObject();
        }
        else
        {
          labelPricePaper.Text = string.Empty;
        }
      }
    }

    private void PaperQuantityEditValueChanged(object sender, EventArgs e)
    {
      if (paperQuantity.Value != 0 && paperUsePer.Value != 0 && _isLoaded)
      {
        Offset.PaperQuantity = (int)paperQuantity.Value * (int)paperUsePer.Value;
        Offset.SaveObject();
      }
    }

    private void OffsetColorAmountEditValueChanged(object sender, EventArgs e)
    {
      if (_isLoaded)
      {
        Offset.PrintQuantity = (int)offsetColorAmount.Value * (int)offsetPaperQuantity.Value;
        Offset.SaveObject();
      }
    }

    private void SaveOffset(object sender, EventArgs e)
    {
      Offset.SaveObject();
    }

    #region Ribbon

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
          _ribbonPage = new RibbonPage("Datenaufbereitung");
        }
        if (_ribbonGroup == null)
        {
          _ribbonGroup = new RibbonPageGroup();
        }

        _ribbonGroup.ItemLinks.Clear();
        _ribbonGroup.ItemLinks.Add(RefreshButton);
        _refreshButton.ItemClick += ReloadControl;
        _ribbonPage.Groups.Add(_ribbonGroup);

        return _ribbonPage;
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
        });
      }
    }

    private RibbonPageGroup _ribbonGroup;

    private RibbonPage _ribbonPage;

    private BarButtonItem _refreshButton;

    #endregion

    private bool _isLoaded;

    private readonly Machine _machine = new Machine();

    private readonly Paper _paper = new Paper();
  }
}