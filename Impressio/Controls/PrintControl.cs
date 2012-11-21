using System;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Impressio.Models;
using Impressio.Models.Tools;
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
    
    public override RibbonPage RibbonPage
    {
      get
      {
        return _ribbonPage ?? (_ribbonPage = RibbonTools.GetSimplePage(new List<BarButtonItem>
                                                                         {
                                                                           RibbonTools.GetRefreshButton(ReloadControl),
                                                                         }, "Digitaldruck"));
      }
    }

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

    public override bool ValidateControl()
    {
      ValidateChildren();

      if (!ErrorProvider.HasErrors)
      {
        Print.SaveObject();
        return true;
      }
      return false;
    }
    
    public Print Print;

    private void SavePrint(object sender, EventArgs e)
    {
      if (_isLoaded)
      {
        Print.SaveObject();
      }
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
    
    private RibbonPage _ribbonPage;

    private bool _isLoaded;

    private readonly ClickCost _clickCost = new ClickCost();

    private readonly Paper _paper = new Paper();
  }
}