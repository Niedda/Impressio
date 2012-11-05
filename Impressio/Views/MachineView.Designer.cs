namespace Impressio.Views
{
  partial class MachineView
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
      this.navMachine = new DevExpress.XtraNavBar.NavBarGroup();
      this.navDeleteMachine = new DevExpress.XtraNavBar.NavBarItem();
      this.navRefresh = new DevExpress.XtraNavBar.NavBarItem();
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // mainPanel
      // 
      this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mainPanel.Location = new System.Drawing.Point(178, 5);
      this.mainPanel.Name = "mainPanel";
      this.mainPanel.Size = new System.Drawing.Size(600, 450);
      this.mainPanel.TabIndex = 0;
      // 
      // navBarControl1
      // 
      this.navBarControl1.ActiveGroup = this.navMachine;
      this.navBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navMachine});
      this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navDeleteMachine,
            this.navRefresh});
      this.navBarControl1.Location = new System.Drawing.Point(3, 5);
      this.navBarControl1.Name = "navBarControl1";
      this.navBarControl1.OptionsNavPane.ExpandedWidth = 169;
      this.navBarControl1.Size = new System.Drawing.Size(169, 444);
      this.navBarControl1.TabIndex = 1;
      this.navBarControl1.Text = "navBarControl1";
      // 
      // navMachine
      // 
      this.navMachine.Appearance.Font = new System.Drawing.Font("Frutiger LT Std 87 ExtraBlk Cn", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.navMachine.Appearance.Options.UseFont = true;
      this.navMachine.AppearanceBackground.Font = new System.Drawing.Font("Frutiger LT Std 87 ExtraBlk Cn", 8.999999F, System.Drawing.FontStyle.Bold);
      this.navMachine.AppearanceBackground.Options.UseFont = true;
      this.navMachine.AppearanceHotTracked.Font = new System.Drawing.Font("Frutiger LT Std 87 ExtraBlk Cn", 8.999999F, System.Drawing.FontStyle.Bold);
      this.navMachine.AppearanceHotTracked.Options.UseFont = true;
      this.navMachine.AppearancePressed.Font = new System.Drawing.Font("Frutiger LT Std 87 ExtraBlk Cn", 8.999999F, System.Drawing.FontStyle.Bold);
      this.navMachine.AppearancePressed.Options.UseFont = true;
      this.navMachine.Caption = "Druckmaschinen";
      this.navMachine.Expanded = true;
      this.navMachine.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDeleteMachine),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navRefresh)});
      this.navMachine.Name = "navMachine";
      // 
      // navDeleteMachine
      // 
      this.navDeleteMachine.Caption = "Maschine löschen";
      this.navDeleteMachine.Name = "navDeleteMachine";
      this.navDeleteMachine.SmallImage = global::Impressio.Properties.Resources.delete;
      this.navDeleteMachine.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavDeleteMachineLinkClicked);
      // 
      // navRefresh
      // 
      this.navRefresh.Caption = "Aktualisieren";
      this.navRefresh.Name = "navRefresh";
      this.navRefresh.SmallImage = global::Impressio.Properties.Resources.refresh;
      this.navRefresh.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavRefreshLinkClicked);
      // 
      // MachineView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 461);
      this.Controls.Add(this.navBarControl1);
      this.Controls.Add(this.mainPanel);
      this.MinimumSize = new System.Drawing.Size(800, 500);
      this.Name = "MachineView";
      this.ShowIcon = false;
      this.Load += new System.EventHandler(this.MachineViewLoad);
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.PanelControl mainPanel;
    private DevExpress.XtraNavBar.NavBarControl navBarControl1;
    private DevExpress.XtraNavBar.NavBarGroup navMachine;
    private DevExpress.XtraNavBar.NavBarItem navDeleteMachine;
    private DevExpress.XtraNavBar.NavBarItem navRefresh;
  }
}