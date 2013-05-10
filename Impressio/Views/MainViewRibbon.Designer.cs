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
      this.editOffer = new DevExpress.XtraBars.BarButtonItem();
      this.editOrder = new DevExpress.XtraBars.BarButtonItem();
      this.editDelivery = new DevExpress.XtraBars.BarButtonItem();
      this.predefinedOrder = new DevExpress.XtraBars.BarButtonItem();
      this.createOrderWizard = new DevExpress.XtraBars.BarButtonItem();
      this.deleteCustomer = new DevExpress.XtraBars.BarButtonItem();
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
      this.paperSizes = new DevExpress.XtraBars.BarButtonItem();
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
      this.SuspendLayout();
      // 
      // ribbon
      // 
      this.ribbon.AllowTrimPageText = false;
      this.ribbon.ApplicationButtonText = null;
      this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
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
            this.state,
            this.editOffer,
            this.editOrder,
            this.editDelivery,
            this.predefinedOrder,
            this.createOrderWizard,
            this.deleteCustomer,
            this.paperSizes});
      this.ribbon.Location = new System.Drawing.Point(0, 0);
      this.ribbon.MaxItemId = 31;
      this.ribbon.Name = "ribbon";
      this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageOrder,
            this.ribbonPageCustomer,
            this.ribbonPageProperties});
      this.ribbon.SelectedPage = this.ribbonPageProperties;
      this.ribbon.ShowToolbarCustomizeItem = false;
      this.ribbon.Size = new System.Drawing.Size(825, 145);
      this.ribbon.StatusBar = this.ribbonStatusBar;
      this.ribbon.Toolbar.ShowCustomizeItem = false;
      this.ribbon.SelectedPageChanging += new DevExpress.XtraBars.Ribbon.RibbonPageChangingEventHandler(this.RibbonSelectedPageChanging);
      this.ribbon.SelectedPageChanged += new System.EventHandler(this.RibbonSelectedPageChanged);
      // 
      // openOrder
      // 
      this.openOrder.Caption = "Öffnen";
      this.openOrder.Id = 2;
      this.openOrder.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.openOrder.LargeGlyph = global::Impressio.Properties.Resources.open;
      this.openOrder.LargeWidth = 80;
      this.openOrder.Name = "openOrder";
      this.openOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OpenOrderItemClick);
      // 
      // copyOrder
      // 
      this.copyOrder.Caption = "Kopieren";
      this.copyOrder.Id = 3;
      this.copyOrder.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.copyOrder.LargeGlyph = global::Impressio.Properties.Resources.copy;
      this.copyOrder.LargeWidth = 80;
      this.copyOrder.Name = "copyOrder";
      this.copyOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CopyOrderItemClick);
      // 
      // deleteOrder
      // 
      this.deleteOrder.Caption = "Löschen";
      this.deleteOrder.Id = 4;
      this.deleteOrder.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
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
      this.barButtonItem6.LargeGlyph = global::Impressio.Properties.Resources.printglyph;
      this.barButtonItem6.Name = "barButtonItem6";
      // 
      // printOrder
      // 
      this.printOrder.Caption = "Lauftasche";
      this.printOrder.Id = 8;
      this.printOrder.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.printOrder.LargeGlyph = global::Impressio.Properties.Resources.printglyph;
      this.printOrder.LargeWidth = 80;
      this.printOrder.Name = "printOrder";
      this.printOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PrintOrderItemClick);
      // 
      // printOffer
      // 
      this.printOffer.Caption = "Offerte";
      this.printOffer.Id = 9;
      this.printOffer.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.printOffer.LargeGlyph = global::Impressio.Properties.Resources.printglyph;
      this.printOffer.LargeWidth = 80;
      this.printOffer.Name = "printOffer";
      this.printOffer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PrintOfferItemClick);
      // 
      // refreshOrder
      // 
      this.refreshOrder.Caption = "Aktualisieren";
      this.refreshOrder.Id = 10;
      this.refreshOrder.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.refreshOrder.LargeGlyph = global::Impressio.Properties.Resources.refresh;
      this.refreshOrder.LargeWidth = 80;
      this.refreshOrder.Name = "refreshOrder";
      this.refreshOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RefreshOrderItemClick);
      // 
      // showCompanies
      // 
      this.showCompanies.Caption = "Firmen";
      this.showCompanies.Id = 11;
      this.showCompanies.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.showCompanies.LargeGlyph = global::Impressio.Properties.Resources.company;
      this.showCompanies.LargeWidth = 80;
      this.showCompanies.Name = "showCompanies";
      // 
      // showAddress
      // 
      this.showAddress.Caption = "Adressen";
      this.showAddress.Id = 12;
      this.showAddress.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.showAddress.LargeGlyph = global::Impressio.Properties.Resources.address;
      this.showAddress.LargeWidth = 80;
      this.showAddress.Name = "showAddress";
      // 
      // showPerson
      // 
      this.showPerson.Caption = "Personen ";
      this.showPerson.Id = 13;
      this.showPerson.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.showPerson.LargeGlyph = global::Impressio.Properties.Resources.person;
      this.showPerson.LargeWidth = 80;
      this.showPerson.Name = "showPerson";
      // 
      // deleteEntry
      // 
      this.deleteEntry.Caption = "Löschen";
      this.deleteEntry.Id = 14;
      this.deleteEntry.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.deleteEntry.LargeGlyph = global::Impressio.Properties.Resources.delete;
      this.deleteEntry.LargeWidth = 80;
      this.deleteEntry.Name = "deleteEntry";
      // 
      // properties
      // 
      this.properties.Caption = "Einstellungen";
      this.properties.Id = 15;
      this.properties.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.properties.LargeGlyph = global::Impressio.Properties.Resources.properties;
      this.properties.LargeWidth = 80;
      this.properties.Name = "properties";
      // 
      // predefinedPositions
      // 
      this.predefinedPositions.Caption = "Positionen";
      this.predefinedPositions.Id = 16;
      this.predefinedPositions.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.predefinedPositions.LargeGlyph = global::Impressio.Properties.Resources.position;
      this.predefinedPositions.LargeWidth = 80;
      this.predefinedPositions.Name = "predefinedPositions";
      // 
      // predefinedDescription
      // 
      this.predefinedDescription.Caption = "Beschreibungen";
      this.predefinedDescription.Id = 17;
      this.predefinedDescription.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.predefinedDescription.LargeGlyph = global::Impressio.Properties.Resources.description;
      this.predefinedDescription.LargeWidth = 90;
      this.predefinedDescription.Name = "predefinedDescription";
      // 
      // papers
      // 
      this.papers.Caption = "Papiere";
      this.papers.Id = 18;
      this.papers.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.papers.LargeGlyph = global::Impressio.Properties.Resources.paperplane;
      this.papers.LargeWidth = 80;
      this.papers.Name = "papers";
      // 
      // machines
      // 
      this.machines.Caption = "Druckmaschinen";
      this.machines.Id = 19;
      this.machines.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.machines.LargeGlyph = global::Impressio.Properties.Resources.offsetprint;
      this.machines.LargeWidth = 90;
      this.machines.Name = "machines";
      // 
      // clickCosts
      // 
      this.clickCosts.Caption = "Klickkosten";
      this.clickCosts.Id = 20;
      this.clickCosts.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.clickCosts.LargeGlyph = global::Impressio.Properties.Resources.coins;
      this.clickCosts.LargeWidth = 80;
      this.clickCosts.Name = "clickCosts";
      // 
      // genders
      // 
      this.genders.Caption = "Anreden";
      this.genders.Id = 21;
      this.genders.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.genders.LargeGlyph = global::Impressio.Properties.Resources.gender;
      this.genders.LargeWidth = 80;
      this.genders.Name = "genders";
      // 
      // state
      // 
      this.state.Caption = "Auftragsstatus";
      this.state.Id = 22;
      this.state.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.state.LargeGlyph = global::Impressio.Properties.Resources.state;
      this.state.LargeWidth = 90;
      this.state.Name = "state";
      // 
      // editOffer
      // 
      this.editOffer.Caption = "Offerte bearbeiten";
      this.editOffer.Id = 23;
      this.editOffer.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.editOffer.LargeGlyph = global::Impressio.Properties.Resources.printglyph;
      this.editOffer.LargeWidth = 80;
      this.editOffer.Name = "editOffer";
      // 
      // editOrder
      // 
      this.editOrder.Caption = "Lauftasche bearbeiten";
      this.editOrder.Id = 24;
      this.editOrder.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.editOrder.LargeGlyph = global::Impressio.Properties.Resources.printglyph;
      this.editOrder.LargeWidth = 80;
      this.editOrder.Name = "editOrder";
      // 
      // editDelivery
      // 
      this.editDelivery.Caption = "Lieferschein bearbeiten";
      this.editDelivery.Id = 25;
      this.editDelivery.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
      this.editDelivery.LargeGlyph = global::Impressio.Properties.Resources.printglyph;
      this.editDelivery.LargeWidth = 80;
      this.editDelivery.Name = "editDelivery";
      // 
      // predefinedOrder
      // 
      this.predefinedOrder.Caption = "Aufträge";
      this.predefinedOrder.Id = 27;
      this.predefinedOrder.LargeGlyph = global::Impressio.Properties.Resources.order;
      this.predefinedOrder.LargeWidth = 80;
      this.predefinedOrder.Name = "predefinedOrder";
      // 
      // createOrderWizard
      // 
      this.createOrderWizard.Caption = "Wizard";
      this.createOrderWizard.Id = 28;
      this.createOrderWizard.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("createOrderWizard.LargeGlyph")));
      this.createOrderWizard.LargeWidth = 80;
      this.createOrderWizard.Name = "createOrderWizard";
      this.createOrderWizard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CreateOrderWizardItemClick);
      // 
      // deleteCustomer
      // 
      this.deleteCustomer.Caption = "Löschen";
      this.deleteCustomer.Id = 29;
      this.deleteCustomer.LargeGlyph = global::Impressio.Properties.Resources.delete;
      this.deleteCustomer.LargeWidth = 80;
      this.deleteCustomer.Name = "deleteCustomer";
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
      this.ribbonPageGroup1.ItemLinks.Add(this.deleteOrder);
      this.ribbonPageGroup1.ItemLinks.Add(this.copyOrder);
      this.ribbonPageGroup1.ItemLinks.Add(this.createOrderWizard);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup1.ShowCaptionButton = false;
      this.ribbonPageGroup1.Text = "Aufträge";
      // 
      // ribbonPageGroup2
      // 
      this.ribbonPageGroup2.AllowMinimize = false;
      this.ribbonPageGroup2.ItemLinks.Add(this.printOffer);
      this.ribbonPageGroup2.ItemLinks.Add(this.printOrder);
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
      this.ribbonPageGroup3.ItemLinks.Add(this.showPerson);
      this.ribbonPageGroup3.ItemLinks.Add(this.showAddress);
      this.ribbonPageGroup3.ItemLinks.Add(this.deleteCustomer);
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
      this.ribbonPageGroup5.ItemLinks.Add(this.predefinedOrder);
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
      this.ribbonPageGroup6.ItemLinks.Add(this.clickCosts);
      this.ribbonPageGroup6.ItemLinks.Add(this.machines);
      this.ribbonPageGroup6.ItemLinks.Add(this.state);
      this.ribbonPageGroup6.ItemLinks.Add(this.genders);
      this.ribbonPageGroup6.ItemLinks.Add(this.editOffer);
      this.ribbonPageGroup6.ItemLinks.Add(this.editOrder);
      this.ribbonPageGroup6.ItemLinks.Add(this.editDelivery);
      this.ribbonPageGroup6.ItemLinks.Add(this.paperSizes);
      this.ribbonPageGroup6.Name = "ribbonPageGroup6";
      this.ribbonPageGroup6.ShowCaptionButton = false;
      this.ribbonPageGroup6.Text = "Grundeinstellungen verwalten";
      // 
      // ribbonStatusBar
      // 
      this.ribbonStatusBar.Location = new System.Drawing.Point(0, 348);
      this.ribbonStatusBar.Name = "ribbonStatusBar";
      this.ribbonStatusBar.Ribbon = this.ribbon;
      this.ribbonStatusBar.Size = new System.Drawing.Size(825, 31);
      // 
      // mainPanel
      // 
      this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainPanel.Location = new System.Drawing.Point(0, 145);
      this.mainPanel.Name = "mainPanel";
      this.mainPanel.Size = new System.Drawing.Size(825, 203);
      this.mainPanel.TabIndex = 2;
      // 
      // paperSizes
      // 
      this.paperSizes.Caption = "Papierformate bearbeiten";
      this.paperSizes.Id = 30;
      this.paperSizes.LargeGlyph = global::Impressio.Properties.Resources.paperplane;
      this.paperSizes.Name = "paperSizes";
      // 
      // MainViewRibbon
      // 
      this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(825, 379);
      this.Controls.Add(this.mainPanel);
      this.Controls.Add(this.ribbonStatusBar);
      this.Controls.Add(this.ribbon);
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

    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
    private DevExpress.XtraBars.BarButtonItem openOrder;
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
    public DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
    public DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageOrder;
    public DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCustomer;
    public DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageProperties;
    private DevExpress.XtraBars.BarButtonItem editOffer;
    private DevExpress.XtraBars.BarButtonItem editOrder;
    private DevExpress.XtraBars.BarButtonItem editDelivery;
    private DevExpress.XtraBars.BarButtonItem predefinedOrder;
    private DevExpress.XtraBars.BarButtonItem createOrderWizard;
    private DevExpress.XtraBars.BarButtonItem deleteCustomer;
    private DevExpress.XtraBars.BarButtonItem paperSizes;
  }
}