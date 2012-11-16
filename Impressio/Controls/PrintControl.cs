using System;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class PrintControl : ControlBase
  {
    public PrintControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public Print Print;

    public override void ReloadControl()
    {
      if (Print != null)
      {
        _isLoaded = false;

        _clickCost.ClearObjectList();
        _paper.ClearObjectList();
        clickCostBindingSource.DataSource = _clickCost.LoadObjectList();
        paperBindingSource.DataSource = _paper.LoadObjectList();
        Print.LoadSingleObject();
        printBindingSource.DataSource = Print;
 
        _isLoaded = true;
      }
    }

    private void SavePrint(object sender, EventArgs e)
    {
      Print.SaveObject();
    }

    private void LookUpPaperEditValueChanged(object sender, EventArgs e)
    {
      if (_isLoaded)
      {
        var paper = viewPaper.GetFocusedRow() as Paper;

        if (paper != null)
        {
          paperPriceLabel.Text =
            string.Format("{8}{0}{1}{9}{0}{2}{9} ab {3} Bogen{0}{4}{9} ab {5} Bogen{0}{6}{9} ab {7} Bogen",
                          Environment.NewLine, paper.Price1, paper.Price2, paper.Amount1,
                          paper.Price3, paper.Amount2, paper.Price4, paper.Amount3, "Preisstufe:", ".00 Fr.");
          Print.SaveObject();
        }
        else
        {
          paperPriceLabel.Text = string.Empty;
        }
      }
    }

    private void UsePerPaperEditValueChanged(object sender, EventArgs e)
    {
      if (_isLoaded && usePerPaper != null && amountPaper != null)
      {
        Print.PrintAmount = (int)usePerPaper.Value * (int)amountPaper.Value;
        Print.SaveObject();
      }
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

    private readonly ClickCost _clickCost = new ClickCost();

    private readonly Paper _paper = new Paper();
  }
}