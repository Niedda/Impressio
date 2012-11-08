namespace Impressio.Views
{
  partial class PositionView
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositionView));
      this.mainPanel = new DevExpress.XtraEditors.PanelControl();
      this.positionControl = new Impressio.Controls.PositionControl();
      this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
      this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
      this.navOpenPosition = new DevExpress.XtraNavBar.NavBarItem();
      this.navOpenDescription = new DevExpress.XtraNavBar.NavBarItem();
      this.navOpenDelivery = new DevExpress.XtraNavBar.NavBarItem();
      this.navDeletePosition = new DevExpress.XtraNavBar.NavBarItem();
      this.navRefreshPosition = new DevExpress.XtraNavBar.NavBarItem();
      this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
      this.navPrintOffer = new DevExpress.XtraNavBar.NavBarItem();
      this.navPrintOrder = new DevExpress.XtraNavBar.NavBarItem();
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
      this.mainPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // mainPanel
      // 
      this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mainPanel.Controls.Add(this.positionControl);
      this.mainPanel.Location = new System.Drawing.Point(184, 3);
      this.mainPanel.Name = "mainPanel";
      this.mainPanel.Padding = new System.Windows.Forms.Padding(1);
      this.mainPanel.Size = new System.Drawing.Size(771, 456);
      this.mainPanel.TabIndex = 1;
      // 
      // positionControl
      // 
      this.positionControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.positionControl.Location = new System.Drawing.Point(3, 3);
      this.positionControl.Name = "positionControl";
      this.positionControl.Size = new System.Drawing.Size(765, 450);
      this.positionControl.TabIndex = 0;
      // 
      // navBarControl1
      // 
      this.navBarControl1.ActiveGroup = this.navBarGroup1;
      this.navBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
      this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navOpenPosition,
            this.navOpenDescription,
            this.navOpenDelivery,
            this.navDeletePosition,
            this.navPrintOrder,
            this.navRefreshPosition,
            this.navPrintOffer});
      this.navBarControl1.Location = new System.Drawing.Point(2, 3);
      this.navBarControl1.Name = "navBarControl1";
      this.navBarControl1.OptionsNavPane.ExpandedWidth = 176;
      this.navBarControl1.Padding = new System.Windows.Forms.Padding(1);
      this.navBarControl1.Size = new System.Drawing.Size(176, 456);
      this.navBarControl1.TabIndex = 2;
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
      this.navBarGroup1.Caption = "Auftrag bearbeiten";
      this.navBarGroup1.Expanded = true;
      this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navOpenPosition),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navOpenDescription),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navOpenDelivery),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDeletePosition),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navRefreshPosition)});
      this.navBarGroup1.Name = "navBarGroup1";
      // 
      // navOpenPosition
      // 
      this.navOpenPosition.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.navOpenPosition.Appearance.Options.UseFont = true;
      this.navOpenPosition.Caption = "Position öffnen";
      this.navOpenPosition.Name = "navOpenPosition";
      this.navOpenPosition.SmallImage = global::Impressio.Properties.Resources.open;
      this.navOpenPosition.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavOpenPositionLinkClicked);
      // 
      // navOpenDescription
      // 
      this.navOpenDescription.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.navOpenDescription.Appearance.Options.UseFont = true;
      this.navOpenDescription.Caption = "Beschreibung öffnen";
      this.navOpenDescription.Name = "navOpenDescription";
      this.navOpenDescription.SmallImage = global::Impressio.Properties.Resources.open;
      this.navOpenDescription.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavOpenDescriptionLinkClicked);
      // 
      // navOpenDelivery
      // 
      this.navOpenDelivery.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.navOpenDelivery.Appearance.Options.UseFont = true;
      this.navOpenDelivery.Caption = "Lieferscheine öffnen";
      this.navOpenDelivery.Name = "navOpenDelivery";
      this.navOpenDelivery.SmallImage = global::Impressio.Properties.Resources.delivery;
      this.navOpenDelivery.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavOpenDeliveryLinkClicked);
      // 
      // navDeletePosition
      // 
      this.navDeletePosition.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.navDeletePosition.Appearance.Options.UseFont = true;
      this.navDeletePosition.Caption = "Position löschen";
      this.navDeletePosition.Name = "navDeletePosition";
      this.navDeletePosition.SmallImage = global::Impressio.Properties.Resources.delete;
      this.navDeletePosition.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavDeletePositionLinkClicked);
      // 
      // navRefreshPosition
      // 
      this.navRefreshPosition.Caption = "Aktualisieren";
      this.navRefreshPosition.Name = "navRefreshPosition";
      this.navRefreshPosition.SmallImage = global::Impressio.Properties.Resources.refresh;
      this.navRefreshPosition.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavRefreshPositionLinkClicked);
      // 
      // navBarGroup2
      // 
      this.navBarGroup2.Appearance.Font = new System.Drawing.Font("Frutiger LT Std 87 ExtraBlk Cn", 9.749999F, System.Drawing.FontStyle.Bold);
      this.navBarGroup2.Appearance.Options.UseFont = true;
      this.navBarGroup2.AppearanceBackground.Font = new System.Drawing.Font("Frutiger LT Std 87 ExtraBlk Cn", 9.749999F, System.Drawing.FontStyle.Bold);
      this.navBarGroup2.AppearanceBackground.Options.UseFont = true;
      this.navBarGroup2.AppearanceHotTracked.Font = new System.Drawing.Font("Frutiger LT Std 87 ExtraBlk Cn", 9.749999F, System.Drawing.FontStyle.Bold);
      this.navBarGroup2.AppearanceHotTracked.Options.UseFont = true;
      this.navBarGroup2.AppearancePressed.Font = new System.Drawing.Font("Frutiger LT Std 87 ExtraBlk Cn", 9.749999F, System.Drawing.FontStyle.Bold);
      this.navBarGroup2.AppearancePressed.Options.UseFont = true;
      this.navBarGroup2.Caption = "Dokumentausgabe";
      this.navBarGroup2.Expanded = true;
      this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPrintOffer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPrintOrder)});
      this.navBarGroup2.Name = "navBarGroup2";
      // 
      // navPrintOffer
      // 
      this.navPrintOffer.Caption = "Offerte drucken";
      this.navPrintOffer.Name = "navPrintOffer";
      this.navPrintOffer.SmallImage = global::Impressio.Properties.Resources.printglyph;
      this.navPrintOffer.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavPrintOfferLinkClicked);
      // 
      // navPrintOrder
      // 
      this.navPrintOrder.Caption = "Lauftasche drucken";
      this.navPrintOrder.Name = "navPrintOrder";
      this.navPrintOrder.SmallImage = global::Impressio.Properties.Resources.printglyph;
      this.navPrintOrder.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavPrintOrderLinkClicked);
      // 
      // PositionView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(958, 461);
      this.Controls.Add(this.navBarControl1);
      this.Controls.Add(this.mainPanel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(950, 500);
      this.Name = "PositionView";
      this.ShowIcon = false;
      this.Load += new System.EventHandler(this.PositionViewLoad);
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
      this.mainPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    public DevExpress.XtraEditors.PanelControl mainPanel;
    private DevExpress.XtraNavBar.NavBarControl navBarControl1;
    private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
    private DevExpress.XtraNavBar.NavBarItem navOpenPosition;
    private DevExpress.XtraNavBar.NavBarItem navOpenDescription;
    private DevExpress.XtraNavBar.NavBarItem navOpenDelivery;
    private DevExpress.XtraNavBar.NavBarItem navDeletePosition;
    private DevExpress.XtraNavBar.NavBarItem navPrintOrder;
    private DevExpress.XtraNavBar.NavBarItem navRefreshPosition;
    private DevExpress.XtraNavBar.NavBarItem navPrintOffer;
    private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
    private Controls.PositionControl positionControl;
  }
}