namespace Impressio.Views
{
  partial class EmptyView
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
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
      this.SuspendLayout();
      // 
      // mainPanel
      // 
      this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mainPanel.Location = new System.Drawing.Point(2, 2);
      this.mainPanel.Name = "mainPanel";
      this.mainPanel.Padding = new System.Windows.Forms.Padding(2);
      this.mainPanel.Size = new System.Drawing.Size(780, 457);
      this.mainPanel.TabIndex = 0;
      // 
      // EmptyView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 461);
      this.Controls.Add(this.mainPanel);
      this.MinimumSize = new System.Drawing.Size(800, 500);
      this.Name = "EmptyView";
      this.ShowIcon = false;
      ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    public DevExpress.XtraEditors.PanelControl mainPanel;

  }
}