using System;
using System.ComponentModel;
using Impressio.Models;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class OffsetControl : ControlBase, IControl
  {
    public OffsetControl()
    {
      InitializeComponent();
    }

    public void ReloadControl()
    {
      if (Offset != null)
      {
        machineBindingSource.DataSource = _machine.LoadObjectList();
        paperBindingSource.DataSource = _paper.LoadObjectList();
        Offset.LoadSingleObject();

        paperSearchLookUp.EditValue = Offset.FkOffsetPaper;
        paperAddition.Value = Offset.PaperAddition;
        paperPricePer.Value = Offset.PaperPricePer;
        paperQuantity.Value = Offset.PaperQuantity;
        paperUsePer.Value = Offset.PaperUsePer;

        offsetMachineSearchLookUp.EditValue = Offset.FkOffsetMachine;
        offsetPrintType.SelectedIndex = Offset.PrintType;
        offsetColorAmount.Value = Offset.ColorAmount;
        offsetPaperQuantity.Value = Offset.OffsetQuantity;
        offsetPrintQuantity.Value = Offset.PrintQuantity;
        offsetPrintTotal.Value = Offset.PrintTotal;
        paperCostTotal.Value = Offset.PaperCostTotal;

        priceTotal.Value = Offset.PositionTotal;

        _isLoaded = true;
      }
    }

    public bool ValidateControl()
    {
      GetOffset();
      Offset.SaveObject();
      return true;
    }

    public void GetOffset()
    {
      if (_isLoaded)
      {
        Offset.FkOffsetPaper = paperSearchLookUp.EditValue.GetInt();
        Offset.FkOffsetMachine = offsetMachineSearchLookUp.EditValue.GetInt();

        Offset.PaperAddition = paperAddition.Value.GetInt();
        Offset.PaperPricePer = paperPricePer.Value.GetInt();
        Offset.PaperQuantity = paperQuantity.Value.GetInt();
        Offset.PaperUsePer = paperUsePer.Value.GetInt();

        Offset.PrintType = offsetPrintType.SelectedIndex;
        Offset.ColorAmount = offsetColorAmount.Value.GetInt();
        Offset.PrintQuantity = offsetPrintQuantity.Value.GetInt();
        Offset.OffsetQuantity = offsetPaperQuantity.Value.GetInt();

        paperCostTotal.Value = Offset.PaperCostTotal;
        offsetPrintTotal.Value = Offset.PrintTotal;
        priceTotal.Value = Offset.PaperCostTotal + Offset.PrintTotal;
      }
    }
    private readonly Machine _machine = new Machine();

    private readonly Paper _paper = new Paper();

    public Offset Offset = new Offset();

    private bool _isLoaded;

    private void OffsetControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void OffsetControlValidating(object sender, CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }

    private void PaperSearchLookUpEditValueChanged(object sender, EventArgs e)
    {
      if (paperSearchLookUp.EditValue != null && _isLoaded)
      {
        Offset.FkOffsetPaper = (int)paperSearchLookUp.EditValue;

        if (Offset.Paper != null)
        {
          labelPricePaper.Text += string.Format("{0}{1}{0}{2} ab {3} Bogen{0}{4} ab {5} Bogen{0}{6} ab {7} Bogen",
                                                Environment.NewLine, Offset.Paper.Price1, Offset.Paper.Price2,
                                                Offset.Paper.Amount1, Offset.Paper.Price3, Offset.Paper.Amount2,
                                                Offset.Paper.Price4, Offset.Paper.Amount3);
          paperPricePer.Value = Offset.Paper.Price1;
        }
      }
    }

    private void PaperQuantityEditValueChanged(object sender, EventArgs e)
    {
      if (paperQuantity.Value != 0 && paperUsePer.Value != 0 && _isLoaded)
      {
        offsetPaperQuantity.Value = paperQuantity.Value * paperUsePer.Value;
        paperCostTotal.Value = Offset.PaperCostTotal;
      }
    }

    private void OffsetMachineSearchLookUpEditValueChanged(object sender, EventArgs e)
    {
      if (_isLoaded)
      {
        Offset.FkOffsetMachine = (int)offsetMachineSearchLookUp.EditValue;
      }
    }

    private void OffsetColorAmountEditValueChanged(object sender, EventArgs e)
    {
      if (_isLoaded)
      {
        offsetPrintQuantity.Value = offsetColorAmount.Value * offsetPaperQuantity.Value;
      }
    }

    private void EditorsValidated(object sender, EventArgs e)
    {
      GetOffset();
    }
  }
}