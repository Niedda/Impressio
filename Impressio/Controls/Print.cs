using System;
using System.ComponentModel;
using Impressio.Models;
using Impressio.Models.Database;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Models.Tools;

namespace Impressio.Controls
{
  public partial class Print : Models.ControlBase
  {
    public Print()
    {
      InitializeComponent();
    }

    public Models.Print Print;


    private readonly Models.ClickCost _clickCost = new Models.ClickCost();

    private readonly Models.Paper _paper = new Models.Paper();

    private bool _isLoaded;

    private void PrintControlLoad(object sender, EventArgs e)
    {
      clickCostBindingSource.DataSource = _clickCost.LoadObjectList();
      paperBindingSource.DataSource = _paper.LoadObjectList();

      if (Print != null)
      {
        Print.LoadSingleObject();

        typePrint.SelectedIndex = Print.PrintType;
        amountPrint.Value = Print.PrintAmount;
        lookUpClickCost.EditValue = Print.FkPrintClickCost;

        amountPaper.Value = Print.PaperAmount;
        pricePerPaper.Value = Print.PaperAddition;
        additionPaper.Value = Print.PaperAddition;
        usePerPaper.Value = Print.PaperUsePer;
        lookUpPaper.EditValue = Print.FkPrintPaper;

        if(Print.PaperCostTotal != null)
        {
          paperCostTotal.Value = (decimal)Print.PaperCostTotal;  
        }
        if(Print.PrintCostTotal != null)
        {
          printCostTotal.Value = (decimal) Print.PrintCostTotal;
        }
        if(Print.TotalCost != null)
        {
          positionTotal.Value = (decimal)Print.TotalCost;
        }
        
        _isLoaded = true;
      }
    }

    private void PrintControlValidating(object sender, CancelEventArgs e)
    {
      GetPrintValues();
    }

    private void LookUpPaperEditValueChanged(object sender, EventArgs e)
    {
      var paper = paperView.GetFocusedRow() as Models.Paper;

      if (paper != null)
      {
        paperPriceLabel.Text = string.Format("{8}{0}{1}{9}{0}{2}{9} ab {3} Bogen{0}{4}{9} ab {5} Bogen{0}{6}{9} ab {7} Bogen",
                                              Environment.NewLine, paper.Price1, paper.Price2, paper.Amount1,
                                              paper.Price3, paper.Amount2, paper.Price4, paper.Amount3, "Preisstufe:", ".00 Fr.");
      }
      else
      {
        paperPriceLabel.Text = string.Empty;
      }
    }

    private void FieldsEditValueChanged(object sender, EventArgs e)
    {
      GetPrintValues();
    }

    private void LookUpClickCostEditValueChanged(object sender, EventArgs e)
    {
      if(lookUpClickCost.EditValue != null)
      {
        Print.FkPrintClickCost = (int)lookUpClickCost.EditValue;
      }
    }

    private void GetPrintValues()
    {
      if (_isLoaded)
      {
        Print.PrintType = typePrint.SelectedIndex;
        Print.PrintAmount = (int)amountPrint.Value;

        Print.PaperAddition = (int)additionPaper.Value;
        Print.PaperAmount = (int)amountPaper.Value;
        Print.PaperPricePer = (int)pricePerPaper.Value;
        Print.PaperUsePer = (int)usePerPaper.Value;
        
        Print.FkPrintClickCost = lookUpClickCost.EditValue.GetInt();
        Print.FkPrintPaper = lookUpPaper.EditValue.GetInt();

        if (Print.PaperCostTotal != null)
        {
          paperCostTotal.Value = (decimal)Print.PaperCostTotal;
        }
        if (Print.PrintCostTotal != null)
        {
          printCostTotal.Value = (decimal)Print.PrintCostTotal;
        }
        if (Print.PrintCostTotal != null && Print.PaperCostTotal != null)
        {
          positionTotal.Value = (decimal)Print.TotalCost;
          Print.PriceTotal = (int)positionTotal.Value;
        }

        Print.SaveObject();
      }
    }

    private void UsePerPaperEditValueChanged(object sender, EventArgs e)
    {
      if (_isLoaded)
      {
        amountPrint.Value = usePerPaper.Value * amountPaper.Value;
        GetPrintValues();
      }
    }
  }
}
