namespace Impressio.Views
{
  partial class OrdersView
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
      this.navOpenOrder = new DevExpress.XtraNavBar.NavBarItem();
      this.navCopyOrder = new DevExpress.XtraNavBar.NavBarItem();
      this.navDeleteOrder = new DevExpress.XtraNavBar.NavBarItem();
      this.navPrintOverview = new DevExpress.XtraNavBar.NavBarItem();
      this.navPrintOffer = new DevExpress.XtraNavBar.NavBarItem();
      this.navRefresh = new DevExpress.XtraNavBar.NavBarItem();
      this.ordersControl = new Impressio.Controls.OrdersControl();
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // navBarControl1
      // 
      this.navBarControl1.ActiveGroup = this.navBarGroup1;
      this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
      this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
      this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navOpenOrder,
            this.navCopyOrder,
            this.navDeleteOrder,
            this.navPrintOverview,
            this.navPrintOffer,
            this.navRefresh});
      this.navBarControl1.Location = new System.Drawing.Point(0, 0);
      this.navBarControl1.Name = "navBarControl1";
      this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
      this.navBarControl1.Padding = new System.Windows.Forms.Padding(1);
      this.navBarControl1.Size = new System.Drawing.Size(180, 461);
      this.navBarControl1.TabIndex = 0;
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
      this.navBarGroup1.Caption = "Aufträge";
      this.navBarGroup1.Expanded = true;
      this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navOpenOrder),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navCopyOrder),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDeleteOrder),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPrintOverview),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPrintOffer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navRefresh)});
      this.navBarGroup1.Name = "navBarGroup1";
      // 
      // navOpenOrder
      // 
      this.navOpenOrder.Caption = "Auftrag öffnen";
      this.navOpenOrder.Name = "navOpenOrder";
      this.navOpenOrder.SmallImage = global::Impressio.Properties.Resources.map;
      this.navOpenOrder.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavOpenOrderLinkClicked);
      // 
      // navCopyOrder
      // 
      this.navCopyOrder.Caption = "Auftrag kopieren";
      this.navCopyOrder.Name = "navCopyOrder";
      this.navCopyOrder.SmallImage = global::Impressio.Properties.Resources.copy;
      this.navCopyOrder.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavCopyOrderLinkClicked);
      // 
      // navDeleteOrder
      // 
      this.navDeleteOrder.Caption = "Auftrag löschen";
      this.navDeleteOrder.Name = "navDeleteOrder";
      this.navDeleteOrder.SmallImage = global::Impressio.Properties.Resources.delete;
      this.navDeleteOrder.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavDeleteOrderLinkClicked);
      // 
      // navPrintOverview
      // 
      this.navPrintOverview.Caption = "Lauftasche drucken";
      this.navPrintOverview.Name = "navPrintOverview";
      this.navPrintOverview.SmallImage = global::Impressio.Properties.Resources.printer;
      this.navPrintOverview.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavPrintOverviewLinkClicked);
      // 
      // navPrintOffer
      // 
      this.navPrintOffer.Caption = "Offerte drucken";
      this.navPrintOffer.Name = "navPrintOffer";
      this.navPrintOffer.SmallImage = global::Impressio.Properties.Resources.printer;
      this.navPrintOffer.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavPrintOfferLinkClicked);
      // 
      // navRefresh
      // 
      this.navRefresh.Caption = "Aktualisieren";
      this.navRefresh.Name = "navRefresh";
      this.navRefresh.SmallImage = global::Impressio.Properties.Resources.refresh;
      this.navRefresh.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavRefreshLinkClicked);
      // 
      // ordersControl
      // 
      this.ordersControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ordersControl.Location = new System.Drawing.Point(180, 0);
      this.ordersControl.Name = "ordersControl";
      this.ordersControl.Size = new System.Drawing.Size(604, 461);
      this.ordersControl.TabIndex = 1;
      // 
      // OrdersView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 461);
      this.Controls.Add(this.ordersControl);
      this.Controls.Add(this.navBarControl1);
      this.MinimumSize = new System.Drawing.Size(800, 500);
      this.Name = "OrdersView";
      this.ShowIcon = false;
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraNavBar.NavBarControl navBarControl1;
    private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
    private DevExpress.XtraNavBar.NavBarItem navOpenOrder;
    private DevExpress.XtraNavBar.NavBarItem navCopyOrder;
    private DevExpress.XtraNavBar.NavBarItem navDeleteOrder;
    private DevExpress.XtraNavBar.NavBarItem navPrintOverview;
    private Controls.OrdersControl ordersControl;
    private DevExpress.XtraNavBar.NavBarItem navPrintOffer;
    private DevExpress.XtraNavBar.NavBarItem navRefresh;
  }
}