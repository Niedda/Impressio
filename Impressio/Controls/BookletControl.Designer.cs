namespace Impressio.Controls
{
  partial class BookletControl
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
      this.components = new System.ComponentModel.Container();
      this.bookletWizard = new DevExpress.XtraWizard.WizardControl();
      this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
      this.firstPage = new DevExpress.XtraWizard.WizardPage();
      this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.pageSpin = new DevExpress.XtraEditors.SpinEdit();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.sizeL = new DevExpress.XtraEditors.SpinEdit();
      this.sizeB = new DevExpress.XtraEditors.SpinEdit();
      this.sizeCombo = new DevExpress.XtraEditors.ComboBoxEdit();
      this.pageOverview = new DevExpress.XtraWizard.WizardPage();
      this.gridPages = new DevExpress.XtraGrid.GridControl();
      this.viewPages = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colColorFront = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colColorBack = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPrintMachine = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colEditAll = new DevExpress.XtraGrid.Columns.GridColumn();
      this.changeAllCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
      this.searchLookUpMachine = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
      this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.machineBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colIdentityColumn = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTable = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPricePerColor = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colSpeed = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPricePerHour = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPlateCost = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDatabase = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colColorChange = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPlateChange = new DevExpress.XtraGrid.Columns.GridColumn();
      this.plateCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
      this.colorCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
      this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.colTurn = new DevExpress.XtraGrid.Columns.GridColumn();
      this.turnCombo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.bookletWizard)).BeginInit();
      this.bookletWizard.SuspendLayout();
      this.firstPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pageSpin.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sizeL.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sizeB.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sizeCombo.Properties)).BeginInit();
      this.pageOverview.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridPages)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewPages)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.changeAllCheck)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.searchLookUpMachine)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.machineBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.plateCheck)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.colorCheck)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.turnCombo)).BeginInit();
      this.SuspendLayout();
      // 
      // bookletWizard
      // 
      this.bookletWizard.Controls.Add(this.welcomeWizardPage1);
      this.bookletWizard.Controls.Add(this.firstPage);
      this.bookletWizard.Controls.Add(this.completionWizardPage1);
      this.bookletWizard.Controls.Add(this.pageOverview);
      this.bookletWizard.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bookletWizard.Location = new System.Drawing.Point(0, 0);
      this.bookletWizard.Name = "bookletWizard";
      this.bookletWizard.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.firstPage,
            this.pageOverview,
            this.completionWizardPage1});
      this.bookletWizard.Size = new System.Drawing.Size(645, 392);
      this.bookletWizard.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
      // 
      // welcomeWizardPage1
      // 
      this.welcomeWizardPage1.Name = "welcomeWizardPage1";
      this.welcomeWizardPage1.Size = new System.Drawing.Size(585, 230);
      // 
      // firstPage
      // 
      this.firstPage.Controls.Add(this.spinEdit1);
      this.firstPage.Controls.Add(this.labelControl4);
      this.firstPage.Controls.Add(this.comboBoxEdit1);
      this.firstPage.Controls.Add(this.labelControl3);
      this.firstPage.Controls.Add(this.sizeCombo);
      this.firstPage.Controls.Add(this.sizeB);
      this.firstPage.Controls.Add(this.sizeL);
      this.firstPage.Controls.Add(this.labelControl2);
      this.firstPage.Controls.Add(this.pageSpin);
      this.firstPage.Controls.Add(this.labelControl1);
      this.firstPage.DescriptionText = "";
      this.firstPage.Name = "firstPage";
      this.firstPage.Size = new System.Drawing.Size(585, 230);
      this.firstPage.Text = "Anzahl Seiten";
      // 
      // completionWizardPage1
      // 
      this.completionWizardPage1.Name = "completionWizardPage1";
      this.completionWizardPage1.Size = new System.Drawing.Size(585, 230);
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(25, 22);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(65, 13);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Anzahl Seiten";
      // 
      // pageSpin
      // 
      this.pageSpin.EditValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
      this.pageSpin.Location = new System.Drawing.Point(162, 23);
      this.pageSpin.Name = "pageSpin";
      this.pageSpin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.pageSpin.Properties.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
      this.pageSpin.Properties.IsFloatValue = false;
      this.pageSpin.Properties.Mask.EditMask = "N00";
      this.pageSpin.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
      this.pageSpin.Properties.MinValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
      this.pageSpin.Size = new System.Drawing.Size(94, 20);
      this.pageSpin.TabIndex = 1;
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(25, 67);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(50, 13);
      this.labelControl2.TabIndex = 2;
      this.labelControl2.Text = "Endformat";
      // 
      // sizeL
      // 
      this.sizeL.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.sizeL.Location = new System.Drawing.Point(162, 66);
      this.sizeL.Name = "sizeL";
      this.sizeL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.sizeL.Properties.IsFloatValue = false;
      this.sizeL.Properties.Mask.EditMask = "N00";
      this.sizeL.Size = new System.Drawing.Size(94, 20);
      this.sizeL.TabIndex = 3;
      // 
      // sizeB
      // 
      this.sizeB.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.sizeB.Location = new System.Drawing.Point(275, 66);
      this.sizeB.Name = "sizeB";
      this.sizeB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.sizeB.Properties.IsFloatValue = false;
      this.sizeB.Properties.Mask.EditMask = "N00";
      this.sizeB.Size = new System.Drawing.Size(94, 20);
      this.sizeB.TabIndex = 4;
      // 
      // sizeCombo
      // 
      this.sizeCombo.Location = new System.Drawing.Point(393, 66);
      this.sizeCombo.Name = "sizeCombo";
      this.sizeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.sizeCombo.Properties.Items.AddRange(new object[] {
            "A6",
            "A5",
            "A4",
            "A3"});
      this.sizeCombo.Size = new System.Drawing.Size(100, 20);
      this.sizeCombo.TabIndex = 5;
      // 
      // pageOverview
      // 
      this.pageOverview.Controls.Add(this.gridPages);
      this.pageOverview.Name = "pageOverview";
      this.pageOverview.Size = new System.Drawing.Size(585, 230);
      this.pageOverview.Text = "Bogenübersicht";
      // 
      // gridPages
      // 
      this.gridPages.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridPages.Location = new System.Drawing.Point(0, 0);
      this.gridPages.MainView = this.viewPages;
      this.gridPages.Name = "gridPages";
      this.gridPages.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.changeAllCheck,
            this.searchLookUpMachine,
            this.plateCheck,
            this.colorCheck,
            this.turnCombo});
      this.gridPages.Size = new System.Drawing.Size(585, 230);
      this.gridPages.TabIndex = 0;
      this.gridPages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewPages});
      // 
      // viewPages
      // 
      this.viewPages.ColumnPanelRowHeight = 30;
      this.viewPages.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colColorFront,
            this.colColorBack,
            this.colPrintMachine,
            this.colEditAll,
            this.colColorChange,
            this.colPlateChange,
            this.colTurn});
      this.viewPages.GridControl = this.gridPages;
      this.viewPages.GroupRowHeight = 30;
      this.viewPages.IndicatorWidth = 30;
      this.viewPages.Name = "viewPages";
      this.viewPages.OptionsView.ShowGroupPanel = false;
      this.viewPages.RowHeight = 30;
      this.viewPages.ViewCaptionHeight = 30;
      // 
      // colColorFront
      // 
      this.colColorFront.Caption = "Farben Vorderseite";
      this.colColorFront.FieldName = "colColorFront";
      this.colColorFront.Name = "colColorFront";
      this.colColorFront.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
      this.colColorFront.Visible = true;
      this.colColorFront.VisibleIndex = 0;
      // 
      // colColorBack
      // 
      this.colColorBack.Caption = "Farben Rückseite";
      this.colColorBack.FieldName = "colColorBack";
      this.colColorBack.Name = "colColorBack";
      this.colColorBack.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
      this.colColorBack.Visible = true;
      this.colColorBack.VisibleIndex = 1;
      // 
      // colPrintMachine
      // 
      this.colPrintMachine.Caption = "Druckmaschine";
      this.colPrintMachine.Name = "colPrintMachine";
      this.colPrintMachine.Visible = true;
      this.colPrintMachine.VisibleIndex = 2;
      // 
      // colEditAll
      // 
      this.colEditAll.Caption = "Alle Bogen editieren";
      this.colEditAll.ColumnEdit = this.changeAllCheck;
      this.colEditAll.Name = "colEditAll";
      this.colEditAll.Visible = true;
      this.colEditAll.VisibleIndex = 6;
      // 
      // changeAllCheck
      // 
      this.changeAllCheck.AutoHeight = false;
      this.changeAllCheck.Name = "changeAllCheck";
      // 
      // searchLookUpMachine
      // 
      this.searchLookUpMachine.AutoHeight = false;
      this.searchLookUpMachine.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.searchLookUpMachine.DataSource = this.machineBindingSource;
      this.searchLookUpMachine.DisplayMember = "Name";
      this.searchLookUpMachine.Name = "searchLookUpMachine";
      this.searchLookUpMachine.NullText = "";
      this.searchLookUpMachine.ValueMember = "Identity";
      this.searchLookUpMachine.View = this.repositoryItemSearchLookUpEdit1View;
      // 
      // repositoryItemSearchLookUpEdit1View
      // 
      this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colIdentityColumn,
            this.colTable,
            this.colPricePerColor,
            this.colSpeed,
            this.colPricePerHour,
            this.colName,
            this.colPlateCost,
            this.colDatabase});
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      // 
      // machineBindingSource
      // 
      this.machineBindingSource.DataSource = typeof(Impressio.Models.Machine);
      // 
      // colIdentity
      // 
      this.colIdentity.FieldName = "Identity";
      this.colIdentity.Name = "colIdentity";
      // 
      // colIdentityColumn
      // 
      this.colIdentityColumn.FieldName = "IdentityColumn";
      this.colIdentityColumn.Name = "colIdentityColumn";
      this.colIdentityColumn.OptionsColumn.ReadOnly = true;
      // 
      // colTable
      // 
      this.colTable.FieldName = "Table";
      this.colTable.Name = "colTable";
      this.colTable.OptionsColumn.ReadOnly = true;
      // 
      // colPricePerColor
      // 
      this.colPricePerColor.Caption = "Farbwechsel";
      this.colPricePerColor.FieldName = "PricePerColor";
      this.colPricePerColor.Name = "colPricePerColor";
      this.colPricePerColor.Visible = true;
      this.colPricePerColor.VisibleIndex = 1;
      // 
      // colSpeed
      // 
      this.colSpeed.Caption = "Geschwindigkeit";
      this.colSpeed.FieldName = "Speed";
      this.colSpeed.Name = "colSpeed";
      this.colSpeed.Visible = true;
      this.colSpeed.VisibleIndex = 2;
      // 
      // colPricePerHour
      // 
      this.colPricePerHour.Caption = "Stundensatz";
      this.colPricePerHour.FieldName = "PricePerHour";
      this.colPricePerHour.Name = "colPricePerHour";
      this.colPricePerHour.Visible = true;
      this.colPricePerHour.VisibleIndex = 4;
      // 
      // colName
      // 
      this.colName.Caption = "Name";
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // colPlateCost
      // 
      this.colPlateCost.Caption = "Platenkosten";
      this.colPlateCost.FieldName = "PlateCost";
      this.colPlateCost.Name = "colPlateCost";
      this.colPlateCost.Visible = true;
      this.colPlateCost.VisibleIndex = 3;
      // 
      // colDatabase
      // 
      this.colDatabase.FieldName = "Database";
      this.colDatabase.Name = "colDatabase";
      this.colDatabase.OptionsColumn.ReadOnly = true;
      // 
      // colColorChange
      // 
      this.colColorChange.Caption = "Farbwechsel";
      this.colColorChange.ColumnEdit = this.colorCheck;
      this.colColorChange.Name = "colColorChange";
      this.colColorChange.Visible = true;
      this.colColorChange.VisibleIndex = 4;
      // 
      // colPlateChange
      // 
      this.colPlateChange.Caption = "Plattenwechsel";
      this.colPlateChange.ColumnEdit = this.plateCheck;
      this.colPlateChange.Name = "colPlateChange";
      this.colPlateChange.Visible = true;
      this.colPlateChange.VisibleIndex = 5;
      // 
      // plateCheck
      // 
      this.plateCheck.AutoHeight = false;
      this.plateCheck.Name = "plateCheck";
      // 
      // colorCheck
      // 
      this.colorCheck.AutoHeight = false;
      this.colorCheck.Name = "colorCheck";
      // 
      // labelControl3
      // 
      this.labelControl3.Location = new System.Drawing.Point(25, 112);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(63, 13);
      this.labelControl3.TabIndex = 6;
      this.labelControl3.Text = "Format offen";
      // 
      // comboBoxEdit1
      // 
      this.comboBoxEdit1.Location = new System.Drawing.Point(162, 109);
      this.comboBoxEdit1.Name = "comboBoxEdit1";
      this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.comboBoxEdit1.Size = new System.Drawing.Size(207, 20);
      this.comboBoxEdit1.TabIndex = 7;
      // 
      // spinEdit1
      // 
      this.spinEdit1.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.spinEdit1.Location = new System.Drawing.Point(162, 155);
      this.spinEdit1.Name = "spinEdit1";
      this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.spinEdit1.Properties.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
      this.spinEdit1.Properties.IsFloatValue = false;
      this.spinEdit1.Properties.Mask.EditMask = "N00";
      this.spinEdit1.Properties.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.spinEdit1.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.spinEdit1.Size = new System.Drawing.Size(94, 20);
      this.spinEdit1.TabIndex = 9;
      // 
      // labelControl4
      // 
      this.labelControl4.Location = new System.Drawing.Point(25, 157);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(92, 13);
      this.labelControl4.TabIndex = 8;
      this.labelControl4.Text = "Anzahl Druckbogen";
      // 
      // colTurn
      // 
      this.colTurn.Caption = "Wendung";
      this.colTurn.ColumnEdit = this.turnCombo;
      this.colTurn.Name = "colTurn";
      this.colTurn.Visible = true;
      this.colTurn.VisibleIndex = 3;
      // 
      // turnCombo
      // 
      this.turnCombo.AutoHeight = false;
      this.turnCombo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.turnCombo.Items.AddRange(new object[] {
            "SD / WD",
            "Umschlagen",
            "Umstülpen",
            "SD / WD in einem Durchgang"});
      this.turnCombo.Name = "turnCombo";
      // 
      // BookletControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.bookletWizard);
      this.Name = "BookletControl";
      this.Size = new System.Drawing.Size(645, 392);
      ((System.ComponentModel.ISupportInitialize)(this.bookletWizard)).EndInit();
      this.bookletWizard.ResumeLayout(false);
      this.firstPage.ResumeLayout(false);
      this.firstPage.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pageSpin.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sizeL.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sizeB.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sizeCombo.Properties)).EndInit();
      this.pageOverview.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridPages)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewPages)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.changeAllCheck)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.searchLookUpMachine)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.machineBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.plateCheck)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.colorCheck)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.turnCombo)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraWizard.WizardControl bookletWizard;
    private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
    private DevExpress.XtraWizard.WizardPage firstPage;
    private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
    private DevExpress.XtraEditors.ComboBoxEdit sizeCombo;
    private DevExpress.XtraEditors.SpinEdit sizeB;
    private DevExpress.XtraEditors.SpinEdit sizeL;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.SpinEdit pageSpin;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraWizard.WizardPage pageOverview;
    private DevExpress.XtraGrid.GridControl gridPages;
    private DevExpress.XtraGrid.Views.Grid.GridView viewPages;
    private DevExpress.XtraGrid.Columns.GridColumn colColorFront;
    private DevExpress.XtraGrid.Columns.GridColumn colColorBack;
    private DevExpress.XtraGrid.Columns.GridColumn colPrintMachine;
    private DevExpress.XtraGrid.Columns.GridColumn colEditAll;
    private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit changeAllCheck;
    private DevExpress.XtraEditors.SpinEdit spinEdit1;
    private DevExpress.XtraEditors.LabelControl labelControl4;
    private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraGrid.Columns.GridColumn colColorChange;
    private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit colorCheck;
    private DevExpress.XtraGrid.Columns.GridColumn colPlateChange;
    private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit plateCheck;
    private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit searchLookUpMachine;
    private System.Windows.Forms.BindingSource machineBindingSource;
    private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentityColumn;
    private DevExpress.XtraGrid.Columns.GridColumn colTable;
    private DevExpress.XtraGrid.Columns.GridColumn colPricePerColor;
    private DevExpress.XtraGrid.Columns.GridColumn colSpeed;
    private DevExpress.XtraGrid.Columns.GridColumn colPricePerHour;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colPlateCost;
    private DevExpress.XtraGrid.Columns.GridColumn colDatabase;
    private DevExpress.XtraGrid.Columns.GridColumn colTurn;
    private DevExpress.XtraEditors.Repository.RepositoryItemComboBox turnCombo;
  }
}
