using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraWizard;
using Impressio.Models;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Controls
{
  public partial class SingleOffsetControl : ControlBase
  {
    public SingleOffsetControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public SingleOffset SingleOffset { get; set; }

    public override RibbonPage RibbonPage
    {
      get
      {
        return _ribbonPage ?? (_ribbonPage = RibbonTools.GetSimplePage(new List<BarButtonItem>
                                                                         {
                                                                           RibbonTools.GetRefreshButton(ReloadControl),
                                                                         }, "Einzelblatt Offset"));
      }
    }

    public override void ReloadControl()
    {
      if (SingleOffset == null) { throw new InvalidOperationException("Offset cannot be null"); }

      _isLoaded = false;

      _machine.ClearObjectList();
      _paper.ClearObjectList();
      _paperSizes.ClearObjectList();

      _paperSizes.LoadObjectList();
      printTypeCombo.Properties.DataSource = PrintType.PrintTypes;
      paperSizesBindingSource.DataSource = from pap in _paperSizes.Objects where pap.IsFinishSize select pap;
      finishSizeLookUp.Properties.DropDownRows = paperSizesBindingSource.Count;
      paperSizesBindingSource1.DataSource = from pap in _paperSizes.Objects where !pap.IsFinishSize select pap;
      sizeSheetLookUp.Properties.DropDownRows = paperSizesBindingSource1.Count;
      machineBindingSource.DataSource = _machine.LoadObjectList();
      machineLookUp.Properties.DropDownRows = _machine.Objects.Count;
      paperBindingSource.DataSource = _paper.LoadObjectList();
      singleOffsetBindingSource.DataSource = SingleOffset.LoadSingleObject();

      _isLoaded = true;
    }

    public override bool ValidateControl()
    {
      ValidateChildren();

      if (!ErrorProvider.HasErrors)
      {
        SingleOffset.SaveObject();
        return true;
      }
      return false;
    }

    public void DrawFinishSheet()
    {
      Drawing.Draw(panelControl2, (int)printFormatWidth.Value, (int)printFormatHeight.Value, (int)finishSizeL.Value, (int)finishSizeH.Value, (int)usePerVertical.Value, (int)usePerHorizontal.Value, flipUsePer.Checked);
    }

    public void DrawPaperSheet()
    {
      var comp1 = (SingleOffset.Paper.SizeB / printFormatWidth.Value) * (SingleOffset.Paper.SizeL / printFormatHeight.Value);
      var comp2 = (SingleOffset.Paper.SizeB / printFormatHeight.Value) * (SingleOffset.Paper.SizeL / printFormatWidth.Value);

      if (comp1 > comp2)
      {
        var heightUse = (int)(SingleOffset.Paper.SizeL / printFormatHeight.Value);
        var widthUse = (int)(SingleOffset.Paper.SizeB / printFormatWidth.Value);
        Drawing.Draw(panelControl4, SingleOffset.Paper.SizeL, SingleOffset.Paper.SizeB, (int)printFormatWidth.Value, (int)printFormatHeight.Value, widthUse, heightUse, false, false);
        usePerSheetLabel.Text = comp1 == usePerSheet.Value ? "" : string.Format("Anzahl Nutzen passt nicht.{0}Empfohlen wären {1} Nutzen.", Environment.NewLine, (int)comp1);
      }
      else
      {
        var heightUse = (int)(SingleOffset.Paper.SizeB / printFormatHeight.Value);
        var widthUse = (int)(SingleOffset.Paper.SizeL / printFormatWidth.Value);
        Drawing.Draw(panelControl4, SingleOffset.Paper.SizeL, SingleOffset.Paper.SizeB, (int)printFormatWidth.Value, (int)printFormatHeight.Value, widthUse, heightUse, false, false);
        usePerSheetLabel.Text = comp2 == usePerSheet.Value ? "" : string.Format("Anzahl Nutzen passt nicht.{0}Empfohlen wären {1} Nutzen.", Environment.NewLine, (int)comp1);
      }
    }

    private void setupListBox_ItemChecking(object sender, DevExpress.XtraEditors.Controls.ItemCheckingEventArgs e)
    {
      switch (e.Index)
      {
        case 0:
          setupListBox.SetItemCheckState(1, CheckState.Unchecked);
          setupListBox.SetItemCheckState(2, CheckState.Unchecked);
          SingleOffset.EasySetup = true;
          SingleOffset.DifficultSetup = false;
          return;
        case 1:
          setupListBox.SetItemCheckState(0, CheckState.Unchecked);
          setupListBox.SetItemCheckState(2, CheckState.Unchecked);
          SingleOffset.EasySetup = false;
          SingleOffset.DifficultSetup = true;
          return;
        case 2:
          setupListBox.SetItemCheckState(0, CheckState.Unchecked);
          setupListBox.SetItemCheckState(1, CheckState.Unchecked);
          SingleOffset.DifficultSetup = false;
          SingleOffset.EasySetup = false;
          return;
      }
    }

    private void finishSizeLookUp_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
    {
      var pap = (from pa in _paperSizes.Objects where pa.Identity == (int)e.NewValue select pa).FirstOrDefault();

      if (pap != null)
      {
        finishSizeL.Value = pap.Width;
        finishSizeH.Value = pap.Height;
        SingleOffset.Width = pap.Width;
        SingleOffset.Height = pap.Height;
      }
    }

    private void sizeSheetLookUp_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
    {
      var pap = (from pa in _paperSizes.Objects where pa.Identity == (int)e.NewValue select pa).FirstOrDefault();

      if (pap != null)
      {
        printFormatWidth.Value = pap.Width;
        printFormatHeight.Value = pap.Height;
        SingleOffset.PrintFormatWidth = pap.Width;
        SingleOffset.PrintFormatHeight = pap.Height;
      }
    }

    private void wizardPageBasicProperties_PageValidating(object sender, WizardPageValidatingEventArgs e)
    {
      ErrorProvider.SetError(quantity, quantity.Value == 0 ? "Bitte eine gültige Auflage eingeben" : "");
      ErrorProvider.SetError(finishSizeL, finishSizeL.Value == 0 ? "Bitte eine gültige Breite eingeben" : "");
      ErrorProvider.SetError(finishSizeH, finishSizeH.Value == 0 ? "Bitte eine gültige Höhe eingeben" : "");
      e.Valid = !ErrorProvider.HasErrors;

      if (e.Valid)
      {
        simpleColor.Value = colorFront.Value > colorBack.Value ? colorFront.Value : colorBack.Value;
        Drawing.Draw(panelControl2, (int)printFormatWidth.Value, (int)printFormatHeight.Value, (int)finishSizeL.Value, (int)finishSizeH.Value, (int)usePerVertical.Value, (int)usePerHorizontal.Value, flipUsePer.Checked);
      }
    }

    private void drawSheet_Click(object sender, EventArgs e)
    {
      Drawing.Draw(panelControl2, (int)printFormatWidth.Value, (int)printFormatHeight.Value, (int)finishSizeL.Value, (int)finishSizeH.Value, (int)usePerVertical.Value, (int)usePerHorizontal.Value, flipUsePer.Checked);
    }

    private void wizardPageSheetSetup_PageValidating(object sender, WizardPageValidatingEventArgs e)
    {
      if (e.Direction == Direction.Backward) { return; }

      if ((int)printTypeCombo.EditValue == 2)
      {
        ErrorProvider.SetError(printTypeCombo, usePerHorizontal.Value % 2 != 0 ? "Ungültige Anzahl Nutzen bei dieser Druckart" : "");
      }
      else if ((int)printTypeCombo.EditValue == 3)
      {
        ErrorProvider.SetError(printTypeCombo, usePerVertical.Value % 2 != 0 ? "Ungültige Anzahl Nutzen bei dieser Druckart" : "");
      }
      ErrorProvider.SetError(printFormatWidth, printFormatWidth.Value == 0 ? "Bitte ein Format eingeben" : "");
      ErrorProvider.SetError(printFormatHeight, printFormatHeight.Value == 0 ? "Bitte ein Format eingeben" : "");
      ErrorProvider.SetError(machineLookUp, (int)machineLookUp.EditValue == 0 ? "Bitte eine Druckmaschine auswählen" : "");
      ErrorProvider.SetError(usePerHorizontal, usePerHorizontal.Value == 0 ? "Bitte Nutzen eingeben" : "");
      ErrorProvider.SetError(usePerVertical, usePerVertical.Value == 0 ? "Bitte Nutzen eingeben" : "");
      e.Valid = !ErrorProvider.HasErrors;

      if (e.Valid)
      {
        switch ((int)printTypeCombo.EditValue)
        {
          case 1:
            plate.Value = colorFront.Value;
            SingleOffset.PlateQuantity = (int)(colorFront.Value > colorBack.Value ? colorFront.Value : colorBack.Value);
            break;
          case 4:
            plate.Value = colorFront.Value + colorBack.Value;
            SingleOffset.PlateQuantity = (int)(colorFront.Value > colorBack.Value ? colorFront.Value : colorBack.Value);
            break;
          default:
            plate.Value = colorFront.Value > colorBack.Value ? colorFront.Value : colorBack.Value;
            SingleOffset.PlateQuantity = (int)(colorFront.Value > colorBack.Value ? colorFront.Value : colorBack.Value);
            break;
        }
        CalculatePaperQuantity();
      }
    }

    private void flipUsePer_CheckedChanged(object sender, EventArgs e)
    {
      SingleOffset.IsFlipped = flipUsePer.Checked;
    }

    private void SingleOffsetControl_Paint(object sender, PaintEventArgs e)
    {
      Drawing.Draw(panelControl2, (int)printFormatWidth.Value, (int)printFormatHeight.Value, (int)finishSizeL.Value, (int)finishSizeH.Value, (int)usePerVertical.Value, (int)usePerHorizontal.Value, flipUsePer.Checked);
    }

    private void panelControl2_Paint(object sender, PaintEventArgs e)
    {
      Drawing.Draw(panelControl2, (int)printFormatWidth.Value, (int)printFormatHeight.Value, (int)finishSizeL.Value, (int)finishSizeH.Value, (int)usePerVertical.Value, (int)usePerHorizontal.Value, flipUsePer.Checked);
    }

    private void wizardPagePaper_PageValidating(object sender, WizardPageValidatingEventArgs e)
    {
      ErrorProvider.SetError(paperSearchLook, (int)paperSearchLook.EditValue == 0 ? "Bitte ein Papier auswählen" : "");
      ErrorProvider.SetError(usePerSheet, usePerSheet.Value == 0 ? "Bitte Nutzen korrigieren" : "");
      e.Valid = !ErrorProvider.HasErrors;
    }

    private void paperSearchLook_EditValueChanged(object sender, EventArgs e)
    {
      if (_isLoaded && (int)paperSearchLook.EditValue > 0)
      {
        var pap = new Paper { Identity = (int)paperSearchLook.EditValue };
        pap.LoadSingleObject();
        paperDesc.Text = string.Format("ab 1 Bogen:{1}.00 Fr.{0}ab {2} Bogen: {3}.00 Fr.{0}ab {4} Bogen: {5}.00 Fr.{0}ab {6} Bogen: {7}.00 Fr.",
                           Environment.NewLine, pap.Price1, pap.Amount1, pap.Price2, pap.Amount2, pap.Price3, pap.Amount3, pap.Price4);
        pricePaper.Value = pap.Price1;
        SingleOffset.PaperPrice = pap.Price1;
        var comp1 = (pap.SizeB / printFormatWidth.Value) * (pap.SizeL / printFormatHeight.Value);
        var comp2 = (pap.SizeB / printFormatHeight.Value) * (pap.SizeL / printFormatWidth.Value);
        SingleOffset.PaperUsePer = (int)(comp1 > comp2 ? comp1 : comp2);
        usePerSheet.Value = comp1 > comp2 ? comp1 : comp2;
      }
      else
      {
        paperDesc.Text = string.Empty;
      }
    }

    private void detailsPage_PageValidating(object sender, WizardPageValidatingEventArgs e)
    {
      if (e.Direction == Direction.Forward)
      {
        treeList1.BeginUnboundLoad();
        treeList1.ClearNodes();

        var rootPaper = treeList1.AppendNode(new object[] { "Papier", null, null, null }, null);
        treeList1.AppendNode(new object[] { SingleOffset.Paper.Name, (additionPaper.Value / usePerSheet.Value) + (quantity.Value / (usePerHorizontal.Value * usePerVertical.Value)), SingleOffset.PaperPrice, SingleOffset.PaperCostTotal }, rootPaper);

        var rootSetup = treeList1.AppendNode(new object[] { "Einrichten", null, null, null }, null);
        treeList1.AppendNode(new object[] { SingleOffset.EasySetup ? "Einfaches Einrichten" : SingleOffset.DifficultSetup ? "Aufwendiges Einrichten" : "Kein Einrichten", null, null, SingleOffset.SetupCostTotal }, rootSetup);

        var rootPlate = treeList1.AppendNode(new object[] { "Platten", null, null, null }, null);
        treeList1.AppendNode(new object[] { "Platten", SingleOffset.PlateQuantity, SingleOffset.Machine.PlateCost, SingleOffset.PlateCost }, rootPlate);

        var rootColor = treeList1.AppendNode(new object[] { "Einrichten", null, null, null }, null);
        treeList1.AppendNode(new object[] { "Einfacher Farbwechsel", SingleOffset.EasyColorChange, (SingleOffset.Machine.PricePerColor * (SingleOffset.Machine.PricePerHour / 60)), SingleOffset.EasyColorChange * (SingleOffset.Machine.PricePerColor * (SingleOffset.Machine.PricePerHour / 60)) }, rootColor);
        treeList1.AppendNode(new object[] { "Aufwendiger Farbwechsel", SingleOffset.DifficultColorChange, (SingleOffset.Machine.DifficultColor * (SingleOffset.Machine.PricePerHour / 60)), SingleOffset.DifficultColorChange * (SingleOffset.Machine.DifficultColor * (SingleOffset.Machine.PricePerHour / 60)) }, rootColor);

        var rootPrint = treeList1.AppendNode(new object[] { "Druck", null, null, null }, null);
        var colors = SingleOffset.FkPrintType == 1 ? colorFront.Value : SingleOffset.FkPrintType > 2 ? colorFront.Value + colorBack.Value : colorFront.Value;
        treeList1.AppendNode(new object[] { "Fortdruck", paperQuantity.Value * (colors), null, SingleOffset.PrintCostTotal }, rootPrint);

        var rootTotal = treeList1.AppendNode(new object[] { "Total", null, null, SingleOffset.PositionTotal }, 99);
        
        treeList1.EndUnboundLoad();
        treeList1.ExpandAll();
      }
    }

    private void additionPaper_EditValueChanged(object sender, EventArgs e)
    {
      if (_isLoaded)
      {
        CalculatePaperQuantity();
      }
    }

    private void pricePaper_EditValueChanged(object sender, EventArgs e)
    {
      if (_isLoaded)
      {
        CalculatePaperQuantity();
      }
    }

    private void CalculatePaperQuantity()
    {
      if (_isLoaded)
      {
        SingleOffset.PaperQuantity = (int)(quantity.Value / (usePerHorizontal.Value * usePerVertical.Value) + (additionPaper.Value / usePerSheet.Value));
        paperQuantity.Value = quantity.Value / (usePerHorizontal.Value * usePerVertical.Value) + (additionPaper.Value / usePerSheet.Value);
        paperTotalPrice.Value = (paperQuantity.Value / 1000) * pricePaper.Value;
      }
    }
    
    private void panelControl1_MouseHover(object sender, EventArgs e)
    {
      DrawFinishSheet();
    }

    private void panelControl2_MouseHover(object sender, EventArgs e)
    {
      DrawFinishSheet();
    }

    private void panelControl3_MouseHover(object sender, EventArgs e)
    {
      DrawPaperSheet();
    }

    private void panelControl4_MouseHover(object sender, EventArgs e)
    {
      DrawPaperSheet();
    }

    private void treeList1_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
    {
      if (e.Column.FieldName == "colTotal" && e.Node.Id == 11)
      {
        e.Appearance.BackColor = Color.DeepSkyBlue;
        e.Appearance.BackColor2 = Color.White;
      }
    }

    private void singleOffsetWizard_FinishClick(object sender, System.ComponentModel.CancelEventArgs e)
    {
      singleOffsetWizard.SelectedPage = wizardPageBasicProperties;
    }

    private void singleOffsetWizard_CustomizeCommandButtons(object sender, CustomizeCommandButtonsEventArgs e)
    {
      e.CancelButton.Visible = false;
      e.NextButton.Location = e.CancelButton.Location;
      e.FinishButton.Location = e.CancelButton.Location;
      e.FinishButton.Text = "Anfang >";
    }

    private readonly PaperSizes _paperSizes = new PaperSizes();

    private readonly Paper _paper = new Paper();

    private RibbonPage _ribbonPage;

    private bool _isLoaded;

    private readonly Machine _machine = new Machine();
  }
}
