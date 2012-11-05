namespace Impressio.Controls
{
  partial class PropertieControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.dbConnectionString = new DevExpress.XtraEditors.MemoEdit();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
      this.logFolderPath = new DevExpress.XtraEditors.TextEdit();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.exceptionMode = new DevExpress.XtraEditors.CheckEdit();
      this.user = new DevExpress.XtraEditors.TextEdit();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
      this.pathData = new DevExpress.XtraEditors.TextEdit();
      this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
      this.database = new DevExpress.XtraEditors.ComboBoxEdit();
      this.logger = new DevExpress.XtraEditors.ComboBoxEdit();
      this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dbConnectionString.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.logFolderPath.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.exceptionMode.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.user.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pathData.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.database.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.logger.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(62, 56);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(140, 13);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Datenbank Connection String";
      // 
      // dbConnectionString
      // 
      this.dbConnectionString.Location = new System.Drawing.Point(249, 53);
      this.dbConnectionString.Name = "dbConnectionString";
      this.dbConnectionString.Size = new System.Drawing.Size(424, 67);
      this.dbConnectionString.TabIndex = 2;
      this.dbConnectionString.EditValueChanged += new System.EventHandler(this.DbConnectionStringEditValueChanged);
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(62, 140);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(83, 13);
      this.labelControl2.TabIndex = 3;
      this.labelControl2.Text = "Pfad zum Log File";
      // 
      // logFolderPath
      // 
      this.logFolderPath.Location = new System.Drawing.Point(249, 137);
      this.logFolderPath.Name = "logFolderPath";
      this.logFolderPath.Size = new System.Drawing.Size(424, 20);
      this.logFolderPath.TabIndex = 4;
      this.logFolderPath.Enter += new System.EventHandler(this.LogFolderPathEnter);
      // 
      // labelControl3
      // 
      this.labelControl3.Location = new System.Drawing.Point(62, 311);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(76, 13);
      this.labelControl3.TabIndex = 5;
      this.labelControl3.Text = "Exception Mode";
      // 
      // exceptionMode
      // 
      this.exceptionMode.Location = new System.Drawing.Point(247, 308);
      this.exceptionMode.Name = "exceptionMode";
      this.exceptionMode.Properties.Caption = "";
      this.exceptionMode.Size = new System.Drawing.Size(152, 19);
      this.exceptionMode.TabIndex = 6;
      this.exceptionMode.CheckedChanged += new System.EventHandler(this.ExceptionModeCheckedChanged);
      // 
      // user
      // 
      this.user.Location = new System.Drawing.Point(249, 205);
      this.user.Name = "user";
      this.user.Size = new System.Drawing.Size(424, 20);
      this.user.TabIndex = 8;
      this.user.EditValueChanged += new System.EventHandler(this.UserEditValueChanged);
      // 
      // labelControl4
      // 
      this.labelControl4.Location = new System.Drawing.Point(62, 208);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(22, 13);
      this.labelControl4.TabIndex = 7;
      this.labelControl4.Text = "User";
      // 
      // labelControl5
      // 
      this.labelControl5.Location = new System.Drawing.Point(62, 174);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new System.Drawing.Size(89, 13);
      this.labelControl5.TabIndex = 9;
      this.labelControl5.Text = "Pfad zu den Daten";
      // 
      // pathData
      // 
      this.pathData.Location = new System.Drawing.Point(249, 171);
      this.pathData.Name = "pathData";
      this.pathData.Size = new System.Drawing.Size(424, 20);
      this.pathData.TabIndex = 10;
      this.pathData.Enter += new System.EventHandler(this.PathDataEnter);
      // 
      // labelControl6
      // 
      this.labelControl6.Location = new System.Drawing.Point(62, 242);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new System.Drawing.Size(52, 13);
      this.labelControl6.TabIndex = 11;
      this.labelControl6.Text = "Datenbank";
      // 
      // labelControl7
      // 
      this.labelControl7.Location = new System.Drawing.Point(62, 277);
      this.labelControl7.Name = "labelControl7";
      this.labelControl7.Size = new System.Drawing.Size(68, 13);
      this.labelControl7.TabIndex = 12;
      this.labelControl7.Text = "Logger Engine";
      // 
      // database
      // 
      this.database.Location = new System.Drawing.Point(249, 239);
      this.database.Name = "database";
      this.database.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.database.Properties.Items.AddRange(new object[] {
            "compact",
            "mssql",
            "posql"});
      this.database.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.database.Size = new System.Drawing.Size(424, 20);
      this.database.TabIndex = 13;
      this.database.SelectedIndexChanged += new System.EventHandler(this.DatabaseSelectedIndexChanged);
      // 
      // logger
      // 
      this.logger.Location = new System.Drawing.Point(249, 274);
      this.logger.Name = "logger";
      this.logger.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.logger.Properties.Items.AddRange(new object[] {
            "file",
            "database"});
      this.logger.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.logger.Size = new System.Drawing.Size(424, 20);
      this.logger.TabIndex = 14;
      this.logger.SelectedIndexChanged += new System.EventHandler(this.LoggerSelectedIndexChanged);
      // 
      // labelControl8
      // 
      this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
      this.labelControl8.Location = new System.Drawing.Point(62, 395);
      this.labelControl8.Name = "labelControl8";
      this.labelControl8.Size = new System.Drawing.Size(460, 14);
      this.labelControl8.TabIndex = 15;
      this.labelControl8.Text = "Programm muss neu gestartet werden damit Änderungen wirksam werden";
      // 
      // PropertieControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.labelControl8);
      this.Controls.Add(this.logger);
      this.Controls.Add(this.database);
      this.Controls.Add(this.labelControl7);
      this.Controls.Add(this.labelControl6);
      this.Controls.Add(this.pathData);
      this.Controls.Add(this.labelControl5);
      this.Controls.Add(this.user);
      this.Controls.Add(this.labelControl4);
      this.Controls.Add(this.exceptionMode);
      this.Controls.Add(this.labelControl3);
      this.Controls.Add(this.logFolderPath);
      this.Controls.Add(this.labelControl2);
      this.Controls.Add(this.dbConnectionString);
      this.Controls.Add(this.labelControl1);
      this.Name = "PropertieControl";
      this.Size = new System.Drawing.Size(809, 353);
      this.Load += new System.EventHandler(this.PropertieControlLoad);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dbConnectionString.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.logFolderPath.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.exceptionMode.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.user.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pathData.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.database.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.logger.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.MemoEdit dbConnectionString;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    private DevExpress.XtraEditors.TextEdit logFolderPath;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.CheckEdit exceptionMode;
    private DevExpress.XtraEditors.TextEdit user;
    private DevExpress.XtraEditors.LabelControl labelControl4;
    private DevExpress.XtraEditors.LabelControl labelControl5;
    private DevExpress.XtraEditors.TextEdit pathData;
    private DevExpress.XtraEditors.LabelControl labelControl6;
    private DevExpress.XtraEditors.LabelControl labelControl7;
    private DevExpress.XtraEditors.ComboBoxEdit database;
    private DevExpress.XtraEditors.ComboBoxEdit logger;
    private DevExpress.XtraEditors.LabelControl labelControl8;
  }
}
