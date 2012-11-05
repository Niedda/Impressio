namespace Impressio.Views
{
  partial class CustomerView
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
      this.navCompany = new DevExpress.XtraNavBar.NavBarItem();
      this.navAddress = new DevExpress.XtraNavBar.NavBarItem();
      this.navClient = new DevExpress.XtraNavBar.NavBarItem();
      this.navDelete = new DevExpress.XtraNavBar.NavBarItem();
      this.mainPanel = new DevExpress.XtraEditors.PanelControl();
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
            this.navCompany,
            this.navAddress,
            this.navClient,
            this.navDelete});
      this.navBarControl1.Location = new System.Drawing.Point(1, 2);
      this.navBarControl1.Name = "navBarControl1";
      this.navBarControl1.OptionsNavPane.ExpandedWidth = 183;
      this.navBarControl1.Padding = new System.Windows.Forms.Padding(1);
      this.navBarControl1.Size = new System.Drawing.Size(183, 458);
      this.navBarControl1.TabIndex = 0;
      this.navBarControl1.Text = "navBarControl1";
      // 
      // navBarGroup1
      // 
      this.navBarGroup1.Appearance.Font = new System.Drawing.Font("Frutiger LT Std 87 ExtraBlk Cn", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.navBarGroup1.Appearance.Options.UseFont = true;
      this.navBarGroup1.AppearanceBackground.Font = new System.Drawing.Font("Frutiger LT Std 87 ExtraBlk Cn", 9.749999F, System.Drawing.FontStyle.Bold);
      this.navBarGroup1.AppearanceBackground.Options.UseFont = true;
      this.navBarGroup1.AppearanceHotTracked.Font = new System.Drawing.Font("Frutiger LT Std 87 ExtraBlk Cn", 9.749999F, System.Drawing.FontStyle.Bold);
      this.navBarGroup1.AppearanceHotTracked.Options.UseFont = true;
      this.navBarGroup1.AppearancePressed.Font = new System.Drawing.Font("Frutiger LT Std 87 ExtraBlk Cn", 9.749999F, System.Drawing.FontStyle.Bold);
      this.navBarGroup1.AppearancePressed.Options.UseFont = true;
      this.navBarGroup1.Caption = "Kundenverwaltung";
      this.navBarGroup1.Expanded = true;
      this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navCompany),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navAddress),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navClient),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDelete)});
      this.navBarGroup1.Name = "navBarGroup1";
      // 
      // navCompany
      // 
      this.navCompany.Caption = "Firmen anzeigen";
      this.navCompany.Name = "navCompany";
      this.navCompany.SmallImage = global::Impressio.Properties.Resources.company;
      this.navCompany.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavCompanyLinkClicked);
      // 
      // navAddress
      // 
      this.navAddress.Caption = "Adressen anzeigen";
      this.navAddress.Name = "navAddress";
      this.navAddress.SmallImage = global::Impressio.Properties.Resources.address;
      this.navAddress.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavAddressLinkClicked);
      // 
      // navClient
      // 
      this.navClient.Caption = "Personen anzeigen";
      this.navClient.Name = "navClient";
      this.navClient.SmallImage = global::Impressio.Properties.Resources.person;
      this.navClient.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavClientLinkClicked);
      // 
      // navDelete
      // 
      this.navDelete.Caption = "Eintrag löschen";
      this.navDelete.Name = "navDelete";
      this.navDelete.SmallImage = global::Impressio.Properties.Resources.delete;
      this.navDelete.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavDeleteLinkClicked);
      // 
      // mainPanel
      // 
      this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mainPanel.Location = new System.Drawing.Point(190, 2);
      this.mainPanel.Name = "mainPanel";
      this.mainPanel.Size = new System.Drawing.Size(592, 458);
      this.mainPanel.TabIndex = 1;
      // 
      // CustomerView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 461);
      this.Controls.Add(this.mainPanel);
      this.Controls.Add(this.navBarControl1);
      this.MinimumSize = new System.Drawing.Size(800, 500);
      this.Name = "CustomerView";
      this.ShowIcon = false;
      this.Load += new System.EventHandler(this.CustomerViewLoad);
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraNavBar.NavBarControl navBarControl1;
    private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
    private DevExpress.XtraNavBar.NavBarItem navCompany;
    private DevExpress.XtraNavBar.NavBarItem navAddress;
    private DevExpress.XtraNavBar.NavBarItem navClient;
    private DevExpress.XtraEditors.PanelControl mainPanel;
    private DevExpress.XtraNavBar.NavBarItem navDelete;

  }
}