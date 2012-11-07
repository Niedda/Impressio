namespace Impressio.Views
{
  partial class MainView
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
      this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
      this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
      this.navOrder = new DevExpress.XtraNavBar.NavBarItem();
      this.navCompany = new DevExpress.XtraNavBar.NavBarItem();
      this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
      this.navProperties = new DevExpress.XtraNavBar.NavBarItem();
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // navBarControl1
      // 
      this.navBarControl1.ActiveGroup = this.navBarGroup1;
      this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.navBarControl1.ExplorerBarShowGroupButtons = false;
      this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
      this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navOrder,
            this.navCompany,
            this.navProperties});
      this.navBarControl1.Location = new System.Drawing.Point(0, 0);
      this.navBarControl1.Name = "navBarControl1";
      this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
      this.navBarControl1.Padding = new System.Windows.Forms.Padding(1);
      this.navBarControl1.Size = new System.Drawing.Size(244, 246);
      this.navBarControl1.TabIndex = 0;
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
      this.navBarGroup1.Caption = "Hauptfunktionen";
      this.navBarGroup1.Expanded = true;
      this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navOrder),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navCompany)});
      this.navBarGroup1.Name = "navBarGroup1";
      // 
      // navOrder
      // 
      this.navOrder.Caption = "Auftragsübersicht";
      this.navOrder.Name = "navOrder";
      this.navOrder.SmallImage = global::Impressio.Properties.Resources.remark;
      this.navOrder.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavOrderLinkClicked);
      // 
      // navCompany
      // 
      this.navCompany.Caption = "Kundenverwaltung";
      this.navCompany.Name = "navCompany";
      this.navCompany.SmallImage = global::Impressio.Properties.Resources.company;
      this.navCompany.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavCompanyLinkClicked);
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
      this.navBarGroup2.Caption = "Einstellungen";
      this.navBarGroup2.Expanded = true;
      this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navProperties)});
      this.navBarGroup2.Name = "navBarGroup2";
      // 
      // navProperties
      // 
      this.navProperties.Caption = "Voreinstellungen";
      this.navProperties.Name = "navProperties";
      this.navProperties.SmallImage = global::Impressio.Properties.Resources.properties;
      this.navProperties.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavPropertiesLinkClicked);
      // 
      // MainView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(244, 246);
      this.Controls.Add(this.navBarControl1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(260, 285);
      this.Name = "MainView";
      this.ShowIcon = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraNavBar.NavBarControl navBarControl1;
    private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
    private DevExpress.XtraNavBar.NavBarItem navOrder;
    private DevExpress.XtraNavBar.NavBarItem navCompany;
    private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
    private DevExpress.XtraNavBar.NavBarItem navProperties;
  }
}