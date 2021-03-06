﻿using Impressio.Models;

namespace Impressio.Controls
{
  partial class PrintControl
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.amountPrint = new DevExpress.XtraEditors.SpinEdit();
      this.printBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
      this.lookUpClickCost = new DevExpress.XtraEditors.LookUpEdit();
      this.clickCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
      this.paperSearchLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
      this.paperBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.viewPaper = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colItemNumber = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colVendor = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPrice2 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPrice3 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPrice4 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAmount2 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAmount3 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDirection = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDirectionString = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colSizeL = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colSizeB = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
      this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
      this.amountPaper = new DevExpress.XtraEditors.SpinEdit();
      this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
      this.paperCostTotal = new DevExpress.XtraEditors.SpinEdit();
      this.usePerPaper = new DevExpress.XtraEditors.SpinEdit();
      this.paperTotal = new DevExpress.XtraEditors.LabelControl();
      this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.additionPaper = new DevExpress.XtraEditors.SpinEdit();
      this.paperPriceLabel = new DevExpress.XtraEditors.LabelControl();
      this.pricePerPaper = new DevExpress.XtraEditors.SpinEdit();
      this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
      this.positionTotal = new DevExpress.XtraEditors.SpinEdit();
      this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
      this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
      this.typePrint = new DevExpress.XtraEditors.ComboBoxEdit();
      this.printCostTotal = new DevExpress.XtraEditors.SpinEdit();
      this.printTotal = new DevExpress.XtraEditors.LabelControl();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.amountPrint.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.printBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpClickCost.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.clickCostBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.paperSearchLookUp.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.paperBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewPaper)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.amountPaper.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
      this.groupControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.paperCostTotal.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.usePerPaper.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.additionPaper.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pricePerPaper.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.positionTotal.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
      this.groupControl2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.typePrint.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.printCostTotal.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(19, 55);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(43, 13);
      this.labelControl2.TabIndex = 2;
      this.labelControl2.Text = "Klickpreis";
      // 
      // amountPrint
      // 
      this.amountPrint.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.printBindingSource, "PrintAmount", true));
      this.amountPrint.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.amountPrint.Location = new System.Drawing.Point(128, 99);
      this.amountPrint.Name = "amountPrint";
      this.amountPrint.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.amountPrint.Properties.DisplayFormat.FormatString = "N00";
      this.amountPrint.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.amountPrint.Properties.EditFormat.FormatString = "N00";
      this.amountPrint.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.amountPrint.Properties.IsFloatValue = false;
      this.amountPrint.Properties.Mask.EditMask = "N00";
      this.amountPrint.Size = new System.Drawing.Size(93, 20);
      this.amountPrint.TabIndex = 3;
      this.amountPrint.EditValueChanged += new System.EventHandler(this.SavePrint);
      // 
      // printBindingSource
      // 
      this.printBindingSource.DataSource = typeof(Impressio.Models.Print);
      // 
      // labelControl3
      // 
      this.labelControl3.Location = new System.Drawing.Point(19, 102);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(37, 13);
      this.labelControl3.TabIndex = 4;
      this.labelControl3.Text = "Auflage";
      // 
      // labelControl5
      // 
      this.labelControl5.Location = new System.Drawing.Point(274, 102);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new System.Drawing.Size(41, 13);
      this.labelControl5.TabIndex = 6;
      this.labelControl5.Text = "Druckart";
      // 
      // lookUpClickCost
      // 
      this.lookUpClickCost.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.printBindingSource, "FkPrintClickCost", true));
      this.lookUpClickCost.Location = new System.Drawing.Point(128, 52);
      this.lookUpClickCost.Name = "lookUpClickCost";
      this.lookUpClickCost.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpClickCost.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Identity", "Identity", 53, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 36, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cost", "Klickkosten", 30, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
      this.lookUpClickCost.Properties.DataSource = this.clickCostBindingSource;
      this.lookUpClickCost.Properties.DisplayMember = "Name";
      this.lookUpClickCost.Properties.NullText = "";
      this.lookUpClickCost.Properties.ValueMember = "Identity";
      this.lookUpClickCost.Size = new System.Drawing.Size(334, 20);
      this.lookUpClickCost.TabIndex = 8;
      this.lookUpClickCost.EditValueChanged += new System.EventHandler(this.SavePrint);
      // 
      // clickCostBindingSource
      // 
      this.clickCostBindingSource.DataSource = typeof(Impressio.Models.ClickCost);
      // 
      // labelControl6
      // 
      this.labelControl6.Location = new System.Drawing.Point(19, 50);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new System.Drawing.Size(30, 13);
      this.labelControl6.TabIndex = 10;
      this.labelControl6.Text = "Papier";
      // 
      // paperSearchLookUp
      // 
      this.paperSearchLookUp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.printBindingSource, "FkPrintPaper", true));
      this.paperSearchLookUp.EditValue = "";
      this.paperSearchLookUp.Location = new System.Drawing.Point(128, 47);
      this.paperSearchLookUp.Name = "paperSearchLookUp";
      this.paperSearchLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.paperSearchLookUp.Properties.DataSource = this.paperBindingSource;
      this.paperSearchLookUp.Properties.DisplayMember = "Name";
      this.paperSearchLookUp.Properties.NullText = "";
      this.paperSearchLookUp.Properties.ValueMember = "Identity";
      this.paperSearchLookUp.Properties.View = this.viewPaper;
      this.paperSearchLookUp.Size = new System.Drawing.Size(334, 20);
      this.paperSearchLookUp.TabIndex = 11;
      this.paperSearchLookUp.EditValueChanged += new System.EventHandler(this.LookUpPaperEditValueChanged);
      // 
      // paperBindingSource
      // 
      this.paperBindingSource.DataSource = typeof(Impressio.Models.Paper);
      // 
      // viewPaper
      // 
      this.viewPaper.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colName,
            this.colItemNumber,
            this.colVendor,
            this.colPrice1,
            this.colPrice2,
            this.colPrice3,
            this.colPrice4,
            this.colAmount1,
            this.colAmount2,
            this.colAmount3,
            this.colDirection,
            this.colDirectionString,
            this.colSizeL,
            this.colSizeB,
            this.colSize});
      this.viewPaper.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.viewPaper.Name = "viewPaper";
      this.viewPaper.OptionsBehavior.ReadOnly = true;
      this.viewPaper.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.viewPaper.OptionsView.ShowGroupPanel = false;
      // 
      // colIdentity
      // 
      this.colIdentity.FieldName = "Identity";
      this.colIdentity.Name = "colIdentity";
      this.colIdentity.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // colItemNumber
      // 
      this.colItemNumber.Caption = "Nummer";
      this.colItemNumber.FieldName = "ItemNumber";
      this.colItemNumber.Name = "colItemNumber";
      this.colItemNumber.Visible = true;
      this.colItemNumber.VisibleIndex = 5;
      // 
      // colVendor
      // 
      this.colVendor.Caption = "Verkäufer";
      this.colVendor.FieldName = "Vendor";
      this.colVendor.Name = "colVendor";
      this.colVendor.Visible = true;
      this.colVendor.VisibleIndex = 4;
      // 
      // colPrice1
      // 
      this.colPrice1.Caption = "Preis";
      this.colPrice1.FieldName = "Price1";
      this.colPrice1.Name = "colPrice1";
      this.colPrice1.Visible = true;
      this.colPrice1.VisibleIndex = 3;
      // 
      // colPrice2
      // 
      this.colPrice2.Caption = "Preisstufe 2";
      this.colPrice2.FieldName = "Price2";
      this.colPrice2.Name = "colPrice2";
      // 
      // colPrice3
      // 
      this.colPrice3.Caption = "Preisstufe 3";
      this.colPrice3.FieldName = "Price3";
      this.colPrice3.Name = "colPrice3";
      // 
      // colPrice4
      // 
      this.colPrice4.Caption = "Preisstufe 4";
      this.colPrice4.FieldName = "Price4";
      this.colPrice4.Name = "colPrice4";
      // 
      // colAmount1
      // 
      this.colAmount1.Caption = "Menge PS2";
      this.colAmount1.FieldName = "Amount1";
      this.colAmount1.Name = "colAmount1";
      // 
      // colAmount2
      // 
      this.colAmount2.Caption = "Menge PS3";
      this.colAmount2.FieldName = "Amount2";
      this.colAmount2.Name = "colAmount2";
      // 
      // colAmount3
      // 
      this.colAmount3.Caption = "Menge PS4";
      this.colAmount3.FieldName = "Amount3";
      this.colAmount3.Name = "colAmount3";
      // 
      // colDirection
      // 
      this.colDirection.FieldName = "Direction";
      this.colDirection.Name = "colDirection";
      this.colDirection.OptionsColumn.AllowEdit = false;
      this.colDirection.OptionsColumn.AllowShowHide = false;
      this.colDirection.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colDirectionString
      // 
      this.colDirectionString.Caption = "Laufrichtung";
      this.colDirectionString.FieldName = "DirectionString";
      this.colDirectionString.Name = "colDirectionString";
      this.colDirectionString.OptionsColumn.ReadOnly = true;
      this.colDirectionString.Visible = true;
      this.colDirectionString.VisibleIndex = 2;
      // 
      // colSizeL
      // 
      this.colSizeL.FieldName = "SizeW";
      this.colSizeL.Name = "colSizeL";
      this.colSizeL.OptionsColumn.AllowEdit = false;
      this.colSizeL.OptionsColumn.AllowShowHide = false;
      this.colSizeL.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colSizeB
      // 
      this.colSizeB.FieldName = "SizeH";
      this.colSizeB.Name = "colSizeB";
      this.colSizeB.OptionsColumn.AllowEdit = false;
      this.colSizeB.OptionsColumn.AllowShowHide = false;
      this.colSizeB.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colSize
      // 
      this.colSize.Caption = "Format";
      this.colSize.FieldName = "Size";
      this.colSize.Name = "colSize";
      this.colSize.OptionsColumn.ReadOnly = true;
      this.colSize.Visible = true;
      this.colSize.VisibleIndex = 1;
      // 
      // labelControl7
      // 
      this.labelControl7.Location = new System.Drawing.Point(19, 138);
      this.labelControl7.Name = "labelControl7";
      this.labelControl7.Size = new System.Drawing.Size(84, 13);
      this.labelControl7.TabIndex = 12;
      this.labelControl7.Text = "Anzahl Rohbogen";
      // 
      // amountPaper
      // 
      this.amountPaper.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.printBindingSource, "PaperAmount", true));
      this.amountPaper.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.amountPaper.Location = new System.Drawing.Point(128, 135);
      this.amountPaper.Name = "amountPaper";
      this.amountPaper.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.amountPaper.Properties.DisplayFormat.FormatString = "N00";
      this.amountPaper.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.amountPaper.Properties.EditFormat.FormatString = "N00";
      this.amountPaper.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.amountPaper.Properties.IsFloatValue = false;
      this.amountPaper.Properties.Mask.EditMask = "N00";
      this.amountPaper.Size = new System.Drawing.Size(93, 20);
      this.amountPaper.TabIndex = 13;
      this.amountPaper.EditValueChanged += new System.EventHandler(this.UsePerPaperEditValueChanged);
      // 
      // groupControl1
      // 
      this.groupControl1.Controls.Add(this.paperCostTotal);
      this.groupControl1.Controls.Add(this.usePerPaper);
      this.groupControl1.Controls.Add(this.paperTotal);
      this.groupControl1.Controls.Add(this.labelControl11);
      this.groupControl1.Controls.Add(this.labelControl1);
      this.groupControl1.Controls.Add(this.additionPaper);
      this.groupControl1.Controls.Add(this.paperPriceLabel);
      this.groupControl1.Controls.Add(this.pricePerPaper);
      this.groupControl1.Controls.Add(this.labelControl8);
      this.groupControl1.Controls.Add(this.amountPaper);
      this.groupControl1.Controls.Add(this.labelControl6);
      this.groupControl1.Controls.Add(this.labelControl7);
      this.groupControl1.Controls.Add(this.paperSearchLookUp);
      this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupControl1.Location = new System.Drawing.Point(0, 0);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new System.Drawing.Size(845, 182);
      this.groupControl1.TabIndex = 14;
      this.groupControl1.Text = "Papier";
      // 
      // paperCostTotal
      // 
      this.paperCostTotal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.printBindingSource, "PaperCostTotal", true));
      this.paperCostTotal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.paperCostTotal.Enabled = false;
      this.paperCostTotal.Location = new System.Drawing.Point(644, 135);
      this.paperCostTotal.Name = "paperCostTotal";
      this.paperCostTotal.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
      this.paperCostTotal.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
      this.paperCostTotal.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
      this.paperCostTotal.Properties.AppearanceDisabled.Options.UseBackColor = true;
      this.paperCostTotal.Properties.AppearanceDisabled.Options.UseBorderColor = true;
      this.paperCostTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
      this.paperCostTotal.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
      this.paperCostTotal.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White;
      this.paperCostTotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
      this.paperCostTotal.Properties.AppearanceReadOnly.Options.UseBackColor = true;
      this.paperCostTotal.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
      this.paperCostTotal.Properties.AppearanceReadOnly.Options.UseForeColor = true;
      this.paperCostTotal.Properties.DisplayFormat.FormatString = "c";
      this.paperCostTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.paperCostTotal.Properties.ReadOnly = true;
      this.paperCostTotal.Size = new System.Drawing.Size(93, 20);
      this.paperCostTotal.TabIndex = 21;
      // 
      // usePerPaper
      // 
      this.usePerPaper.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.printBindingSource, "PaperUsePer", true));
      this.usePerPaper.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.usePerPaper.Location = new System.Drawing.Point(369, 135);
      this.usePerPaper.Name = "usePerPaper";
      this.usePerPaper.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.usePerPaper.Properties.DisplayFormat.FormatString = "N00";
      this.usePerPaper.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.usePerPaper.Properties.EditFormat.FormatString = "N00";
      this.usePerPaper.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.usePerPaper.Properties.IsFloatValue = false;
      this.usePerPaper.Properties.Mask.EditMask = "N00";
      this.usePerPaper.Size = new System.Drawing.Size(93, 20);
      this.usePerPaper.TabIndex = 22;
      this.usePerPaper.EditValueChanged += new System.EventHandler(this.UsePerPaperEditValueChanged);
      // 
      // paperTotal
      // 
      this.paperTotal.Location = new System.Drawing.Point(559, 138);
      this.paperTotal.Name = "paperTotal";
      this.paperTotal.Size = new System.Drawing.Size(69, 13);
      this.paperTotal.TabIndex = 18;
      this.paperTotal.Text = "Papierkosten: ";
      // 
      // labelControl11
      // 
      this.labelControl11.Location = new System.Drawing.Point(274, 138);
      this.labelControl11.Name = "labelControl11";
      this.labelControl11.Size = new System.Drawing.Size(34, 13);
      this.labelControl11.TabIndex = 21;
      this.labelControl11.Text = "Nutzen";
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(19, 94);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(71, 13);
      this.labelControl1.TabIndex = 20;
      this.labelControl1.Text = "Preis per 1\'000";
      // 
      // additionPaper
      // 
      this.additionPaper.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.printBindingSource, "PaperAddition", true));
      this.additionPaper.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.additionPaper.Location = new System.Drawing.Point(369, 91);
      this.additionPaper.Name = "additionPaper";
      this.additionPaper.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.additionPaper.Properties.DisplayFormat.FormatString = "N00";
      this.additionPaper.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.additionPaper.Properties.EditFormat.FormatString = "N00";
      this.additionPaper.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.additionPaper.Properties.IsFloatValue = false;
      this.additionPaper.Properties.Mask.EditMask = "N00";
      this.additionPaper.Size = new System.Drawing.Size(93, 20);
      this.additionPaper.TabIndex = 19;
      this.additionPaper.EditValueChanged += new System.EventHandler(this.SavePrint);
      // 
      // paperPriceLabel
      // 
      this.paperPriceLabel.Location = new System.Drawing.Point(559, 50);
      this.paperPriceLabel.Name = "paperPriceLabel";
      this.paperPriceLabel.Size = new System.Drawing.Size(58, 13);
      this.paperPriceLabel.TabIndex = 18;
      this.paperPriceLabel.Text = "Preisstufen:";
      // 
      // pricePerPaper
      // 
      this.pricePerPaper.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.printBindingSource, "PaperPricePer", true));
      this.pricePerPaper.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.pricePerPaper.Location = new System.Drawing.Point(128, 91);
      this.pricePerPaper.Name = "pricePerPaper";
      this.pricePerPaper.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.pricePerPaper.Properties.DisplayFormat.FormatString = "c";
      this.pricePerPaper.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.pricePerPaper.Properties.EditFormat.FormatString = "c";
      this.pricePerPaper.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.pricePerPaper.Properties.IsFloatValue = false;
      this.pricePerPaper.Properties.Mask.EditMask = "N00";
      this.pricePerPaper.Size = new System.Drawing.Size(93, 20);
      this.pricePerPaper.TabIndex = 15;
      this.pricePerPaper.EditValueChanged += new System.EventHandler(this.SavePrint);
      // 
      // labelControl8
      // 
      this.labelControl8.Location = new System.Drawing.Point(274, 94);
      this.labelControl8.Name = "labelControl8";
      this.labelControl8.Size = new System.Drawing.Size(67, 13);
      this.labelControl8.TabIndex = 14;
      this.labelControl8.Text = "Zuschlag in %";
      // 
      // positionTotal
      // 
      this.positionTotal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.printBindingSource, "PositionTotal", true));
      this.positionTotal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.positionTotal.Enabled = false;
      this.positionTotal.Location = new System.Drawing.Point(644, 172);
      this.positionTotal.Name = "positionTotal";
      this.positionTotal.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
      this.positionTotal.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
      this.positionTotal.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
      this.positionTotal.Properties.AppearanceDisabled.Options.UseBackColor = true;
      this.positionTotal.Properties.AppearanceDisabled.Options.UseBorderColor = true;
      this.positionTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
      this.positionTotal.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
      this.positionTotal.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White;
      this.positionTotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
      this.positionTotal.Properties.AppearanceReadOnly.Options.UseBackColor = true;
      this.positionTotal.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
      this.positionTotal.Properties.AppearanceReadOnly.Options.UseForeColor = true;
      this.positionTotal.Properties.DisplayFormat.FormatString = "c";
      this.positionTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.positionTotal.Properties.ReadOnly = true;
      this.positionTotal.Size = new System.Drawing.Size(93, 20);
      this.positionTotal.TabIndex = 17;
      // 
      // labelControl9
      // 
      this.labelControl9.Location = new System.Drawing.Point(559, 175);
      this.labelControl9.Name = "labelControl9";
      this.labelControl9.Size = new System.Drawing.Size(24, 13);
      this.labelControl9.TabIndex = 16;
      this.labelControl9.Text = "Total";
      // 
      // groupControl2
      // 
      this.groupControl2.Controls.Add(this.typePrint);
      this.groupControl2.Controls.Add(this.printCostTotal);
      this.groupControl2.Controls.Add(this.labelControl9);
      this.groupControl2.Controls.Add(this.printTotal);
      this.groupControl2.Controls.Add(this.positionTotal);
      this.groupControl2.Controls.Add(this.amountPrint);
      this.groupControl2.Controls.Add(this.lookUpClickCost);
      this.groupControl2.Controls.Add(this.labelControl5);
      this.groupControl2.Controls.Add(this.labelControl2);
      this.groupControl2.Controls.Add(this.labelControl3);
      this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupControl2.Location = new System.Drawing.Point(0, 182);
      this.groupControl2.Name = "groupControl2";
      this.groupControl2.Size = new System.Drawing.Size(845, 216);
      this.groupControl2.TabIndex = 15;
      this.groupControl2.Text = "Druck";
      // 
      // typePrint
      // 
      this.typePrint.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.printBindingSource, "PrintTypeString", true));
      this.typePrint.EditValue = "Einseitig";
      this.typePrint.Location = new System.Drawing.Point(351, 99);
      this.typePrint.Name = "typePrint";
      this.typePrint.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.typePrint.Properties.DropDownRows = 2;
      this.typePrint.Properties.Items.AddRange(new object[] {
            "Einseitig",
            "Zweiseitig"});
      this.typePrint.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.typePrint.Size = new System.Drawing.Size(111, 20);
      this.typePrint.TabIndex = 21;
      this.typePrint.EditValueChanged += new System.EventHandler(this.SavePrint);
      // 
      // printCostTotal
      // 
      this.printCostTotal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.printBindingSource, "PrintCostTotal", true));
      this.printCostTotal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.printCostTotal.Enabled = false;
      this.printCostTotal.Location = new System.Drawing.Point(644, 99);
      this.printCostTotal.Name = "printCostTotal";
      this.printCostTotal.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
      this.printCostTotal.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
      this.printCostTotal.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
      this.printCostTotal.Properties.AppearanceDisabled.Options.UseBackColor = true;
      this.printCostTotal.Properties.AppearanceDisabled.Options.UseBorderColor = true;
      this.printCostTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
      this.printCostTotal.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
      this.printCostTotal.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White;
      this.printCostTotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
      this.printCostTotal.Properties.AppearanceReadOnly.Options.UseBackColor = true;
      this.printCostTotal.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
      this.printCostTotal.Properties.AppearanceReadOnly.Options.UseForeColor = true;
      this.printCostTotal.Properties.DisplayFormat.FormatString = "c";
      this.printCostTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.printCostTotal.Properties.ReadOnly = true;
      this.printCostTotal.Size = new System.Drawing.Size(93, 20);
      this.printCostTotal.TabIndex = 20;
      // 
      // printTotal
      // 
      this.printTotal.Location = new System.Drawing.Point(559, 102);
      this.printTotal.Name = "printTotal";
      this.printTotal.Size = new System.Drawing.Size(63, 13);
      this.printTotal.TabIndex = 19;
      this.printTotal.Text = "Druckkosten:";
      // 
      // PrintControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupControl2);
      this.Controls.Add(this.groupControl1);
      this.Name = "PrintControl";
      this.Size = new System.Drawing.Size(845, 398);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.amountPrint.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.printBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpClickCost.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.clickCostBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.paperSearchLookUp.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.paperBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewPaper)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.amountPaper.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
      this.groupControl1.ResumeLayout(false);
      this.groupControl1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.paperCostTotal.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.usePerPaper.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.additionPaper.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pricePerPaper.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.positionTotal.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
      this.groupControl2.ResumeLayout(false);
      this.groupControl2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.typePrint.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.printCostTotal.Properties)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.SpinEdit amountPrint;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.LabelControl labelControl5;
    private DevExpress.XtraEditors.LookUpEdit lookUpClickCost;
    private DevExpress.XtraEditors.LabelControl labelControl6;
    private DevExpress.XtraEditors.SearchLookUpEdit paperSearchLookUp;
    private DevExpress.XtraGrid.Views.Grid.GridView viewPaper;
    private DevExpress.XtraEditors.LabelControl labelControl7;
    private DevExpress.XtraEditors.SpinEdit amountPaper;
    private DevExpress.XtraEditors.GroupControl groupControl1;
    private DevExpress.XtraEditors.SpinEdit positionTotal;
    private DevExpress.XtraEditors.LabelControl labelControl9;
    private DevExpress.XtraEditors.SpinEdit pricePerPaper;
    private DevExpress.XtraEditors.LabelControl labelControl8;
    private DevExpress.XtraEditors.GroupControl groupControl2;
    private System.Windows.Forms.BindingSource clickCostBindingSource;
    private System.Windows.Forms.BindingSource paperBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colItemNumber;
    private DevExpress.XtraGrid.Columns.GridColumn colVendor;
    private DevExpress.XtraGrid.Columns.GridColumn colPrice1;
    private DevExpress.XtraGrid.Columns.GridColumn colPrice2;
    private DevExpress.XtraGrid.Columns.GridColumn colPrice3;
    private DevExpress.XtraGrid.Columns.GridColumn colPrice4;
    private DevExpress.XtraGrid.Columns.GridColumn colAmount1;
    private DevExpress.XtraGrid.Columns.GridColumn colAmount2;
    private DevExpress.XtraGrid.Columns.GridColumn colAmount3;
    private DevExpress.XtraGrid.Columns.GridColumn colDirection;
    private DevExpress.XtraGrid.Columns.GridColumn colDirectionString;
    private DevExpress.XtraGrid.Columns.GridColumn colSizeL;
    private DevExpress.XtraGrid.Columns.GridColumn colSizeB;
    private DevExpress.XtraGrid.Columns.GridColumn colSize;
    private DevExpress.XtraEditors.SpinEdit additionPaper;
    private DevExpress.XtraEditors.LabelControl paperPriceLabel;
    private DevExpress.XtraEditors.LabelControl printTotal;
    private DevExpress.XtraEditors.LabelControl paperTotal;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.SpinEdit usePerPaper;
    private DevExpress.XtraEditors.LabelControl labelControl11;
    private DevExpress.XtraEditors.SpinEdit paperCostTotal;
    private DevExpress.XtraEditors.SpinEdit printCostTotal;
    private DevExpress.XtraEditors.ComboBoxEdit typePrint;
    private System.Windows.Forms.BindingSource printBindingSource;

  }
}
