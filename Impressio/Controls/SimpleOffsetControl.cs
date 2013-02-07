using System;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Controls;
using Impressio.Models;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;
using System.Drawing;

namespace Impressio.Controls
{
  public partial class SimpleOffsetControl : ControlBase
  {
    public SimpleOffsetControl()
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
                                                                         }, "Einfacher Offsetdruck Wizard"));
      }
    }

    public override void ReloadControl()
    {
      //if (SimpleOffset == null) { throw new InvalidOperationException("SimpleOffset cannot be null"); }

      //_isLoaded = false;

      //SimpleOffset.LoadSingleObject();
      //_machine.ClearObjectList();
      //_paper.ClearObjectList();

      //paperSizesBindingSource.DataSource = PaperSizes.GetEndSizes();
      //machineBindingSource.DataSource = _machine.LoadObjectList();
      //paperBindingSource.DataSource = _paper.LoadObjectList();

      //if (_useSimpleOffsets.Count == 0)
      //{
      //  _useSimpleOffsets.Add(new UseSimpleOffset { UseName = "Sorte 1" });
      //}
      //useSimpleOffsetBindingSource.DataSource = _useSimpleOffsets;

      //_isLoaded = true;
    }

    public override bool ValidateControl()
    {
      //ValidateChildren();

      //if (!ErrorProvider.HasErrors)
      //{
      //  SimpleOffset.SaveObject();
      //  return true;
      //}
      return false;
    }

    //public SimpleOffset SimpleOffset;

    private void EndPaperSizeLookUpEditValueChanged(object sender, EventArgs e)
    {
      if (endPaperSizeLookUp.EditValue != null && _isLoaded)
      {
        width.Value = endPaperSizeLookUp.GetColumnValue("Width").GetInt();
        height.Value = endPaperSizeLookUp.GetColumnValue("Height").GetInt();
      }
    }

    private void FlipSizeButtonClick(object sender, EventArgs e)
    {
      var flip = width.Value;
      width.Value = height.Value;
      height.Value = flip;
    }

    private void UsesEditValueChanging(object sender, ChangingEventArgs e)
    {
      var count = _useSimpleOffsets.Count;

      if (count != e.NewValue.GetInt() && _isLoaded)
      {
        if (e.NewValue.GetInt() > e.OldValue.GetInt())
        {
          while (viewUsePer.RowCount != e.NewValue.GetInt())
          {
            viewUsePer.AddNewRow();
          }
        }
        else
        {
          while (viewUsePer.RowCount != e.NewValue.GetInt())
          {
            viewUsePer.DeleteRow(viewUsePer.RowCount - 1);
          }
        }
      }
    }

    private void ViewUsePerInitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
    {
      viewUsePer.SetRowCellValue(e.RowHandle, colUseName, "Sorte" + viewUsePer.RowCount);
    }

    private void Draw()
    {
      var graphic = drawPanel.CreateGraphics();
      graphic.Clear(Color.White);
      var pen = new Pen(Color.Black, 1);
      int div = 1;
      while (drawPanel.Height < printFormatHeight.Value)
      {
        div++;
        if ((printFormatHeight.Value / div) < drawPanel.Height)
        {
          break;
        }
      }

      //Draw the Paper
      if (printFormatWidth.Value > printFormatHeight.Value)
      {
        graphic.DrawRectangle(pen, 10, 10, (float)printFormatWidth.Value / div, (float)printFormatHeight.Value / div);
      }
      else
      {
        graphic.DrawRectangle(pen, 10, 10, (float)printFormatHeight.Value / div, (float)printFormatWidth.Value / div);
      }

      //Define the values
      var drawH = (float)height.Value / div;
      var drawW = (float)width.Value * ((float)pages.Value / 2) / div;

      if (_flipped)
      {
        drawH = (float)width.Value * ((float)pages.Value / 2) / div;
        drawW = (float)height.Value / div;
      }

      var distance = (float)4 / div;
      var leftDistance = (float)10 / div;
      var heightDistance = (float)10 / div;
      var totalW = drawW + distance;
      var totalH = drawH + distance;

      if (true)
      {
        for (int o = 0; o <= usePerVertical.Value - 1; o++)
        {
          for (int i = 0; i <= usePerHorizontal.Value - 1; i++)
          {
            graphic.DrawRectangle(pen, leftDistance + distance + (i * totalW), heightDistance + distance + (o * totalH), drawW, drawH);
          }
        }
      }
    }

    private bool _isLoaded;

    private bool _flipped;

    private readonly Machine _machine = new Machine();

    private readonly Paper _paper = new Paper();

    private List<UseSimpleOffset> _useSimpleOffsets = new List<UseSimpleOffset>();

    private RibbonPage _ribbonPage;

    private void GridUsePerValidating(object sender, System.ComponentModel.CancelEventArgs e)
    {
      var row = viewUsePer.GetFocusedRow() as UseSimpleOffset;

      if (row != null && string.IsNullOrWhiteSpace(row.UseName))
      {
        viewUsePer.SetRowCellValue(viewUsePer.FocusedRowHandle, colUseName, "Bitte eine Bezeichnung eingeben");
        e.Cancel = true;
      }
      else { viewUsePer.ClearColumnErrors(); }
    }

    private void ViewUsePerInvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void PaperLookUpEditValueChanged(object sender, EventArgs e)
    {
      var pap = paperLookUpView.GetFocusedRow() as Paper;

      if (pap != null)
      {
        printFormatWidth.Value = pap.SizeB;
        printFormatHeight.Value = pap.SizeL;
        paperprice.Value = pap.Price1;

        paperPriceLabel.Text = string.Format("Papierpreise:{0}{1}.- Fr.{0}{2}.- Fr. ab {3} Bogen{0}{4}.- Fr. ab {5} Bogen{0}{6}.- Fr. ab {7} Bogen", Environment.NewLine, pap.Price1, pap.Price2, pap.Amount1, pap.Price3, pap.Amount2, pap.Price4, pap.Amount3);
      }
      else
      {
        paperPriceLabel.Text = string.Empty;
      }
    }

    private void SheetPageEnter(object sender, EventArgs e)
    {
      Draw();
    }

    private void ColorPaperPagePageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
    {
      if (machineLookUp.EditValue != null && paperLookUp.EditValue != null)
      {
        e.Valid = false;
      }
    }

    private void SimpleButton1Click(object sender, EventArgs e)
    {
      _flipped = _flipped ? _flipped = false : _flipped = true;
      Draw();
    }

    private void RefreshDrawClick(object sender, EventArgs e)
    {
      Draw();
    }

    private void UsePerHorizontalEditValueChanged(object sender, EventArgs e)
    {
      Draw();
    }

    private void UsePerVerticalEditValueChanged(object sender, EventArgs e)
    {
      Draw();
    }

    private void UsePerHorizontalEditValueChanging(object sender, ChangingEventArgs e)
    {
      if (usePerHorizontal.Value + usePerVertical.Value > colUsePer1.SummaryText.GetInt())
      {
        e.Cancel = true;
      }
    }

    private void UsePerVerticalEditValueChanging(object sender, ChangingEventArgs e)
    {
      if (usePerHorizontal.Value + usePerVertical.Value > colUsePer1.SummaryText.GetInt())
      {
        e.Cancel = true;
      }
    }
  }
}
