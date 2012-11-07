namespace Impressio.Views
{
  partial class OrderRibbonView
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderRibbonView));
      this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.openPosition = new DevExpress.XtraBars.BarButtonItem();
      this.description = new DevExpress.XtraBars.BarButtonItem();
      this.delivery = new DevExpress.XtraBars.BarButtonItem();
      this.deletePosition = new DevExpress.XtraBars.BarButtonItem();
      this.refresh = new DevExpress.XtraBars.BarButtonItem();
      this.printOrder = new DevExpress.XtraBars.BarButtonItem();
      this.printOffer = new DevExpress.XtraBars.BarButtonItem();
      this.ribbonPageOrder = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
      this.mainPanel = new DevExpress.XtraEditors.PanelControl();
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
      this.SuspendLayout();
      // 
      // ribbon
      // 
      this.ribbon.AllowMinimizeRibbon = false;
      this.ribbon.ApplicationButtonText = null;
      // 
      // 
      // 
      this.ribbon.ExpandCollapseItem.Id = 0;
      this.ribbon.ExpandCollapseItem.Name = "";
      this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.openPosition,
            this.description,
            this.delivery,
            this.deletePosition,
            this.refresh,
            this.printOrder,
            this.printOffer});
      this.ribbon.Location = new System.Drawing.Point(0, 0);
      this.ribbon.MaxItemId = 8;
      this.ribbon.Name = "ribbon";
      this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageOrder});
      this.ribbon.SelectedPage = this.ribbonPageOrder;
      this.ribbon.ShowToolbarCustomizeItem = false;
      this.ribbon.Size = new System.Drawing.Size(642, 149);
      this.ribbon.StatusBar = this.ribbonStatusBar;
      this.ribbon.Toolbar.ShowCustomizeItem = false;
      this.ribbon.SelectedPageChanged += new System.EventHandler(this.RibbonSelectedPageChanged);
      // 
      // openPosition
      // 
      this.openPosition.Caption = "Öffnen";
      this.openPosition.Id = 1;
      this.openPosition.LargeGlyph = global::Impressio.Properties.Resources.open;
      this.openPosition.LargeWidth = 80;
      this.openPosition.Name = "openPosition";
      this.openPosition.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OpenPositionItemClick);
      // 
      // description
      // 
      this.description.Caption = "Beschreibung";
      this.description.Id = 2;
      this.description.LargeGlyph = global::Impressio.Properties.Resources.description;
      this.description.LargeWidth = 80;
      this.description.Name = "description";
      this.description.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DescriptionItemClick);
      // 
      // delivery
      // 
      this.delivery.Caption = "Lieferscheine";
      this.delivery.Id = 3;
      this.delivery.LargeGlyph = global::Impressio.Properties.Resources.delivery;
      this.delivery.LargeWidth = 80;
      this.delivery.Name = "delivery";
      this.delivery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeliveryItemClick);
      // 
      // deletePosition
      // 
      this.deletePosition.Caption = "Löschen";
      this.deletePosition.Id = 4;
      this.deletePosition.LargeGlyph = global::Impressio.Properties.Resources.delete;
      this.deletePosition.LargeWidth = 80;
      this.deletePosition.Name = "deletePosition";
      this.deletePosition.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeletePositionItemClick);
      // 
      // refresh
      // 
      this.refresh.Caption = "Aktualisieren";
      this.refresh.Id = 5;
      this.refresh.LargeGlyph = global::Impressio.Properties.Resources.refresh;
      this.refresh.Name = "refresh";
      // 
      // printOrder
      // 
      this.printOrder.Caption = "Lauftasche";
      this.printOrder.Id = 6;
      this.printOrder.LargeGlyph = global::Impressio.Properties.Resources.printer2;
      this.printOrder.LargeWidth = 80;
      this.printOrder.Name = "printOrder";
      this.printOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PrintOrderItemClick);
      // 
      // printOffer
      // 
      this.printOffer.Caption = "Offerte";
      this.printOffer.Id = 7;
      this.printOffer.LargeGlyph = global::Impressio.Properties.Resources.printer2;
      this.printOffer.LargeWidth = 80;
      this.printOffer.Name = "printOffer";
      this.printOffer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PrintOfferItemClick);
      // 
      // ribbonPageOrder
      // 
      this.ribbonPageOrder.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
      this.ribbonPageOrder.Name = "ribbonPageOrder";
      this.ribbonPageOrder.Text = "Auftrag";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.AllowMinimize = false;
      this.ribbonPageGroup1.AllowTextClipping = false;
      this.ribbonPageGroup1.ItemLinks.Add(this.refresh);
      this.ribbonPageGroup1.ItemLinks.Add(this.openPosition);
      this.ribbonPageGroup1.ItemLinks.Add(this.description);
      this.ribbonPageGroup1.ItemLinks.Add(this.delivery);
      this.ribbonPageGroup1.ItemLinks.Add(this.deletePosition);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup1.ShowCaptionButton = false;
      this.ribbonPageGroup1.Text = "Position";
      // 
      // ribbonPageGroup2
      // 
      this.ribbonPageGroup2.AllowMinimize = false;
      this.ribbonPageGroup2.AllowTextClipping = false;
      this.ribbonPageGroup2.ItemLinks.Add(this.printOrder);
      this.ribbonPageGroup2.ItemLinks.Add(this.printOffer);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup2.ShowCaptionButton = false;
      this.ribbonPageGroup2.Text = "Dokumente";
      // 
      // ribbonStatusBar
      // 
      this.ribbonStatusBar.Location = new System.Drawing.Point(0, 426);
      this.ribbonStatusBar.Name = "ribbonStatusBar";
      this.ribbonStatusBar.Ribbon = this.ribbon;
      this.ribbonStatusBar.Size = new System.Drawing.Size(642, 23);
      // 
      // mainPanel
      // 
      this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainPanel.Location = new System.Drawing.Point(0, 149);
      this.mainPanel.Name = "mainPanel";
      this.mainPanel.Size = new System.Drawing.Size(642, 277);
      this.mainPanel.TabIndex = 2;
      // 
      // OrderRibbonView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(642, 449);
      this.Controls.Add(this.mainPanel);
      this.Controls.Add(this.ribbonStatusBar);
      this.Controls.Add(this.ribbon);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "OrderRibbonView";
      this.Ribbon = this.ribbon;
      this.StatusBar = this.ribbonStatusBar;
      this.Text = "Impressio Auftragsdetails";
      this.Load += new System.EventHandler(this.OrderRibbonViewLoad);
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageOrder;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
    private DevExpress.XtraBars.BarButtonItem openPosition;
    private DevExpress.XtraBars.BarButtonItem description;
    private DevExpress.XtraBars.BarButtonItem delivery;
    private DevExpress.XtraBars.BarButtonItem deletePosition;
    private DevExpress.XtraBars.BarButtonItem refresh;
    private DevExpress.XtraBars.BarButtonItem printOrder;
    private DevExpress.XtraBars.BarButtonItem printOffer;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    private DevExpress.XtraEditors.PanelControl mainPanel;
  }
}