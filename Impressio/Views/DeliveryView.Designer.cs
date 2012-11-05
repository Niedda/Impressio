namespace Impressio.Views
{
  partial class DeliveryView
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
      this.mainPanel = new DevExpress.XtraEditors.PanelControl();
      this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
      this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
      this.navOverview = new DevExpress.XtraNavBar.NavBarItem();
      this.navOpen = new DevExpress.XtraNavBar.NavBarItem();
      this.navPrint = new DevExpress.XtraNavBar.NavBarItem();
      this.navDelete = new DevExpress.XtraNavBar.NavBarItem();
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // mainPanel
      // 
      this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mainPanel.Location = new System.Drawing.Point(164, 3);
      this.mainPanel.Name = "mainPanel";
      this.mainPanel.Size = new System.Drawing.Size(616, 454);
      this.mainPanel.TabIndex = 0;
      // 
      // navBarControl1
      // 
      this.navBarControl1.ActiveGroup = this.navBarGroup1;
      this.navBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
      this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navOpen,
            this.navPrint,
            this.navDelete,
            this.navOverview});
      this.navBarControl1.Location = new System.Drawing.Point(1, 3);
      this.navBarControl1.Name = "navBarControl1";
      this.navBarControl1.OptionsNavPane.ExpandedWidth = 157;
      this.navBarControl1.Size = new System.Drawing.Size(157, 454);
      this.navBarControl1.TabIndex = 1;
      this.navBarControl1.Text = "navBarControl1";
      // 
      // navBarGroup1
      // 
      this.navBarGroup1.Appearance.Font = new System.Drawing.Font("Frutiger LT Std 87 ExtraBlk Cn", 9.749999F, System.Drawing.FontStyle.Bold);
      this.navBarGroup1.Appearance.Options.UseFont = true;
      this.navBarGroup1.AppearanceBackground.Font = new System.Drawing.Font("Frutiger LT Std 87 ExtraBlk Cn", 9.749999F, System.Drawing.FontStyle.Bold);
      this.navBarGroup1.AppearanceBackground.Options.UseFont = true;
      this.navBarGroup1.AppearanceHotTracked.Font = new System.Drawing.Font("Frutiger LT Std 87 ExtraBlk Cn", 9.749999F, System.Drawing.FontStyle.Bold);
      this.navBarGroup1.AppearanceHotTracked.Options.UseFont = true;
      this.navBarGroup1.AppearancePressed.Font = new System.Drawing.Font("Frutiger LT Std 87 ExtraBlk Cn", 9.749999F, System.Drawing.FontStyle.Bold);
      this.navBarGroup1.AppearancePressed.Options.UseFont = true;
      this.navBarGroup1.Caption = "Lieferscheine";
      this.navBarGroup1.Expanded = true;
      this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navOverview),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navOpen),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPrint),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDelete)});
      this.navBarGroup1.Name = "navBarGroup1";
      // 
      // navOverview
      // 
      this.navOverview.Caption = "Übersicht";
      this.navOverview.Name = "navOverview";
      this.navOverview.SmallImage = global::Impressio.Properties.Resources.book;
      this.navOverview.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavOverviewLinkClicked);
      // 
      // navOpen
      // 
      this.navOpen.Caption = "Öffnen";
      this.navOpen.Name = "navOpen";
      this.navOpen.SmallImage = global::Impressio.Properties.Resources.map;
      this.navOpen.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavOpenLinkClicked);
      // 
      // navPrint
      // 
      this.navPrint.Caption = "Drucken";
      this.navPrint.Name = "navPrint";
      this.navPrint.SmallImage = global::Impressio.Properties.Resources.printer;
      this.navPrint.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavPrintLinkClicked);
      // 
      // navDelete
      // 
      this.navDelete.Caption = "Löschen";
      this.navDelete.Name = "navDelete";
      this.navDelete.SmallImage = global::Impressio.Properties.Resources.delete;
      // 
      // DeliveryView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 461);
      this.Controls.Add(this.navBarControl1);
      this.Controls.Add(this.mainPanel);
      this.MinimumSize = new System.Drawing.Size(800, 500);
      this.Name = "DeliveryView";
      this.ShowIcon = false;
      this.Load += new System.EventHandler(this.DeliveryViewLoad);
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.PanelControl mainPanel;
    private DevExpress.XtraNavBar.NavBarControl navBarControl1;
    private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
    private DevExpress.XtraNavBar.NavBarItem navOpen;
    private DevExpress.XtraNavBar.NavBarItem navPrint;
    private DevExpress.XtraNavBar.NavBarItem navDelete;
    private DevExpress.XtraNavBar.NavBarItem navOverview;
  }
}