namespace Impressio.Views
{
  partial class MainViewRibbon
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainViewRibbon));
      this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.openOrder = new DevExpress.XtraBars.BarButtonItem();
      this.copyOrder = new DevExpress.XtraBars.BarButtonItem();
      this.deleteOrder = new DevExpress.XtraBars.BarButtonItem();
      this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
      this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
      this.printOrder = new DevExpress.XtraBars.BarButtonItem();
      this.printOffer = new DevExpress.XtraBars.BarButtonItem();
      this.refreshOrder = new DevExpress.XtraBars.BarButtonItem();
      this.showCompanies = new DevExpress.XtraBars.BarButtonItem();
      this.showAddress = new DevExpress.XtraBars.BarButtonItem();
      this.showPerson = new DevExpress.XtraBars.BarButtonItem();
      this.deleteEntry = new DevExpress.XtraBars.BarButtonItem();
      this.properties = new DevExpress.XtraBars.BarButtonItem();
      this.predefinedPositions = new DevExpress.XtraBars.BarButtonItem();
      this.predefinedDescription = new DevExpress.XtraBars.BarButtonItem();
      this.papers = new DevExpress.XtraBars.BarButtonItem();
      this.machines = new DevExpress.XtraBars.BarButtonItem();
      this.clickCosts = new DevExpress.XtraBars.BarButtonItem();
      this.genders = new DevExpress.XtraBars.BarButtonItem();
      this.state = new DevExpress.XtraBars.BarButtonItem();
      this.ribbonPageOrder = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPageCustomer = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPageProperties = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
      this.mainPanel = new DevExpress.XtraEditors.PanelControl();
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
      this.SuspendLayout();
      // 
      // ribbon
      // 
      this.ribbon.AllowTrimPageText = false;
      this.ribbon.ApplicationButtonText = null;
      // 
      // 
      // 
      this.ribbon.ExpandCollapseItem.Id = 0;
      this.ribbon.ExpandCollapseItem.Name = "";
      this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.openOrder,
            this.copyOrder,
            this.deleteOrder,
            this.barButtonItem5,
            this.barButtonItem6,
            this.printOrder,
            this.printOffer,
            this.refreshOrder,
            this.showCompanies,
            this.showAddress,
            this.showPerson,
            this.deleteEntry,
            this.properties,
            this.predefinedPositions,
            this.predefinedDescription,
            this.papers,
            this.machines,
            this.clickCosts,
            this.genders,
            this.state});
      this.ribbon.Location = new System.Drawing.Point(0, 0);
      this.ribbon.MaxItemId = 23;
      this.ribbon.Name = "ribbon";
      this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageOrder,
            this.ribbonPageCustomer,
            this.ribbonPageProperties});
      this.ribbon.SelectedPage = this.ribbonPageOrder;
      this.ribbon.ShowToolbarCustomizeItem = false;
      this.ribbon.Size = new System.Drawing.Size(694, 145);
      this.ribbon.StatusBar = this.ribbonStatusBar;
      this.ribbon.Toolbar.ShowCustomizeItem = false;
      this.ribbon.SelectedPageChanged += new System.EventHandler(this.RibbonSelectedPageChanged);
      // 
      // openOrder
      // 
      this.openOrder.Caption = "Öffnen";
      this.openOrder.Id = 2;
      this.openOrder.LargeGlyph = global::Impressio.Properties.Resources.open;
      this.openOrder.LargeWidth = 80;
      this.openOrder.Name = "openOrder";
      this.openOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OpenOrderItemClick);
      // 
      // copyOrder
      // 
      this.copyOrder.Caption = "Kopieren";
      this.copyOrder.Id = 3;
      this.copyOrder.LargeGlyph = global::Impressio.Properties.Resources.copy;
      this.copyOrder.LargeWidth = 80;
      this.copyOrder.Name = "copyOrder";
      // 
      // deleteOrder
      // 
      this.deleteOrder.Caption = "Löschen";
      this.deleteOrder.Id = 4;
      this.deleteOrder.LargeGlyph = global::Impressio.Properties.Resources.delete;
      this.deleteOrder.LargeWidth = 80;
      this.deleteOrder.Name = "deleteOrder";
      this.deleteOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteOrderItemClick);
      // 
      // barButtonItem5
      // 
      this.barButtonItem5.Caption = "Lauftasche drucken";
      this.barButtonItem5.Id = 6;
      this.barButtonItem5.LargeGlyph = global::Impressio.Properties.Resources.printglyph;
      this.barButtonItem5.Name = "barButtonItem5";
      // 
      // barButtonItem6
      // 
      this.barButtonItem6.Caption = "barButtonItem6";
      this.barButtonItem6.Id = 7;
      this.barButtonItem6.LargeGlyph = global::Impressio.Properties.Resources.refresh;
      this.barButtonItem6.Name = "barButtonItem6";
      // 
      // printOrder
      // 
      this.printOrder.Caption = "Lauftasche";
      this.printOrder.Id = 8;
      this.printOrder.LargeGlyph = global::Impressio.Properties.Resources.printglyph;
      this.printOrder.LargeWidth = 80;
      this.printOrder.Name = "printOrder";
      this.printOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PrintOrderItemClick);
      // 
      // printOffer
      // 
      this.printOffer.Caption = "Offerte";
      this.printOffer.Id = 9;
      this.printOffer.LargeGlyph = global::Impressio.Properties.Resources.printglyph;
      this.printOffer.LargeWidth = 80;
      this.printOffer.Name = "printOffer";
      this.printOffer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PrintOfferItemClick);
      // 
      // refreshOrder
      // 
      this.refreshOrder.Caption = "Aktualisieren";
      this.refreshOrder.Id = 10;
      this.refreshOrder.LargeGlyph = global::Impressio.Properties.Resources.refresh;
      this.refreshOrder.LargeWidth = 80;
      this.refreshOrder.Name = "refreshOrder";
      // 
      // showCompanies
      // 
      this.showCompanies.Caption = "Firmen";
      this.showCompanies.Id = 11;
      this.showCompanies.LargeGlyph = global::Impressio.Properties.Resources.company;
      this.showCompanies.LargeWidth = 80;
      this.showCompanies.Name = "showCompanies";
      this.showCompanies.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ShowCompaniesItemClick);
      // 
      // showAddress
      // 
      this.showAddress.Caption = "Adressen";
      this.showAddress.Id = 12;
      this.showAddress.LargeGlyph = global::Impressio.Properties.Resources.address;
      this.showAddress.LargeWidth = 80;
      this.showAddress.Name = "showAddress";
      this.showAddress.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ShowAddressItemClick);
      // 
      // showPerson
      // 
      this.showPerson.Caption = "Personen ";
      this.showPerson.Id = 13;
      this.showPerson.LargeGlyph = global::Impressio.Properties.Resources.person1;
      this.showPerson.LargeWidth = 80;
      this.showPerson.Name = "showPerson";
      this.showPerson.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ShowPersonItemClick);
      // 
      // deleteEntry
      // 
      this.deleteEntry.Caption = "Löschen";
      this.deleteEntry.Id = 14;
      this.deleteEntry.LargeGlyph = global::Impressio.Properties.Resources.delete;
      this.deleteEntry.LargeWidth = 80;
      this.deleteEntry.Name = "deleteEntry";
      this.deleteEntry.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteEntryItemClick);
      // 
      // properties
      // 
      this.properties.Caption = "Einstellungen";
      this.properties.Id = 15;
      this.properties.LargeGlyph = global::Impressio.Properties.Resources.properties;
      this.properties.LargeWidth = 80;
      this.properties.Name = "properties";
      // 
      // predefinedPositions
      // 
      this.predefinedPositions.Caption = "Positionen";
      this.predefinedPositions.Id = 16;
      this.predefinedPositions.LargeGlyph = global::Impressio.Properties.Resources.position;
      this.predefinedPositions.LargeWidth = 80;
      this.predefinedPositions.Name = "predefinedPositions";
      this.predefinedPositions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PredefinedPositionsItemClick);
      // 
      // predefinedDescription
      // 
      this.predefinedDescription.Caption = "Beschreibungen";
      this.predefinedDescription.Id = 17;
      this.predefinedDescription.LargeGlyph = global::Impressio.Properties.Resources.description;
      this.predefinedDescription.LargeWidth = 90;
      this.predefinedDescription.Name = "predefinedDescription";
      this.predefinedDescription.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PredefinedDescriptionItemClick);
      // 
      // papers
      // 
      this.papers.Caption = "Papiere";
      this.papers.Id = 18;
      this.papers.LargeGlyph = global::Impressio.Properties.Resources.paperplane;
      this.papers.LargeWidth = 80;
      this.papers.Name = "papers";
      this.papers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PapersItemClick);
      // 
      // machines
      // 
      this.machines.Caption = "Druckmaschinen";
      this.machines.Id = 19;
      this.machines.LargeGlyph = global::Impressio.Properties.Resources.offsetprint;
      this.machines.LargeWidth = 90;
      this.machines.Name = "machines";
      this.machines.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MachinesItemClick);
      // 
      // clickCosts
      // 
      this.clickCosts.Caption = "Klickkosten";
      this.clickCosts.Id = 20;
      this.clickCosts.LargeGlyph = global::Impressio.Properties.Resources.coins;
      this.clickCosts.LargeWidth = 80;
      this.clickCosts.Name = "clickCosts";
      this.clickCosts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClickCostsItemClick);
      // 
      // genders
      // 
      this.genders.Caption = "Anreden";
      this.genders.Id = 21;
      this.genders.LargeGlyph = global::Impressio.Properties.Resources.gender1;
      this.genders.LargeWidth = 80;
      this.genders.Name = "genders";
      this.genders.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GendersItemClick);
      // 
      // state
      // 
      this.state.Caption = "Auftragsstatus";
      this.state.Id = 22;
      this.state.LargeGlyph = global::Impressio.Properties.Resources.state;
      this.state.Name = "state";
      this.state.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.StateItemClick);
      // 
      // ribbonPageOrder
      // 
      this.ribbonPageOrder.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
      this.ribbonPageOrder.Name = "ribbonPageOrder";
      this.ribbonPageOrder.Text = "Aufträge";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.AllowMinimize = false;
      this.ribbonPageGroup1.ItemLinks.Add(this.refreshOrder);
      this.ribbonPageGroup1.ItemLinks.Add(this.openOrder);
      this.ribbonPageGroup1.ItemLinks.Add(this.copyOrder);
      this.ribbonPageGroup1.ItemLinks.Add(this.deleteOrder);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup1.ShowCaptionButton = false;
      this.ribbonPageGroup1.Text = "Aufträge";
      // 
      // ribbonPageGroup2
      // 
      this.ribbonPageGroup2.AllowMinimize = false;
      this.ribbonPageGroup2.ItemLinks.Add(this.printOrder);
      this.ribbonPageGroup2.ItemLinks.Add(this.printOffer);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup2.ShowCaptionButton = false;
      this.ribbonPageGroup2.Text = "Dokumente";
      // 
      // ribbonPageCustomer
      // 
      this.ribbonPageCustomer.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
      this.ribbonPageCustomer.Name = "ribbonPageCustomer";
      this.ribbonPageCustomer.Text = "Kundenverwaltung";
      // 
      // ribbonPageGroup3
      // 
      this.ribbonPageGroup3.AllowMinimize = false;
      this.ribbonPageGroup3.AllowTextClipping = false;
      this.ribbonPageGroup3.ItemLinks.Add(this.showCompanies);
      this.ribbonPageGroup3.ItemLinks.Add(this.showAddress);
      this.ribbonPageGroup3.ItemLinks.Add(this.showPerson);
      this.ribbonPageGroup3.ItemLinks.Add(this.deleteEntry);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup3.ShowCaptionButton = false;
      this.ribbonPageGroup3.Text = "Kunden";
      // 
      // ribbonPageProperties
      // 
      this.ribbonPageProperties.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
      this.ribbonPageProperties.Name = "ribbonPageProperties";
      this.ribbonPageProperties.Text = "Voreinstellungen";
      // 
      // ribbonPageGroup4
      // 
      this.ribbonPageGroup4.AllowMinimize = false;
      this.ribbonPageGroup4.AllowTextClipping = false;
      this.ribbonPageGroup4.ItemLinks.Add(this.properties);
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup4.ShowCaptionButton = false;
      this.ribbonPageGroup4.Text = "Einstellungen";
      // 
      // ribbonPageGroup5
      // 
      this.ribbonPageGroup5.AllowMinimize = false;
      this.ribbonPageGroup5.AllowTextClipping = false;
      this.ribbonPageGroup5.ItemLinks.Add(this.predefinedPositions);
      this.ribbonPageGroup5.ItemLinks.Add(this.predefinedDescription);
      this.ribbonPageGroup5.Name = "ribbonPageGroup5";
      this.ribbonPageGroup5.ShowCaptionButton = false;
      this.ribbonPageGroup5.Text = "Vordefiniert";
      // 
      // ribbonPageGroup6
      // 
      this.ribbonPageGroup6.AllowMinimize = false;
      this.ribbonPageGroup6.AllowTextClipping = false;
      this.ribbonPageGroup6.ItemLinks.Add(this.papers);
      this.ribbonPageGroup6.ItemLinks.Add(this.machines);
      this.ribbonPageGroup6.ItemLinks.Add(this.clickCosts);
      this.ribbonPageGroup6.ItemLinks.Add(this.genders);
      this.ribbonPageGroup6.ItemLinks.Add(this.state);
      this.ribbonPageGroup6.Name = "ribbonPageGroup6";
      this.ribbonPageGroup6.ShowCaptionButton = false;
      this.ribbonPageGroup6.Text = "Grundeinstellungen verwalten";
      // 
      // ribbonStatusBar
      // 
      this.ribbonStatusBar.Location = new System.Drawing.Point(0, 348);
      this.ribbonStatusBar.Name = "ribbonStatusBar";
      this.ribbonStatusBar.Ribbon = this.ribbon;
      this.ribbonStatusBar.Size = new System.Drawing.Size(694, 31);
      // 
      // mainPanel
      // 
      this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainPanel.Location = new System.Drawing.Point(0, 145);
      this.mainPanel.Name = "mainPanel";
      this.mainPanel.Size = new System.Drawing.Size(694, 203);
      this.mainPanel.TabIndex = 2;
      // 
      // MainViewRibbon
      // 
      this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(694, 379);
      this.Controls.Add(this.mainPanel);
      this.Controls.Add(this.ribbonStatusBar);
      this.Controls.Add(this.ribbon);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(696, 380);
      this.Name = "MainViewRibbon";
      this.Ribbon = this.ribbon;
      this.StatusBar = this.ribbonStatusBar;
      this.Text = "Impressio";
      this.Load += new System.EventHandler(this.MainViewRibbonLoad);
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageOrder;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
    private DevExpress.XtraBars.BarButtonItem openOrder;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCustomer;
    private DevExpress.XtraBars.BarButtonItem copyOrder;
    private DevExpress.XtraBars.BarButtonItem deleteOrder;
    private DevExpress.XtraBars.BarButtonItem barButtonItem5;
    private DevExpress.XtraBars.BarButtonItem barButtonItem6;
    private DevExpress.XtraBars.BarButtonItem printOrder;
    private DevExpress.XtraBars.BarButtonItem printOffer;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    private DevExpress.XtraBars.BarButtonItem refreshOrder;
    private DevExpress.XtraBars.BarButtonItem showCompanies;
    private DevExpress.XtraBars.BarButtonItem showAddress;
    private DevExpress.XtraBars.BarButtonItem showPerson;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    private DevExpress.XtraBars.BarButtonItem deleteEntry;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageProperties;
    private DevExpress.XtraBars.BarButtonItem properties;
    private DevExpress.XtraBars.BarButtonItem predefinedPositions;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    private DevExpress.XtraBars.BarButtonItem predefinedDescription;
    private DevExpress.XtraBars.BarButtonItem papers;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    private DevExpress.XtraBars.BarButtonItem machines;
    private DevExpress.XtraBars.BarButtonItem clickCosts;
    private DevExpress.XtraBars.BarButtonItem genders;
    private DevExpress.XtraBars.BarButtonItem state;
    public DevExpress.XtraEditors.PanelControl mainPanel;
  }
}