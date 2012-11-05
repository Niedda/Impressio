namespace Impressio.Views
{
  partial class GenderView
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
      this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
      this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // mainPanel
      // 
      this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mainPanel.Location = new System.Drawing.Point(168, 5);
      this.mainPanel.Name = "mainPanel";
      this.mainPanel.Size = new System.Drawing.Size(310, 300);
      this.mainPanel.TabIndex = 0;
      // 
      // navBarControl1
      // 
      this.navBarControl1.ActiveGroup = this.navBarGroup1;
      this.navBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
      this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1});
      this.navBarControl1.Location = new System.Drawing.Point(3, 5);
      this.navBarControl1.Name = "navBarControl1";
      this.navBarControl1.OptionsNavPane.ExpandedWidth = 159;
      this.navBarControl1.Size = new System.Drawing.Size(159, 300);
      this.navBarControl1.TabIndex = 1;
      this.navBarControl1.Text = "navBarControl1";
      // 
      // navBarGroup1
      // 
      this.navBarGroup1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.navBarGroup1.Appearance.Options.UseFont = true;
      this.navBarGroup1.Caption = "Anreden";
      this.navBarGroup1.Expanded = true;
      this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
      this.navBarGroup1.Name = "navBarGroup1";
      // 
      // navBarItem1
      // 
      this.navBarItem1.Caption = "Anrede löschen";
      this.navBarItem1.Name = "navBarItem1";
      this.navBarItem1.SmallImage = global::Impressio.Properties.Resources.delete;
      this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavBarItem1LinkClicked);
      // 
      // GenderView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 311);
      this.Controls.Add(this.navBarControl1);
      this.Controls.Add(this.mainPanel);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(500, 350);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(500, 350);
      this.Name = "GenderView";
      this.ShowIcon = false;
      this.Load += new System.EventHandler(this.GenderViewLoad);
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.PanelControl mainPanel;
    private DevExpress.XtraNavBar.NavBarControl navBarControl1;
    private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
    private DevExpress.XtraNavBar.NavBarItem navBarItem1;
  }
}