namespace Impressio.Views
{
  partial class DescriptionView
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
      this.navDeletePosition = new DevExpress.XtraNavBar.NavBarItem();
      this.navDeleteDetail = new DevExpress.XtraNavBar.NavBarItem();
      this.mainPanel = new DevExpress.XtraEditors.PanelControl();
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
            this.navDeletePosition,
            this.navDeleteDetail,
            this.navRefresh});
      this.navBarControl1.Location = new System.Drawing.Point(2, 4);
      this.navBarControl1.Name = "navBarControl1";
      this.navBarControl1.OptionsNavPane.ExpandedWidth = 157;
      this.navBarControl1.Size = new System.Drawing.Size(181, 450);
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
      this.navBarGroup1.Caption = "Beschreibung";
      this.navBarGroup1.Expanded = true;
      this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDeletePosition),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDeleteDetail),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navRefresh)});
      this.navBarGroup1.Name = "navBarGroup1";
      // 
      // navDeletePosition
      // 
      this.navDeletePosition.Caption = "Beschreibung löschen";
      this.navDeletePosition.Name = "navDeletePosition";
      this.navDeletePosition.SmallImage = global::Impressio.Properties.Resources.delete;
      this.navDeletePosition.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavDeleteLinkClicked);
      // 
      // navDeleteDetail
      // 
      this.navDeleteDetail.Caption = "Detail löschen";
      this.navDeleteDetail.Name = "navDeleteDetail";
      this.navDeleteDetail.SmallImage = global::Impressio.Properties.Resources.delete;
      this.navDeleteDetail.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavDeleteDetailLinkClicked);
      // 
      // mainPanel
      // 
      this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mainPanel.Location = new System.Drawing.Point(189, 4);
      this.mainPanel.Name = "mainPanel";
      this.mainPanel.Size = new System.Drawing.Size(591, 450);
      this.mainPanel.TabIndex = 1;
      // 
      // navRefresh
      // 
      this.navRefresh.Caption = "Aktualisieren";
      this.navRefresh.Name = "navRefresh";
      this.navRefresh.SmallImage = global::Impressio.Properties.Resources.refresh;
      this.navRefresh.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavRefreshLinkClicked);
      // 
      // DescriptionView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 461);
      this.Controls.Add(this.mainPanel);
      this.Controls.Add(this.navBarControl1);
      this.MinimumSize = new System.Drawing.Size(800, 500);
      this.Name = "DescriptionView";
      this.ShowIcon = false;
      this.Load += new System.EventHandler(this.DescriptionViewLoad);
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraNavBar.NavBarControl navBarControl1;
    private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
    private DevExpress.XtraNavBar.NavBarItem navDeletePosition;
    private DevExpress.XtraEditors.PanelControl mainPanel;
    private DevExpress.XtraNavBar.NavBarItem navDeleteDetail;
    private DevExpress.XtraNavBar.NavBarItem navRefresh;
  }
}