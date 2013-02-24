using System;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Impressio.Models;
using Impressio.Models.Tools;
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

    public override RibbonPage RibbonPage
    {
      get
      {
        return _ribbonPage ?? (_ribbonPage = RibbonTools.GetSimplePage(new List<BarButtonItem>
                                                                         {
                                                                           RibbonTools.GetRefreshButton(ReloadControl),
                                                                         }, "Offsetdruck"));
      }
    }

    public override void ReloadControl()
    {
      if (Offset == null) { throw new InvalidOperationException("Offset cannot be null"); }

      _isLoaded = false;

      _machine.ClearObjectList();
      _paper.ClearObjectList();

      machineBindingSource.DataSource = _machine.LoadObjectList();
      paperBindingSource.DataSource = _paper.LoadObjectList();
      singleOffsetBindingSource.DataSource = Offset.LoadSingleObject();

      _isLoaded = true;
    }

    public override bool ValidateControl()
    {
      ValidateChildren();

      if (!ErrorProvider.HasErrors)
      {
        Offset.SaveObject();
        return true;
      }
      return false;
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
        Offset.PaperQuantity = paperQuantity.Value.GetInt() * paperUsePer.Value.GetInt();
        Offset.SaveObject();
      }
    }

    private void OffsetColorAmountEditValueChanged(object sender, EventArgs e)
    {
      if (_isLoaded)
      {
        Offset.PrintQuantity = offsetColorAmount.Value.GetInt() * offsetPaperQuantity.Value.GetInt();
        Offset.SaveObject();
      }
    }

    private void SaveOffset(object sender, EventArgs e)
    {
      Offset.SaveObject();
    }

    private RibbonPage _ribbonPage;

    private bool _isLoaded;

    private readonly Machine _machine = new Machine();

    private readonly Paper _paper = new Paper();
  }
}