using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Impressio.Models;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class PrintControl : BaseControlImpressio, IControl, IRibbon
  {
    public PrintControl()
    {
      Print.LoadSingleObject();
      InitializeComponent();
    }

    #region Ribbon

    public string RibbonGroupName { get { return "Digitaldruck"; } }

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
        Text = "Offsetdruck",
        Name = "printPageGroup"
      };
      pageGroup.ItemLinks.AddRange(Buttons.ToArray());

      return pageGroup;
    }

    private List<BarButtonItem> _buttons;

    private List<BarButtonItem> LoadButtons()
    {
      var refreshButton = new BarButtonItem
      {
        Caption = "Aktualisieren",
        Id = 2,
        LargeGlyph = Properties.Resources.refresh,
        LargeWidth = 80,
        Name = "printRefresh"
      };
      refreshButton.ItemClick += ReloadControl;

      return new List<BarButtonItem> { refreshButton };
    }

    public void ReloadControl(object sender, ItemClickEventArgs e)
    {
      ReloadControl();
    }

    #endregion

    public Print Print;

    public void ReloadControl()
    {
      if (Print != null)
      {
        _isLoaded = false;

        _clickCost.ClearObjectList();
        _paper.ClearObjectList();
        clickCostBindingSource.DataSource = _clickCost.LoadObjectList();
        paperBindingSource.DataSource = _paper.LoadObjectList();
        Print.LoadSingleObject();
        
        paperSearchLookUp.EditValue = Print.FkPrintPaper;
        usePerPaper.Value = Print.PaperUsePer;
        typePrint.SelectedIndex = Print.PrintType;
        amountPrint.Value = Print.PrintAmount;
        lookUpClickCost.EditValue = Print.FkPrintClickCost;
        amountPaper.Value = Print.PaperAmount;
        pricePerPaper.Value = Print.PaperPricePer;
        additionPaper.Value = Print.PaperAddition;
        paperCostTotal.Value = Print.PaperCostTotal.GetInt();
        printCostTotal.Value = Print.PrintCostTotal.GetInt();
        positionTotal.Value = Print.PositionTotal;
        paperSearchLookUp.DoValidate();

        _isLoaded = true;
      }
    }

    public bool ValidateControl()
    {
      GetPrint();
      return true;
    }

    public void GetPrint()
    {
      if (_isLoaded)
      {
        Print.PrintType = typePrint.SelectedIndex;
        Print.PrintAmount = amountPrint.Value.GetInt();
        Print.PaperAddition = additionPaper.Value.GetInt();
        Print.PaperAmount = amountPaper.Value.GetInt();
        Print.PaperPricePer = pricePerPaper.Value.GetInt();
        Print.PaperUsePer = usePerPaper.Value.GetInt();
        Print.FkPrintClickCost = lookUpClickCost.EditValue.GetInt();
        Print.FkPrintPaper = paperSearchLookUp.EditValue.GetInt();
        paperCostTotal.Value = Print.PaperCostTotal.GetInt();
        printCostTotal.Value = Print.PrintCostTotal.GetInt();
        positionTotal.Value = Print.PositionTotal.GetInt();

        Print.SaveObject();
      }
    }

    public override void Refresh()
    {
      GetPrint();
      base.Refresh();
    }

    private bool _isLoaded;

    private readonly ClickCost _clickCost = new ClickCost();

    private readonly Paper _paper = new Paper();

    private void PrintControlValidating(object sender, CancelEventArgs e)
    {
      ValidateControl();
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
          GetPrint();
        }
        else
        {
          paperPriceLabel.Text = string.Empty;
        }
      }
    }

    private void FieldsEditValueChanged(object sender, EventArgs e)
    {
      GetPrint();
    }

    private void UsePerPaperEditValueChanged(object sender, EventArgs e)
    {
      if (_isLoaded)
      {
        amountPrint.Value = usePerPaper.Value * amountPaper.Value;
        GetPrint();
      }
    }
  }
}