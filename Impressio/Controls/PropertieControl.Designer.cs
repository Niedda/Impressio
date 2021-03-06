﻿using System.Windows.Forms;

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
      this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
      this.user = new DevExpress.XtraEditors.TextEdit();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
      this.database = new DevExpress.XtraEditors.ComboBoxEdit();
      this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
      this.databaseTabPage = new DevExpress.XtraTab.XtraTabPage();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.compactName = new DevExpress.XtraEditors.TextEdit();
      this.databaseCheckResult = new DevExpress.XtraEditors.LabelControl();
      this.createCompactDb = new DevExpress.XtraEditors.SimpleButton();
      this.checkDatabaseSetting = new DevExpress.XtraEditors.SimpleButton();
      this.userTabPage = new DevExpress.XtraTab.XtraTabPage();
      this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
      this.logoEdit = new DevExpress.XtraEditors.TextEdit();
      this.lookAndFeel = new DevExpress.XtraEditors.ComboBoxEdit();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dbConnectionString.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.user.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.database.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
      this.xtraTabControl1.SuspendLayout();
      this.databaseTabPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.compactName.Properties)).BeginInit();
      this.userTabPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.logoEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookAndFeel.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Navy;
      this.labelControl1.Location = new System.Drawing.Point(23, 25);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(140, 13);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Datenbank Connection String";
      // 
      // dbConnectionString
      // 
      this.dbConnectionString.Location = new System.Drawing.Point(23, 48);
      this.dbConnectionString.Name = "dbConnectionString";
      this.dbConnectionString.Size = new System.Drawing.Size(488, 132);
      this.dbConnectionString.TabIndex = 2;
      this.dbConnectionString.EditValueChanged += new System.EventHandler(this.DbConnectionStringEditValueChanged);
      // 
      // user
      // 
      this.user.Location = new System.Drawing.Point(18, 41);
      this.user.Name = "user";
      this.user.Size = new System.Drawing.Size(497, 20);
      this.user.TabIndex = 8;
      this.user.EditValueChanged += new System.EventHandler(this.UserEditValueChanged);
      // 
      // labelControl4
      // 
      this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Navy;
      this.labelControl4.Location = new System.Drawing.Point(18, 22);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(22, 13);
      this.labelControl4.TabIndex = 7;
      this.labelControl4.Text = "User";
      // 
      // labelControl6
      // 
      this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Navy;
      this.labelControl6.Location = new System.Drawing.Point(23, 204);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new System.Drawing.Size(52, 13);
      this.labelControl6.TabIndex = 11;
      this.labelControl6.Text = "Datenbank";
      // 
      // database
      // 
      this.database.Location = new System.Drawing.Point(23, 225);
      this.database.Name = "database";
      this.database.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.database.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.database.Size = new System.Drawing.Size(259, 20);
      this.database.TabIndex = 13;
      this.database.SelectedIndexChanged += new System.EventHandler(this.DatabaseSelectedIndexChanged);
      // 
      // xtraTabControl1
      // 
      this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
      this.xtraTabControl1.Name = "xtraTabControl1";
      this.xtraTabControl1.SelectedTabPage = this.userTabPage;
      this.xtraTabControl1.Size = new System.Drawing.Size(859, 429);
      this.xtraTabControl1.TabIndex = 16;
      this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.userTabPage,
            this.databaseTabPage});
      // 
      // databaseTabPage
      // 
      this.databaseTabPage.Controls.Add(this.labelControl2);
      this.databaseTabPage.Controls.Add(this.compactName);
      this.databaseTabPage.Controls.Add(this.databaseCheckResult);
      this.databaseTabPage.Controls.Add(this.createCompactDb);
      this.databaseTabPage.Controls.Add(this.checkDatabaseSetting);
      this.databaseTabPage.Controls.Add(this.dbConnectionString);
      this.databaseTabPage.Controls.Add(this.labelControl1);
      this.databaseTabPage.Controls.Add(this.labelControl6);
      this.databaseTabPage.Controls.Add(this.database);
      this.databaseTabPage.Name = "databaseTabPage";
      this.databaseTabPage.Size = new System.Drawing.Size(853, 403);
      this.databaseTabPage.Text = "Datenbank";
      // 
      // labelControl2
      // 
      this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Navy;
      this.labelControl2.Location = new System.Drawing.Point(23, 276);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(144, 13);
      this.labelControl2.TabIndex = 18;
      this.labelControl2.Text = "Name für Compact Datenbank";
      // 
      // compactName
      // 
      this.compactName.Location = new System.Drawing.Point(23, 297);
      this.compactName.Name = "compactName";
      this.compactName.Size = new System.Drawing.Size(259, 20);
      this.compactName.TabIndex = 17;
      // 
      // databaseCheckResult
      // 
      this.databaseCheckResult.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
      this.databaseCheckResult.Location = new System.Drawing.Point(25, 340);
      this.databaseCheckResult.Name = "databaseCheckResult";
      this.databaseCheckResult.Size = new System.Drawing.Size(0, 16);
      this.databaseCheckResult.TabIndex = 16;
      // 
      // createCompactDb
      // 
      this.createCompactDb.Location = new System.Drawing.Point(341, 294);
      this.createCompactDb.Name = "createCompactDb";
      this.createCompactDb.Size = new System.Drawing.Size(170, 23);
      this.createCompactDb.TabIndex = 15;
      this.createCompactDb.Text = "Compact Datenbank erstellen";
      this.createCompactDb.Click += new System.EventHandler(this.CreateCompactDbClick);
      // 
      // checkDatabaseSetting
      // 
      this.checkDatabaseSetting.Location = new System.Drawing.Point(374, 222);
      this.checkDatabaseSetting.Name = "checkDatabaseSetting";
      this.checkDatabaseSetting.Size = new System.Drawing.Size(137, 23);
      this.checkDatabaseSetting.TabIndex = 14;
      this.checkDatabaseSetting.Text = "Einstellungen prüfen";
      this.checkDatabaseSetting.Click += new System.EventHandler(this.CheckDatabaseSettingClick);
      // 
      // userTabPage
      // 
      this.userTabPage.Controls.Add(this.labelControl7);
      this.userTabPage.Controls.Add(this.logoEdit);
      this.userTabPage.Controls.Add(this.lookAndFeel);
      this.userTabPage.Controls.Add(this.labelControl3);
      this.userTabPage.Controls.Add(this.labelControl4);
      this.userTabPage.Controls.Add(this.user);
      this.userTabPage.Name = "userTabPage";
      this.userTabPage.Size = new System.Drawing.Size(853, 403);
      this.userTabPage.Text = "Benutzer";
      // 
      // labelControl7
      // 
      this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Navy;
      this.labelControl7.Location = new System.Drawing.Point(18, 143);
      this.labelControl7.Name = "labelControl7";
      this.labelControl7.Size = new System.Drawing.Size(145, 13);
      this.labelControl7.TabIndex = 13;
      this.labelControl7.Text = "Pfad zum Logo 250px x 200px";
      // 
      // logoEdit
      // 
      this.logoEdit.Location = new System.Drawing.Point(18, 162);
      this.logoEdit.Name = "logoEdit";
      this.logoEdit.Size = new System.Drawing.Size(497, 20);
      this.logoEdit.TabIndex = 14;
      this.logoEdit.Enter += new System.EventHandler(this.LogoEditEnter);
      // 
      // lookAndFeel
      // 
      this.lookAndFeel.Location = new System.Drawing.Point(18, 101);
      this.lookAndFeel.Name = "lookAndFeel";
      this.lookAndFeel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookAndFeel.Properties.DropDownRows = 10;
      this.lookAndFeel.Properties.Items.AddRange(new object[] {
            "Default ",
            "Black",
            "Blue",
            "Money Twins",
            "Caramel",
            "Office 2010 Blue",
            "Office 2010 Black",
            "Lilian",
            "iMaginary",
            "Coffee",
            "London Liquid Sky",
            "McSkin",
            "The Asphalt World",
            "Liquid Sky",
            "Glass Oceans",
            "Stardust",
            "Xmas 2008 Blue",
            "Valentine"});
      this.lookAndFeel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.lookAndFeel.Size = new System.Drawing.Size(497, 20);
      this.lookAndFeel.TabIndex = 12;
      this.lookAndFeel.SelectedIndexChanged += new System.EventHandler(this.LookAndFeelSelectedIndexChanged);
      // 
      // labelControl3
      // 
      this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Navy;
      this.labelControl3.Location = new System.Drawing.Point(18, 82);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(66, 13);
      this.labelControl3.TabIndex = 11;
      this.labelControl3.Text = "Look and Feel";
      // 
      // PropertieControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.xtraTabControl1);
      this.Name = "PropertieControl";
      this.Size = new System.Drawing.Size(859, 429);
      this.Load += new System.EventHandler(this.PropertieControlLoad);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dbConnectionString.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.user.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.database.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
      this.xtraTabControl1.ResumeLayout(false);
      this.databaseTabPage.ResumeLayout(false);
      this.databaseTabPage.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.compactName.Properties)).EndInit();
      this.userTabPage.ResumeLayout(false);
      this.userTabPage.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.logoEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookAndFeel.Properties)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.MemoEdit dbConnectionString;
    private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    private DevExpress.XtraEditors.TextEdit user;
    private DevExpress.XtraEditors.LabelControl labelControl4;
    private DevExpress.XtraEditors.LabelControl labelControl6;
    private DevExpress.XtraEditors.ComboBoxEdit database;
    private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
    private DevExpress.XtraTab.XtraTabPage userTabPage;
    private DevExpress.XtraTab.XtraTabPage databaseTabPage;
    private DevExpress.XtraEditors.SimpleButton createCompactDb;
    private DevExpress.XtraEditors.SimpleButton checkDatabaseSetting;
    private DevExpress.XtraEditors.LabelControl databaseCheckResult;
    private DevExpress.XtraEditors.TextEdit compactName;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.ComboBoxEdit lookAndFeel;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.LabelControl labelControl7;
    private DevExpress.XtraEditors.TextEdit logoEdit;
    private OpenFileDialog openFileDialog;
  }
}
