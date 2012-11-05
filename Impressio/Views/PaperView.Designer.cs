namespace Impressio.Views
{
  partial class PaperView
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
      this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
      this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
      this.navImportExcel = new DevExpress.XtraNavBar.NavBarItem();
      this.navDeletePaper = new DevExpress.XtraNavBar.NavBarItem();
      this.mainPanel = new DevExpress.XtraEditors.PanelControl();
      this.openExcelDialog = new System.Windows.Forms.OpenFileDialog();
      this.navRefresh = new DevExpress.XtraNavBar.NavBarItem();
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
      this.SuspendLayout();
      // 
      // navBarControl1
      // 
      this.navBarControl1.ActiveGroup = this.navBarGroup1;
      this.navBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
      this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navImportExcel,
            this.navDeletePaper,
            this.navRefresh});
      this.navBarControl1.Location = new System.Drawing.Point(3, 5);
      this.navBarControl1.Name = "navBarControl1";
      this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
      this.navBarControl1.Size = new System.Drawing.Size(163, 449);
      this.navBarControl1.TabIndex = 0;
      this.navBarControl1.Text = "navBarControl1";
      // 
      // navBarGroup1
      // 
      this.navBarGroup1.Appearance.Font = new System.Drawing.Font("Frutiger LT Std 87 ExtraBlk Cn", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.navBarGroup1.Appearance.Options.UseFont = true;
      this.navBarGroup1.Caption = "Papierverwaltung";
      this.navBarGroup1.Expanded = true;
      this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navImportExcel),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDeletePaper),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navRefresh)});
      this.navBarGroup1.Name = "navBarGroup1";
      // 
      // navImportExcel
      // 
      this.navImportExcel.Caption = "Excel importieren";
      this.navImportExcel.Name = "navImportExcel";
      this.navImportExcel.SmallImage = global::Impressio.Properties.Resources.excel;
      this.navImportExcel.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavImportExcelLinkClicked);
      // 
      // navDeletePaper
      // 
      this.navDeletePaper.Caption = "Papier löschen";
      this.navDeletePaper.Name = "navDeletePaper";
      this.navDeletePaper.SmallImage = global::Impressio.Properties.Resources.delete;
      this.navDeletePaper.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavDeletePaperLinkClicked);
      // 
      // mainPanel
      // 
      this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mainPanel.Location = new System.Drawing.Point(172, 5);
      this.mainPanel.Name = "mainPanel";
      this.mainPanel.Size = new System.Drawing.Size(607, 450);
      this.mainPanel.TabIndex = 1;
      // 
      // openExcelDialog
      // 
      this.openExcelDialog.Filter = "Excel (*.xls; *.xlsx) | *.xls; *.xlsx";
      // 
      // navRefresh
      // 
      this.navRefresh.Caption = "Aktualisieren";
      this.navRefresh.Name = "navRefresh";
      this.navRefresh.SmallImage = global::Impressio.Properties.Resources.refresh;
      this.navRefresh.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavRefreshLinkClicked);
      // 
      // PaperView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 461);
      this.Controls.Add(this.mainPanel);
      this.Controls.Add(this.navBarControl1);
      this.Name = "PaperView";
      this.ShowIcon = false;
      this.Load += new System.EventHandler(this.PaperViewLoad);
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraNavBar.NavBarControl navBarControl1;
    private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
    private DevExpress.XtraEditors.PanelControl mainPanel;
    private DevExpress.XtraNavBar.NavBarItem navImportExcel;
    private DevExpress.XtraNavBar.NavBarItem navDeletePaper;
    private System.Windows.Forms.OpenFileDialog openExcelDialog;
    private DevExpress.XtraNavBar.NavBarItem navRefresh;
  }
}