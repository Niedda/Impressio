using Impressio.Models;

namespace Impressio.Controls
{
    partial class DeliveryControl
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
      this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.deliveryDate = new DevExpress.XtraEditors.DateEdit();
      this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.addressLookUp = new DevExpress.XtraEditors.LookUpEdit();
      this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.clientLookUp = new DevExpress.XtraEditors.LookUpEdit();
      this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridDeliveryPosition = new DevExpress.XtraGrid.GridControl();
      this.deliveryPositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.viewDeliveryPosition = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTable = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFkDeliveryPositionDelivery = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
      this.positionComboEdit = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
      this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
      this.groupControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.deliveryDate.Properties.VistaTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.deliveryDate.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressLookUp.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.clientLookUp.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridDeliveryPosition)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.deliveryPositionBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewDeliveryPosition)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.positionComboEdit)).BeginInit();
      this.SuspendLayout();
      // 
      // groupControl1
      // 
      this.groupControl1.Controls.Add(this.labelControl3);
      this.groupControl1.Controls.Add(this.labelControl2);
      this.groupControl1.Controls.Add(this.labelControl1);
      this.groupControl1.Controls.Add(this.deliveryDate);
      this.groupControl1.Controls.Add(this.addressLookUp);
      this.groupControl1.Controls.Add(this.clientLookUp);
      this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupControl1.Location = new System.Drawing.Point(0, 0);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new System.Drawing.Size(790, 156);
      this.groupControl1.TabIndex = 0;
      this.groupControl1.Text = "Details Lieferschein";
      // 
      // labelControl3
      // 
      this.labelControl3.Location = new System.Drawing.Point(15, 118);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(57, 13);
      this.labelControl3.TabIndex = 5;
      this.labelControl3.Text = "Lieferdatum";
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(15, 82);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(39, 13);
      this.labelControl2.TabIndex = 4;
      this.labelControl2.Text = "Adresse";
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(15, 46);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(33, 13);
      this.labelControl1.TabIndex = 3;
      this.labelControl1.Text = "Person";
      // 
      // deliveryDate
      // 
      this.deliveryDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.deliveryBindingSource, "DeliveryDate", true));
      this.deliveryDate.EditValue = null;
      this.deliveryDate.Location = new System.Drawing.Point(108, 115);
      this.deliveryDate.Name = "deliveryDate";
      this.deliveryDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
      this.deliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.deliveryDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.deliveryDate.Size = new System.Drawing.Size(217, 20);
      this.deliveryDate.TabIndex = 2;
      // 
      // deliveryBindingSource
      // 
      this.deliveryBindingSource.DataSource = typeof(Impressio.Models.Delivery);
      // 
      // addressLookUp
      // 
      this.addressLookUp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.deliveryBindingSource, "FkDeliveryAddress", true));
      this.addressLookUp.Location = new System.Drawing.Point(108, 79);
      this.addressLookUp.Name = "addressLookUp";
      this.addressLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.addressLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Identity", "Identity", 61, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Table", "Table", 36, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FkAddressCompany", "Fk Address Company", 111, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Street", "Strasse", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StreetNumber", "Strassen Nr.", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("City", "Stadt", 29, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ZipCode", "Plz", 52, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Addition", "Zusatz", 49, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullAddress", "Full Address", 68, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
      this.addressLookUp.Properties.DataSource = this.addressBindingSource;
      this.addressLookUp.Properties.DisplayMember = "FullAddress";
      this.addressLookUp.Properties.NullText = "";
      this.addressLookUp.Properties.PopupWidth = 400;
      this.addressLookUp.Properties.ValueMember = "Identity";
      this.addressLookUp.Size = new System.Drawing.Size(217, 20);
      this.addressLookUp.TabIndex = 1;
      // 
      // addressBindingSource
      // 
      this.addressBindingSource.DataSource = typeof(Impressio.Models.Address);
      // 
      // clientLookUp
      // 
      this.clientLookUp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.deliveryBindingSource, "FkDeliveryClient", true));
      this.clientLookUp.Location = new System.Drawing.Point(108, 43);
      this.clientLookUp.Name = "clientLookUp";
      this.clientLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.clientLookUp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Identity", "Identity", 61, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Table", "Table", 36, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FkClientCompany", "Fk Client Company", 99, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FkClientGender", "Fk Client Gender", 89, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FirstName", "Vorname", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LastName", "Nachname", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Phone", "Phone", 40, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mobile", "Mobile", 40, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mail", "Mail", 28, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "Remark", 46, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Full Name", 56, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
      this.clientLookUp.Properties.DataSource = this.clientBindingSource;
      this.clientLookUp.Properties.DisplayMember = "FullName";
      this.clientLookUp.Properties.NullText = "";
      this.clientLookUp.Properties.PopupWidth = 400;
      this.clientLookUp.Properties.ValueMember = "Identity";
      this.clientLookUp.Size = new System.Drawing.Size(217, 20);
      this.clientLookUp.TabIndex = 0;
      // 
      // clientBindingSource
      // 
      this.clientBindingSource.DataSource = typeof(Impressio.Models.Client);
      // 
      // gridDeliveryPosition
      // 
      this.gridDeliveryPosition.DataSource = this.deliveryPositionBindingSource;
      this.gridDeliveryPosition.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridDeliveryPosition.Location = new System.Drawing.Point(0, 156);
      this.gridDeliveryPosition.MainView = this.viewDeliveryPosition;
      this.gridDeliveryPosition.Name = "gridDeliveryPosition";
      this.gridDeliveryPosition.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.positionComboEdit});
      this.gridDeliveryPosition.Size = new System.Drawing.Size(790, 191);
      this.gridDeliveryPosition.TabIndex = 1;
      this.gridDeliveryPosition.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDeliveryPosition});
      // 
      // deliveryPositionBindingSource
      // 
      this.deliveryPositionBindingSource.DataSource = typeof(Impressio.Models.DeliveryPosition);
      // 
      // viewDeliveryPosition
      // 
      this.viewDeliveryPosition.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
      this.viewDeliveryPosition.Appearance.EvenRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.viewDeliveryPosition.Appearance.EvenRow.Options.UseBackColor = true;
      this.viewDeliveryPosition.ColumnPanelRowHeight = 25;
      this.viewDeliveryPosition.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colTable,
            this.colFkDeliveryPositionDelivery,
            this.colPosition,
            this.colQuantity});
      this.viewDeliveryPosition.GridControl = this.gridDeliveryPosition;
      this.viewDeliveryPosition.IndicatorWidth = 50;
      this.viewDeliveryPosition.Name = "viewDeliveryPosition";
      this.viewDeliveryPosition.OptionsDetail.EnableMasterViewMode = false;
      this.viewDeliveryPosition.OptionsView.EnableAppearanceEvenRow = true;
      this.viewDeliveryPosition.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.viewDeliveryPosition.OptionsView.ShowGroupPanel = false;
      this.viewDeliveryPosition.OptionsView.ShowIndicator = false;
      this.viewDeliveryPosition.RowHeight = 25;
      this.viewDeliveryPosition.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.ViewDeliveryPositionInitNewRow);
      // 
      // colIdentity
      // 
      this.colIdentity.FieldName = "Identity";
      this.colIdentity.Name = "colIdentity";
      this.colIdentity.OptionsColumn.AllowEdit = false;
      this.colIdentity.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colTable
      // 
      this.colTable.FieldName = "Table";
      this.colTable.Name = "colTable";
      this.colTable.OptionsColumn.AllowEdit = false;
      this.colTable.OptionsColumn.ReadOnly = true;
      this.colTable.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colFkDeliveryPositionDelivery
      // 
      this.colFkDeliveryPositionDelivery.FieldName = "FkDeliveryPositionDelivery";
      this.colFkDeliveryPositionDelivery.Name = "colFkDeliveryPositionDelivery";
      this.colFkDeliveryPositionDelivery.OptionsColumn.AllowEdit = false;
      this.colFkDeliveryPositionDelivery.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colPosition
      // 
      this.colPosition.Caption = "Position";
      this.colPosition.ColumnEdit = this.positionComboEdit;
      this.colPosition.FieldName = "Position";
      this.colPosition.Name = "colPosition";
      this.colPosition.Visible = true;
      this.colPosition.VisibleIndex = 0;
      // 
      // positionComboEdit
      // 
      this.positionComboEdit.AutoHeight = false;
      this.positionComboEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.positionComboEdit.DropDownRows = 4;
      this.positionComboEdit.Name = "positionComboEdit";
      // 
      // colQuantity
      // 
      this.colQuantity.Caption = "Menge";
      this.colQuantity.DisplayFormat.FormatString = "N00";
      this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colQuantity.FieldName = "Quantity";
      this.colQuantity.Name = "colQuantity";
      this.colQuantity.Visible = true;
      this.colQuantity.VisibleIndex = 1;
      // 
      // DeliveryControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridDeliveryPosition);
      this.Controls.Add(this.groupControl1);
      this.Name = "DeliveryControl";
      this.Size = new System.Drawing.Size(790, 347);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
      this.groupControl1.ResumeLayout(false);
      this.groupControl1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.deliveryDate.Properties.VistaTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.deliveryDate.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressLookUp.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.clientLookUp.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridDeliveryPosition)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.deliveryPositionBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewDeliveryPosition)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.positionComboEdit)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit deliveryDate;
        private DevExpress.XtraEditors.LookUpEdit addressLookUp;
        private DevExpress.XtraEditors.LookUpEdit clientLookUp;
        private DevExpress.XtraGrid.GridControl gridDeliveryPosition;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDeliveryPosition;
        private System.Windows.Forms.BindingSource deliveryPositionBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
        private DevExpress.XtraGrid.Columns.GridColumn colTable;
        private DevExpress.XtraGrid.Columns.GridColumn colFkDeliveryPositionDelivery;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox positionComboEdit;
        private System.Windows.Forms.BindingSource deliveryBindingSource;

    }
}
