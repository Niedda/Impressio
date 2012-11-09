namespace Impressio.Views
{
  partial class StartupWizard
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
      this.wizardControl = new DevExpress.XtraWizard.WizardControl();
      this.validateDatabase = new DevExpress.XtraEditors.LabelControl();
      this.welcomeWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
      this.wizardPagePersonalInformation = new DevExpress.XtraWizard.WizardPage();
      this.logoEdit = new DevExpress.XtraEditors.TextEdit();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.userEdit = new DevExpress.XtraEditors.TextEdit();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.completionWizardPage = new DevExpress.XtraWizard.CompletionWizardPage();
      this.wizardPageDatabase = new DevExpress.XtraWizard.WizardPage();
      this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
      this.createCompact = new DevExpress.XtraEditors.SimpleButton();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.databaseEngine = new DevExpress.XtraEditors.ComboBoxEdit();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.compactName = new DevExpress.XtraEditors.TextEdit();
      this.connectionString = new DevExpress.XtraEditors.MemoEdit();
      ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).BeginInit();
      this.wizardControl.SuspendLayout();
      this.wizardPagePersonalInformation.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.logoEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.userEdit.Properties)).BeginInit();
      this.wizardPageDatabase.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.databaseEngine.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.compactName.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.connectionString.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // wizardControl
      // 
      this.wizardControl.Controls.Add(this.validateDatabase);
      this.wizardControl.Controls.Add(this.welcomeWizardPage);
      this.wizardControl.Controls.Add(this.wizardPagePersonalInformation);
      this.wizardControl.Controls.Add(this.completionWizardPage);
      this.wizardControl.Controls.Add(this.wizardPageDatabase);
      this.wizardControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.wizardControl.Location = new System.Drawing.Point(0, 0);
      this.wizardControl.Name = "wizardControl";
      this.wizardControl.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage,
            this.wizardPagePersonalInformation,
            this.wizardPageDatabase,
            this.completionWizardPage});
      this.wizardControl.Size = new System.Drawing.Size(634, 334);
      // 
      // validateDatabase
      // 
      this.validateDatabase.Location = new System.Drawing.Point(21, 306);
      this.validateDatabase.Name = "validateDatabase";
      this.validateDatabase.Size = new System.Drawing.Size(0, 13);
      this.validateDatabase.TabIndex = 10;
      // 
      // welcomeWizardPage
      // 
      this.welcomeWizardPage.IntroductionText = "Dieser Wizard hilft Ihnen beim aufsetzten Ihrer Impressio Installation.";
      this.welcomeWizardPage.Name = "welcomeWizardPage";
      this.welcomeWizardPage.ProceedText = "";
      this.welcomeWizardPage.Size = new System.Drawing.Size(417, 201);
      this.welcomeWizardPage.Text = "Impressio";
      // 
      // wizardPagePersonalInformation
      // 
      this.wizardPagePersonalInformation.Controls.Add(this.logoEdit);
      this.wizardPagePersonalInformation.Controls.Add(this.labelControl2);
      this.wizardPagePersonalInformation.Controls.Add(this.userEdit);
      this.wizardPagePersonalInformation.Controls.Add(this.labelControl1);
      this.wizardPagePersonalInformation.DescriptionText = "";
      this.wizardPagePersonalInformation.Name = "wizardPagePersonalInformation";
      this.wizardPagePersonalInformation.Size = new System.Drawing.Size(602, 189);
      this.wizardPagePersonalInformation.Text = "Ihre persönlichen Daten";
      this.wizardPagePersonalInformation.Enter += new System.EventHandler(this.WizardPagePersonalInformationEnter);
      // 
      // logoEdit
      // 
      this.logoEdit.Location = new System.Drawing.Point(241, 72);
      this.logoEdit.Name = "logoEdit";
      this.logoEdit.Size = new System.Drawing.Size(341, 20);
      this.logoEdit.TabIndex = 3;
      this.logoEdit.Enter += new System.EventHandler(this.LogoEditEnter);
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(26, 75);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(182, 13);
      this.labelControl2.TabIndex = 2;
      this.labelControl2.Text = "Pfad zum Firmenlogo [250px x 100px]";
      // 
      // userEdit
      // 
      this.userEdit.Location = new System.Drawing.Point(241, 27);
      this.userEdit.Name = "userEdit";
      this.userEdit.Size = new System.Drawing.Size(341, 20);
      this.userEdit.TabIndex = 1;
      this.userEdit.EditValueChanged += new System.EventHandler(this.UserEditEditValueChanged);
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(26, 30);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(108, 13);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Ihr vollständiger Name";
      // 
      // completionWizardPage
      // 
      this.completionWizardPage.FinishText = "Viel Spass mit Ihrer Installation von Impressio";
      this.completionWizardPage.Name = "completionWizardPage";
      this.completionWizardPage.ProceedText = "";
      this.completionWizardPage.Size = new System.Drawing.Size(417, 201);
      this.completionWizardPage.Text = "Wizard erfolgreich beendet";
      // 
      // wizardPageDatabase
      // 
      this.wizardPageDatabase.Controls.Add(this.labelControl6);
      this.wizardPageDatabase.Controls.Add(this.labelControl5);
      this.wizardPageDatabase.Controls.Add(this.createCompact);
      this.wizardPageDatabase.Controls.Add(this.labelControl4);
      this.wizardPageDatabase.Controls.Add(this.databaseEngine);
      this.wizardPageDatabase.Controls.Add(this.labelControl3);
      this.wizardPageDatabase.Controls.Add(this.compactName);
      this.wizardPageDatabase.Controls.Add(this.connectionString);
      this.wizardPageDatabase.DescriptionText = "";
      this.wizardPageDatabase.Name = "wizardPageDatabase";
      this.wizardPageDatabase.Size = new System.Drawing.Size(602, 189);
      this.wizardPageDatabase.Text = "Datenbank konfigurieren";
      this.wizardPageDatabase.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.WizardPageDatabasePageValidating);
      this.wizardPageDatabase.Enter += new System.EventHandler(this.WizardPageDatabaseEnter);
      // 
      // labelControl6
      // 
      this.labelControl6.Location = new System.Drawing.Point(196, 142);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new System.Drawing.Size(99, 13);
      this.labelControl6.TabIndex = 7;
      this.labelControl6.Text = "Name für Datenbank";
      // 
      // labelControl5
      // 
      this.labelControl5.Location = new System.Drawing.Point(24, 142);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new System.Drawing.Size(97, 13);
      this.labelControl5.TabIndex = 6;
      this.labelControl5.Text = "Compact Datenbank";
      // 
      // createCompact
      // 
      this.createCompact.Location = new System.Drawing.Point(471, 138);
      this.createCompact.Name = "createCompact";
      this.createCompact.Size = new System.Drawing.Size(112, 23);
      this.createCompact.TabIndex = 5;
      this.createCompact.Text = "Compact erstellen";
      this.createCompact.Click += new System.EventHandler(this.CreateCompactClick);
      // 
      // labelControl4
      // 
      this.labelControl4.Location = new System.Drawing.Point(24, 102);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(114, 13);
      this.labelControl4.TabIndex = 4;
      this.labelControl4.Text = "Gewünschte Datenbank";
      // 
      // databaseEngine
      // 
      this.databaseEngine.Location = new System.Drawing.Point(196, 99);
      this.databaseEngine.Name = "databaseEngine";
      this.databaseEngine.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.databaseEngine.Properties.Items.AddRange(new object[] {
            "mssql",
            "posql",
            "compact"});
      this.databaseEngine.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.databaseEngine.Size = new System.Drawing.Size(387, 20);
      this.databaseEngine.TabIndex = 3;
      this.databaseEngine.SelectedIndexChanged += new System.EventHandler(this.DatabaseEngineSelectedIndexChanged);
      // 
      // labelControl3
      // 
      this.labelControl3.Location = new System.Drawing.Point(24, 25);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(158, 13);
      this.labelControl3.TabIndex = 2;
      this.labelControl3.Text = "Connection String zur Datenbank";
      // 
      // compactName
      // 
      this.compactName.Location = new System.Drawing.Point(313, 139);
      this.compactName.Name = "compactName";
      this.compactName.Size = new System.Drawing.Size(152, 20);
      this.compactName.TabIndex = 1;
      // 
      // connectionString
      // 
      this.connectionString.Location = new System.Drawing.Point(196, 22);
      this.connectionString.Name = "connectionString";
      this.connectionString.Size = new System.Drawing.Size(387, 58);
      this.connectionString.TabIndex = 0;
      this.connectionString.EditValueChanged += new System.EventHandler(this.ConnectionStringEditValueChanged);
      // 
      // StartupWizard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(634, 334);
      this.ControlBox = false;
      this.Controls.Add(this.wizardControl);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(650, 350);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(650, 350);
      this.Name = "StartupWizard";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).EndInit();
      this.wizardControl.ResumeLayout(false);
      this.wizardControl.PerformLayout();
      this.wizardPagePersonalInformation.ResumeLayout(false);
      this.wizardPagePersonalInformation.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.logoEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.userEdit.Properties)).EndInit();
      this.wizardPageDatabase.ResumeLayout(false);
      this.wizardPageDatabase.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.databaseEngine.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.compactName.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.connectionString.Properties)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraWizard.WizardControl wizardControl;
    private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage;
    private DevExpress.XtraWizard.WizardPage wizardPagePersonalInformation;
    private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage;
    private DevExpress.XtraEditors.TextEdit userEdit;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.TextEdit logoEdit;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraWizard.WizardPage wizardPageDatabase;
    private DevExpress.XtraEditors.LabelControl labelControl6;
    private DevExpress.XtraEditors.LabelControl labelControl5;
    private DevExpress.XtraEditors.SimpleButton createCompact;
    private DevExpress.XtraEditors.LabelControl labelControl4;
    private DevExpress.XtraEditors.ComboBoxEdit databaseEngine;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.TextEdit compactName;
    private DevExpress.XtraEditors.MemoEdit connectionString;
    private DevExpress.XtraEditors.LabelControl validateDatabase;
  }
}