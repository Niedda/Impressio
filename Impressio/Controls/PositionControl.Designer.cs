using Impressio.Models;

namespace Impressio.Controls
{
    partial class PositionControl
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
      this.gridPosition = new DevExpress.XtraGrid.GridControl();
      this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.viewPosition = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.predefinedCombo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
      this.colFkOrder = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPriceTotal = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
      this.typeCombo = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
      this.colIsPredefined = new DevExpress.XtraGrid.Columns.GridColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.userEdited = new DevExpress.XtraEditors.TextEdit();
      this.userCreated = new DevExpress.XtraEditors.TextEdit();
      this.dateEdited = new DevExpress.XtraEditors.TextEdit();
      this.dateCreated = new DevExpress.XtraEditors.TextEdit();
      this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
      this.orderNameEdit = new DevExpress.XtraEditors.TextEdit();
      this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.stateLookUp = new DevExpress.XtraEditors.LookUpEdit();
      this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.addressLookUp = new DevExpress.XtraEditors.LookUpEdit();
      this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.clientLookUp = new DevExpress.XtraEditors.LookUpEdit();
      this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridPosition)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewPosition)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.predefinedCombo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.typeCombo)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.userEdited.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.userCreated.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateEdited.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateCreated.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderNameEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateLookUp.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressLookUp.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.clientLookUp.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // gridPosition
      // 
      this.gridPosition.DataSource = this.positionBindingSource;
      this.gridPosition.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridPosition.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gridPosition.Location = new System.Drawing.Point(0, 229);
      this.gridPosition.MainView = this.viewPosition;
      this.gridPosition.Name = "gridPosition";
      this.gridPosition.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.predefinedCombo,
            this.typeCombo});
      this.gridPosition.Size = new System.Drawing.Size(790, 118);
      this.gridPosition.TabIndex = 0;
      this.gridPosition.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewPosition});
      // 
      // positionBindingSource
      // 
      this.positionBindingSource.DataSource = typeof(Impressio.Models.Position);
      // 
      // viewPosition
      // 
      this.viewPosition.ColumnPanelRowHeight = 30;
      this.viewPosition.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colName,
            this.colFkOrder,
            this.colPriceTotal,
            this.colType,
            this.colIsPredefined});
      this.viewPosition.GridControl = this.gridPosition;
      this.viewPosition.IndicatorWidth = 50;
      this.viewPosition.Name = "viewPosition";
      this.viewPosition.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
      this.viewPosition.OptionsDetail.EnableMasterViewMode = false;
      this.viewPosition.OptionsDetail.ShowDetailTabs = false;
      this.viewPosition.OptionsDetail.SmartDetailExpand = false;
      this.viewPosition.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.viewPosition.OptionsView.ShowDetailButtons = false;
      this.viewPosition.OptionsView.ShowGroupPanel = false;
      this.viewPosition.RowHeight = 30;
      this.viewPosition.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.ViewPositionInitNewRow);
      this.viewPosition.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ViewPositionFocusedRowChanged);
      // 
      // colIdentity
      // 
      this.colIdentity.FieldName = "Identity";
      this.colIdentity.Name = "colIdentity";
      // 
      // colName
      // 
      this.colName.ColumnEdit = this.predefinedCombo;
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // predefinedCombo
      // 
      this.predefinedCombo.AutoComplete = false;
      this.predefinedCombo.AutoHeight = false;
      this.predefinedCombo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.predefinedCombo.Name = "predefinedCombo";
      this.predefinedCombo.Tag = "<Null>";
      this.predefinedCombo.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.PredefinedComboEditValueChanging);
      // 
      // colFkOrder
      // 
      this.colFkOrder.FieldName = "FkOrder";
      this.colFkOrder.Name = "colFkOrder";
      // 
      // colPriceTotal
      // 
      this.colPriceTotal.Caption = "Total Position";
      this.colPriceTotal.DisplayFormat.FormatString = "c";
      this.colPriceTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colPriceTotal.FieldName = "PriceTotal";
      this.colPriceTotal.Name = "colPriceTotal";
      this.colPriceTotal.OptionsColumn.AllowEdit = false;
      this.colPriceTotal.Visible = true;
      this.colPriceTotal.VisibleIndex = 2;
      // 
      // colType
      // 
      this.colType.Caption = "Typ";
      this.colType.ColumnEdit = this.typeCombo;
      this.colType.FieldName = "Type";
      this.colType.Name = "colType";
      this.colType.Visible = true;
      this.colType.VisibleIndex = 1;
      // 
      // typeCombo
      // 
      this.typeCombo.AutoHeight = false;
      this.typeCombo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.typeCombo.DropDownRows = 4;
      this.typeCombo.Name = "typeCombo";
      this.typeCombo.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.TypeComboEditValueChanging);
      // 
      // colIsPredefined
      // 
      this.colIsPredefined.FieldName = "IsPredefined";
      this.colIsPredefined.Name = "colIsPredefined";
      this.colIsPredefined.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.userEdited);
      this.groupBox1.Controls.Add(this.userCreated);
      this.groupBox1.Controls.Add(this.dateEdited);
      this.groupBox1.Controls.Add(this.dateCreated);
      this.groupBox1.Controls.Add(this.labelControl8);
      this.groupBox1.Controls.Add(this.labelControl7);
      this.groupBox1.Controls.Add(this.labelControl6);
      this.groupBox1.Controls.Add(this.labelControl5);
      this.groupBox1.Controls.Add(this.orderNameEdit);
      this.groupBox1.Controls.Add(this.labelControl4);
      this.groupBox1.Controls.Add(this.stateLookUp);
      this.groupBox1.Controls.Add(this.labelControl3);
      this.groupBox1.Controls.Add(this.labelControl2);
      this.groupBox1.Controls.Add(this.labelControl1);
      this.groupBox1.Controls.Add(this.addressLookUp);
      this.groupBox1.Controls.Add(this.clientLookUp);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(790, 229);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Auftragsdetails";
      // 
      // userEdited
      // 
      this.userEdited.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "UserModified", true));
      this.userEdited.Enabled = false;
      this.userEdited.Location = new System.Drawing.Point(584, 133);
      this.userEdited.Name = "userEdited";
      this.userEdited.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.userEdited.Properties.Appearance.Options.UseFont = true;
      this.userEdited.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
      this.userEdited.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
      this.userEdited.Properties.AppearanceDisabled.Options.UseBackColor = true;
      this.userEdited.Properties.AppearanceDisabled.Options.UseForeColor = true;
      this.userEdited.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White;
      this.userEdited.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black;
      this.userEdited.Properties.AppearanceFocused.Options.UseBackColor = true;
      this.userEdited.Properties.AppearanceFocused.Options.UseForeColor = true;
      this.userEdited.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
      this.userEdited.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
      this.userEdited.Properties.AppearanceReadOnly.Options.UseBackColor = true;
      this.userEdited.Properties.AppearanceReadOnly.Options.UseForeColor = true;
      this.userEdited.Properties.ReadOnly = true;
      this.userEdited.Size = new System.Drawing.Size(162, 20);
      this.userEdited.TabIndex = 22;
      // 
      // userCreated
      // 
      this.userCreated.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "UserCreated", true));
      this.userCreated.Enabled = false;
      this.userCreated.Location = new System.Drawing.Point(584, 34);
      this.userCreated.Name = "userCreated";
      this.userCreated.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.userCreated.Properties.Appearance.Options.UseFont = true;
      this.userCreated.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
      this.userCreated.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
      this.userCreated.Properties.AppearanceDisabled.Options.UseBackColor = true;
      this.userCreated.Properties.AppearanceDisabled.Options.UseForeColor = true;
      this.userCreated.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White;
      this.userCreated.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black;
      this.userCreated.Properties.AppearanceFocused.Options.UseBackColor = true;
      this.userCreated.Properties.AppearanceFocused.Options.UseForeColor = true;
      this.userCreated.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
      this.userCreated.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
      this.userCreated.Properties.AppearanceReadOnly.Options.UseBackColor = true;
      this.userCreated.Properties.AppearanceReadOnly.Options.UseForeColor = true;
      this.userCreated.Properties.ReadOnly = true;
      this.userCreated.Size = new System.Drawing.Size(162, 20);
      this.userCreated.TabIndex = 21;
      // 
      // dateEdited
      // 
      this.dateEdited.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "DateModified", true));
      this.dateEdited.Enabled = false;
      this.dateEdited.Location = new System.Drawing.Point(584, 186);
      this.dateEdited.Name = "dateEdited";
      this.dateEdited.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dateEdited.Properties.Appearance.Options.UseFont = true;
      this.dateEdited.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
      this.dateEdited.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
      this.dateEdited.Properties.AppearanceDisabled.Options.UseBackColor = true;
      this.dateEdited.Properties.AppearanceDisabled.Options.UseForeColor = true;
      this.dateEdited.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White;
      this.dateEdited.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black;
      this.dateEdited.Properties.AppearanceFocused.Options.UseBackColor = true;
      this.dateEdited.Properties.AppearanceFocused.Options.UseForeColor = true;
      this.dateEdited.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
      this.dateEdited.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
      this.dateEdited.Properties.AppearanceReadOnly.Options.UseBackColor = true;
      this.dateEdited.Properties.AppearanceReadOnly.Options.UseForeColor = true;
      this.dateEdited.Properties.ReadOnly = true;
      this.dateEdited.Size = new System.Drawing.Size(162, 20);
      this.dateEdited.TabIndex = 20;
      // 
      // dateCreated
      // 
      this.dateCreated.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "DateCreated", true));
      this.dateCreated.Enabled = false;
      this.dateCreated.Location = new System.Drawing.Point(584, 80);
      this.dateCreated.Name = "dateCreated";
      this.dateCreated.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dateCreated.Properties.Appearance.Options.UseFont = true;
      this.dateCreated.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
      this.dateCreated.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
      this.dateCreated.Properties.AppearanceDisabled.Options.UseBackColor = true;
      this.dateCreated.Properties.AppearanceDisabled.Options.UseForeColor = true;
      this.dateCreated.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White;
      this.dateCreated.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black;
      this.dateCreated.Properties.AppearanceFocused.Options.UseBackColor = true;
      this.dateCreated.Properties.AppearanceFocused.Options.UseForeColor = true;
      this.dateCreated.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
      this.dateCreated.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
      this.dateCreated.Properties.AppearanceReadOnly.Options.UseBackColor = true;
      this.dateCreated.Properties.AppearanceReadOnly.Options.UseForeColor = true;
      this.dateCreated.Properties.ReadOnly = true;
      this.dateCreated.Size = new System.Drawing.Size(162, 20);
      this.dateCreated.TabIndex = 19;
      // 
      // labelControl8
      // 
      this.labelControl8.Location = new System.Drawing.Point(473, 136);
      this.labelControl8.Name = "labelControl8";
      this.labelControl8.Size = new System.Drawing.Size(91, 13);
      this.labelControl8.TabIndex = 18;
      this.labelControl8.Text = "Zuletzt editiert von";
      // 
      // labelControl7
      // 
      this.labelControl7.Location = new System.Drawing.Point(473, 37);
      this.labelControl7.Name = "labelControl7";
      this.labelControl7.Size = new System.Drawing.Size(39, 13);
      this.labelControl7.TabIndex = 17;
      this.labelControl7.Text = "Ersteller";
      // 
      // labelControl6
      // 
      this.labelControl6.Location = new System.Drawing.Point(473, 189);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new System.Drawing.Size(70, 13);
      this.labelControl6.TabIndex = 16;
      this.labelControl6.Text = "Zuletzt editiert";
      // 
      // labelControl5
      // 
      this.labelControl5.Location = new System.Drawing.Point(473, 83);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new System.Drawing.Size(82, 13);
      this.labelControl5.TabIndex = 15;
      this.labelControl5.Text = "Erstellungsdatum";
      // 
      // orderNameEdit
      // 
      this.orderNameEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.orderNameEdit.Location = new System.Drawing.Point(129, 34);
      this.orderNameEdit.Name = "orderNameEdit";
      this.orderNameEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.orderNameEdit.Properties.Appearance.Options.UseFont = true;
      this.orderNameEdit.Size = new System.Drawing.Size(295, 20);
      this.orderNameEdit.TabIndex = 7;
      // 
      // orderBindingSource
      // 
      this.orderBindingSource.DataSource = typeof(Impressio.Models.Order);
      // 
      // labelControl4
      // 
      this.labelControl4.Location = new System.Drawing.Point(20, 37);
      this.labelControl4.Margin = new System.Windows.Forms.Padding(20);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(68, 13);
      this.labelControl4.TabIndex = 14;
      this.labelControl4.Text = "Auftragsname";
      // 
      // stateLookUp
      // 
      this.stateLookUp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderBindingSource, "FkOrderState", true));
      this.stateLookUp.Location = new System.Drawing.Point(129, 186);
      this.stateLookUp.Name = "stateLookUp";
      this.stateLookUp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.stateLookUp.Properties.Appearance.Options.UseFont = true;
      this.stateLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.stateLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Identity", "Identity", 61, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StateName", "Status", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
      this.stateLookUp.Properties.DataSource = this.stateBindingSource;
      this.stateLookUp.Properties.DisplayMember = "StateName";
      this.stateLookUp.Properties.DropDownRows = 8;
      this.stateLookUp.Properties.NullText = "";
      this.stateLookUp.Properties.ShowFooter = false;
      this.stateLookUp.Properties.ShowHeader = false;
      this.stateLookUp.Properties.ValueMember = "Identity";
      this.stateLookUp.Size = new System.Drawing.Size(295, 20);
      this.stateLookUp.TabIndex = 12;
      // 
      // stateBindingSource
      // 
      this.stateBindingSource.DataSource = typeof(Impressio.Models.State);
      // 
      // labelControl3
      // 
      this.labelControl3.Location = new System.Drawing.Point(20, 189);
      this.labelControl3.Margin = new System.Windows.Forms.Padding(20);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(31, 13);
      this.labelControl3.TabIndex = 13;
      this.labelControl3.Text = "Status";
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(20, 136);
      this.labelControl2.Margin = new System.Windows.Forms.Padding(20);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(91, 13);
      this.labelControl2.TabIndex = 10;
      this.labelControl2.Text = "Rechnungsadresse";
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(20, 83);
      this.labelControl1.Margin = new System.Windows.Forms.Padding(20);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(89, 13);
      this.labelControl1.TabIndex = 8;
      this.labelControl1.Text = "Zuständige Person";
      // 
      // addressLookUp
      // 
      this.addressLookUp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderBindingSource, "FkOrderAddress", true));
      this.addressLookUp.Location = new System.Drawing.Point(129, 133);
      this.addressLookUp.Name = "addressLookUp";
      this.addressLookUp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addressLookUp.Properties.Appearance.Options.UseFont = true;
      this.addressLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.addressLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Identity", "Identity", 61, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.False),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FkAddressCompany", "Fk Address Company", 111, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.False),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Street", "Strasse", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StreetNumber", "Str. Nummer", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ZipCode", "Post Code", 52, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("City", "Ortschaft", 29, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Addition", "Zusatz", 49, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullAddress", "Full Address", 68, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.False)});
      this.addressLookUp.Properties.DataSource = this.addressBindingSource;
      this.addressLookUp.Properties.DisplayMember = "FullAddress";
      this.addressLookUp.Properties.NullText = "-- keine Adresse ausgewählt --";
      this.addressLookUp.Properties.PopupFormMinSize = new System.Drawing.Size(400, 100);
      this.addressLookUp.Properties.ValueMember = "Identity";
      this.addressLookUp.Size = new System.Drawing.Size(295, 20);
      this.addressLookUp.TabIndex = 11;
      // 
      // addressBindingSource
      // 
      this.addressBindingSource.DataSource = typeof(Impressio.Models.Address);
      // 
      // clientLookUp
      // 
      this.clientLookUp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderBindingSource, "FkOrderClient", true));
      this.clientLookUp.Location = new System.Drawing.Point(129, 80);
      this.clientLookUp.Name = "clientLookUp";
      this.clientLookUp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.clientLookUp.Properties.Appearance.Options.UseFont = true;
      this.clientLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.clientLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Identity", "Identity", 61, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FkClientCompany", "Fk Client Company", 99, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Name", 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FirstName", "Vorname", 61, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LastName", "Nachname", 60, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Phone", "Telefon", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mobile", "Mobile", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mail", "E-Mail", 28, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "Bemerkung", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
      this.clientLookUp.Properties.DataSource = this.clientBindingSource;
      this.clientLookUp.Properties.DisplayMember = "FullName";
      this.clientLookUp.Properties.NullText = "-- keine Person ausgewählt --";
      this.clientLookUp.Properties.PopupFormMinSize = new System.Drawing.Size(400, 100);
      this.clientLookUp.Properties.ValueMember = "Identity";
      this.clientLookUp.Size = new System.Drawing.Size(295, 20);
      this.clientLookUp.TabIndex = 9;
      // 
      // clientBindingSource
      // 
      this.clientBindingSource.DataSource = typeof(Impressio.Models.Client);
      // 
      // PositionControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridPosition);
      this.Controls.Add(this.groupBox1);
      this.Name = "PositionControl";
      this.Size = new System.Drawing.Size(790, 347);
      this.Validated += new System.EventHandler(this.PositionControlValidated);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridPosition)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewPosition)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.predefinedCombo)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.typeCombo)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.userEdited.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.userCreated.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateEdited.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateCreated.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderNameEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateLookUp.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressLookUp.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.clientLookUp.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit orderNameEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit stateLookUp;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit addressLookUp;
        private DevExpress.XtraEditors.LookUpEdit clientLookUp;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DevExpress.XtraEditors.TextEdit userEdited;
        private DevExpress.XtraEditors.TextEdit userCreated;
        private DevExpress.XtraEditors.TextEdit dateEdited;
        private DevExpress.XtraEditors.TextEdit dateCreated;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraGrid.GridControl gridPosition;
        public DevExpress.XtraGrid.Views.Grid.GridView viewPosition;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colFkOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox predefinedCombo;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPredefined;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox typeCombo;
        private System.Windows.Forms.BindingSource orderBindingSource;
    }
}
