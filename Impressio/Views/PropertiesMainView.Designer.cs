namespace Impressio.Views
{
  partial class PropertiesMainView
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
      this.navMachine = new DevExpress.XtraNavBar.NavBarItem();
      this.navDescription = new DevExpress.XtraNavBar.NavBarItem();
      this.navClickCost = new DevExpress.XtraNavBar.NavBarItem();
      this.navPaper = new DevExpress.XtraNavBar.NavBarItem();
      this.navGender = new DevExpress.XtraNavBar.NavBarItem();
      this.navPosition = new DevExpress.XtraNavBar.NavBarItem();
      this.navProperties = new DevExpress.XtraNavBar.NavBarItem();
      this.navState = new DevExpress.XtraNavBar.NavBarItem();
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // navBarControl1
      // 
      this.navBarControl1.ActiveGroup = this.navBarGroup1;
      this.navBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.navBarControl1.ExplorerBarShowGroupButtons = false;
      this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
      this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navMachine,
            this.navDescription,
            this.navClickCost,
            this.navPaper,
            this.navGender,
            this.navPosition,
            this.navProperties,
            this.navState});
      this.navBarControl1.Location = new System.Drawing.Point(3, 5);
      this.navBarControl1.Name = "navBarControl1";
      this.navBarControl1.OptionsNavPane.ExpandedWidth = 401;
      this.navBarControl1.Size = new System.Drawing.Size(283, 440);
      this.navBarControl1.TabIndex = 0;
      this.navBarControl1.Text = "navBarControl1";
      // 
      // navBarGroup1
      // 
      this.navBarGroup1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.navBarGroup1.Appearance.Options.UseFont = true;
      this.navBarGroup1.Caption = "Voreinstellungen";
      this.navBarGroup1.Expanded = true;
      this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navProperties),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPosition),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDescription),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPaper),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navMachine),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navClickCost),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navGender),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navState)});
      this.navBarGroup1.Name = "navBarGroup1";
      // 
      // navMachine
      // 
      this.navMachine.Caption = "Druckmaschinen";
      this.navMachine.Name = "navMachine";
      this.navMachine.SmallImage = global::Impressio.Properties.Resources.printer;
      this.navMachine.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavMachineLinkClicked);
      // 
      // navDescription
      // 
      this.navDescription.Caption = "Beschreibungen";
      this.navDescription.Name = "navDescription";
      this.navDescription.SmallImage = global::Impressio.Properties.Resources.pen;
      this.navDescription.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavDescriptionLinkClicked);
      // 
      // navClickCost
      // 
      this.navClickCost.Caption = "Klickkosten";
      this.navClickCost.Name = "navClickCost";
      this.navClickCost.SmallImage = global::Impressio.Properties.Resources.print;
      this.navClickCost.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavClickCostLinkClicked);
      // 
      // navPaper
      // 
      this.navPaper.Caption = "Papiermanagement";
      this.navPaper.Name = "navPaper";
      this.navPaper.SmallImage = global::Impressio.Properties.Resources.paper;
      this.navPaper.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavPaperLinkClicked);
      // 
      // navGender
      // 
      this.navGender.Caption = "Anreden";
      this.navGender.Name = "navGender";
      this.navGender.SmallImage = global::Impressio.Properties.Resources.gender;
      this.navGender.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavGenderLinkClicked);
      // 
      // navPosition
      // 
      this.navPosition.Caption = "Positionen";
      this.navPosition.Name = "navPosition";
      this.navPosition.SmallImage = global::Impressio.Properties.Resources.book;
      this.navPosition.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavPositionLinkClicked);
      // 
      // navProperties
      // 
      this.navProperties.Caption = "Voreinstellungen";
      this.navProperties.Name = "navProperties";
      this.navProperties.SmallImage = global::Impressio.Properties.Resources.properties;
      this.navProperties.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavPropertiesLinkClicked);
      // 
      // navState
      // 
      this.navState.Caption = "Auftragsstatus";
      this.navState.Name = "navState";
      this.navState.SmallImage = global::Impressio.Properties.Resources.state;
      this.navState.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavStateLinkClicked);
      // 
      // PropertiesMainView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(289, 451);
      this.Controls.Add(this.navBarControl1);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(305, 490);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(305, 490);
      this.Name = "PropertiesMainView";
      this.ShowIcon = false;
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraNavBar.NavBarControl navBarControl1;
    private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
    private DevExpress.XtraNavBar.NavBarItem navMachine;
    private DevExpress.XtraNavBar.NavBarItem navDescription;
    private DevExpress.XtraNavBar.NavBarItem navClickCost;
    private DevExpress.XtraNavBar.NavBarItem navPaper;
    private DevExpress.XtraNavBar.NavBarItem navGender;
    private DevExpress.XtraNavBar.NavBarItem navPosition;
    private DevExpress.XtraNavBar.NavBarItem navProperties;
    private DevExpress.XtraNavBar.NavBarItem navState;
  }
}