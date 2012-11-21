namespace Impressio.Views
{
  partial class OrderParam
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.orderTitle = new DevExpress.XtraEditors.TextEdit();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.orderKind = new DevExpress.XtraEditors.TextEdit();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
      this.pages = new DevExpress.XtraEditors.SpinEdit();
      this.colorFront = new DevExpress.XtraEditors.SpinEdit();
      this.colorBack = new DevExpress.XtraEditors.SpinEdit();
      this.saveOrder = new DevExpress.XtraEditors.SimpleButton();
      this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
      this.quantity = new DevExpress.XtraEditors.SpinEdit();
      ((System.ComponentModel.ISupportInitialize)(this.orderTitle.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderKind.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pages.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.colorFront.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.colorBack.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.quantity.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(23, 28);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(68, 13);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Auftragsname";
      // 
      // orderTitle
      // 
      this.orderTitle.Location = new System.Drawing.Point(138, 25);
      this.orderTitle.Name = "orderTitle";
      this.orderTitle.Size = new System.Drawing.Size(187, 20);
      this.orderTitle.TabIndex = 1;
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(23, 68);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(57, 13);
      this.labelControl2.TabIndex = 2;
      this.labelControl2.Text = "Produkteart";
      // 
      // orderKind
      // 
      this.orderKind.Location = new System.Drawing.Point(138, 65);
      this.orderKind.Name = "orderKind";
      this.orderKind.Size = new System.Drawing.Size(187, 20);
      this.orderKind.TabIndex = 3;
      // 
      // labelControl3
      // 
      this.labelControl3.Location = new System.Drawing.Point(23, 108);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(30, 13);
      this.labelControl3.TabIndex = 4;
      this.labelControl3.Text = "Seiten";
      // 
      // labelControl4
      // 
      this.labelControl4.Location = new System.Drawing.Point(23, 148);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(92, 13);
      this.labelControl4.TabIndex = 5;
      this.labelControl4.Text = "Farben Vorderseite";
      // 
      // labelControl5
      // 
      this.labelControl5.Location = new System.Drawing.Point(23, 188);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new System.Drawing.Size(83, 13);
      this.labelControl5.TabIndex = 6;
      this.labelControl5.Text = "Farben Rückseite";
      // 
      // pages
      // 
      this.pages.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.pages.Location = new System.Drawing.Point(138, 105);
      this.pages.Name = "pages";
      this.pages.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.pages.Properties.IsFloatValue = false;
      this.pages.Properties.Mask.EditMask = "N00";
      this.pages.Size = new System.Drawing.Size(187, 20);
      this.pages.TabIndex = 7;
      // 
      // colorFront
      // 
      this.colorFront.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.colorFront.Location = new System.Drawing.Point(138, 145);
      this.colorFront.Name = "colorFront";
      this.colorFront.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.colorFront.Properties.IsFloatValue = false;
      this.colorFront.Properties.Mask.EditMask = "N00";
      this.colorFront.Size = new System.Drawing.Size(187, 20);
      this.colorFront.TabIndex = 8;
      // 
      // colorBack
      // 
      this.colorBack.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.colorBack.Location = new System.Drawing.Point(138, 185);
      this.colorBack.Name = "colorBack";
      this.colorBack.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.colorBack.Properties.IsFloatValue = false;
      this.colorBack.Properties.Mask.EditMask = "N00";
      this.colorBack.Size = new System.Drawing.Size(187, 20);
      this.colorBack.TabIndex = 9;
      // 
      // saveOrder
      // 
      this.saveOrder.Location = new System.Drawing.Point(250, 266);
      this.saveOrder.Name = "saveOrder";
      this.saveOrder.Size = new System.Drawing.Size(75, 23);
      this.saveOrder.TabIndex = 10;
      this.saveOrder.Text = "Speichern";
      this.saveOrder.Click += new System.EventHandler(this.SaveOrderClick);
      // 
      // labelControl6
      // 
      this.labelControl6.Location = new System.Drawing.Point(23, 227);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new System.Drawing.Size(37, 13);
      this.labelControl6.TabIndex = 11;
      this.labelControl6.Text = "Auflage";
      // 
      // quantity
      // 
      this.quantity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.quantity.Location = new System.Drawing.Point(138, 224);
      this.quantity.Name = "quantity";
      this.quantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.quantity.Properties.IsFloatValue = false;
      this.quantity.Properties.Mask.EditMask = "N00";
      this.quantity.Size = new System.Drawing.Size(187, 20);
      this.quantity.TabIndex = 12;
      // 
      // OrderParam
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(352, 312);
      this.Controls.Add(this.quantity);
      this.Controls.Add(this.labelControl6);
      this.Controls.Add(this.saveOrder);
      this.Controls.Add(this.colorBack);
      this.Controls.Add(this.colorFront);
      this.Controls.Add(this.pages);
      this.Controls.Add(this.labelControl5);
      this.Controls.Add(this.labelControl4);
      this.Controls.Add(this.labelControl3);
      this.Controls.Add(this.orderKind);
      this.Controls.Add(this.labelControl2);
      this.Controls.Add(this.orderTitle);
      this.Controls.Add(this.labelControl1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "OrderParam";
      this.ShowIcon = false;
      ((System.ComponentModel.ISupportInitialize)(this.orderTitle.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderKind.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pages.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.colorFront.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.colorBack.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.quantity.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.TextEdit orderTitle;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.TextEdit orderKind;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.LabelControl labelControl4;
    private DevExpress.XtraEditors.LabelControl labelControl5;
    private DevExpress.XtraEditors.SpinEdit pages;
    private DevExpress.XtraEditors.SpinEdit colorFront;
    private DevExpress.XtraEditors.SpinEdit colorBack;
    private DevExpress.XtraEditors.SimpleButton saveOrder;
    private DevExpress.XtraEditors.LabelControl labelControl6;
    private DevExpress.XtraEditors.SpinEdit quantity;
  }
}