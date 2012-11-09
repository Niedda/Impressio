namespace Impressio.Views
{
  public partial class StartScreen
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.task = new DevExpress.XtraEditors.LabelControl();
      this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(209, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(90, 19);
      this.label1.TabIndex = 1;
      this.label1.Text = "Impressio";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(206, 145);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // task
      // 
      this.task.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.task.Location = new System.Drawing.Point(214, 81);
      this.task.Name = "task";
      this.task.Size = new System.Drawing.Size(0, 13);
      this.task.TabIndex = 3;
      // 
      // marqueeProgressBarControl1
      // 
      this.marqueeProgressBarControl1.EditValue = 0;
      this.marqueeProgressBarControl1.Location = new System.Drawing.Point(213, 106);
      this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
      this.marqueeProgressBarControl1.Size = new System.Drawing.Size(250, 25);
      this.marqueeProgressBarControl1.TabIndex = 4;
      // 
      // StartScreen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(475, 143);
      this.ControlBox = false;
      this.Controls.Add(this.marqueeProgressBarControl1);
      this.Controls.Add(this.task);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "StartScreen";
      this.Padding = new System.Windows.Forms.Padding(9);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl1;
    public DevExpress.XtraEditors.LabelControl task;

  }
}
