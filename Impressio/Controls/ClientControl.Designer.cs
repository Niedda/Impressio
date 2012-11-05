using Impressio.Models;

namespace Impressio.Controls
{
    partial class ClientControl
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
      this.gridClients = new DevExpress.XtraGrid.GridControl();
      this.clientsBindingSource = new System.Windows.Forms.BindingSource();
      this.viewClients = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
      this.genderLookUp = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.genderBindingSource = new System.Windows.Forms.BindingSource();
      this.colFkClientCompany = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridClients)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewClients)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.genderLookUp)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // gridClients
      // 
      this.gridClients.DataSource = this.clientsBindingSource;
      this.gridClients.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridClients.Location = new System.Drawing.Point(0, 0);
      this.gridClients.MainView = this.viewClients;
      this.gridClients.Name = "gridClients";
      this.gridClients.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.genderLookUp});
      this.gridClients.Size = new System.Drawing.Size(914, 306);
      this.gridClients.TabIndex = 0;
      this.gridClients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewClients});
      // 
      // viewClients
      // 
      this.viewClients.ColumnPanelRowHeight = 30;
      this.viewClients.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colFirstName,
            this.colLastName,
            this.colPhone,
            this.colMobile,
            this.colMail,
            this.colRemark,
            this.colGender,
            this.colFkClientCompany});
      this.viewClients.GridControl = this.gridClients;
      this.viewClients.IndicatorWidth = 50;
      this.viewClients.Name = "viewClients";
      this.viewClients.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
      this.viewClients.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
      this.viewClients.OptionsFind.AlwaysVisible = true;
      this.viewClients.OptionsFind.ShowCloseButton = false;
      this.viewClients.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.viewClients.OptionsView.ShowDetailButtons = false;
      this.viewClients.OptionsView.ShowGroupPanel = false;
      this.viewClients.RowHeight = 30;
      this.viewClients.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.ViewClientsInitNewRow);
      this.viewClients.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.ViewClientsInvalidRowException);
      this.viewClients.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.ViewClientsValidateRow);
      this.viewClients.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.ViewClientsRowUpdated);
      // 
      // colIdentity
      // 
      this.colIdentity.FieldName = "Identity";
      this.colIdentity.Name = "colIdentity";
      this.colIdentity.OptionsColumn.AllowEdit = false;
      this.colIdentity.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colFirstName
      // 
      this.colFirstName.Caption = "Vorname";
      this.colFirstName.FieldName = "FirstName";
      this.colFirstName.Name = "colFirstName";
      this.colFirstName.Visible = true;
      this.colFirstName.VisibleIndex = 1;
      // 
      // colLastName
      // 
      this.colLastName.Caption = "Nachname";
      this.colLastName.FieldName = "LastName";
      this.colLastName.Name = "colLastName";
      this.colLastName.Visible = true;
      this.colLastName.VisibleIndex = 2;
      // 
      // colPhone
      // 
      this.colPhone.Caption = "Telefon";
      this.colPhone.FieldName = "Phone";
      this.colPhone.Name = "colPhone";
      this.colPhone.Visible = true;
      this.colPhone.VisibleIndex = 3;
      // 
      // colMobile
      // 
      this.colMobile.Caption = "Mobile";
      this.colMobile.FieldName = "Mobile";
      this.colMobile.Name = "colMobile";
      this.colMobile.Visible = true;
      this.colMobile.VisibleIndex = 4;
      // 
      // colMail
      // 
      this.colMail.Caption = "E-Mail";
      this.colMail.FieldName = "Mail";
      this.colMail.Name = "colMail";
      this.colMail.Visible = true;
      this.colMail.VisibleIndex = 5;
      // 
      // colRemark
      // 
      this.colRemark.Caption = "Bemerkung";
      this.colRemark.FieldName = "Remark";
      this.colRemark.Name = "colRemark";
      this.colRemark.Visible = true;
      this.colRemark.VisibleIndex = 6;
      // 
      // colGender
      // 
      this.colGender.Caption = "Anrede";
      this.colGender.ColumnEdit = this.genderLookUp;
      this.colGender.FieldName = "FkClientGender";
      this.colGender.Name = "colGender";
      this.colGender.Visible = true;
      this.colGender.VisibleIndex = 0;
      // 
      // genderLookUp
      // 
      this.genderLookUp.AutoHeight = false;
      this.genderLookUp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.genderLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Identity", "Identity", 61, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Table", "Table", 36, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
      this.genderLookUp.DataSource = this.genderBindingSource;
      this.genderLookUp.DisplayMember = "Name";
      this.genderLookUp.DropDownRows = 4;
      this.genderLookUp.Name = "genderLookUp";
      this.genderLookUp.NullText = "";
      this.genderLookUp.ValueMember = "Identity";
      // 
      // genderBindingSource
      // 
      this.genderBindingSource.DataSource = typeof(Impressio.Models.Gender);
      // 
      // colFkClientCompany
      // 
      this.colFkClientCompany.FieldName = "FkClientCompany";
      this.colFkClientCompany.Name = "colFkClientCompany";
      this.colFkClientCompany.OptionsColumn.AllowEdit = false;
      this.colFkClientCompany.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // ClientControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridClients);
      this.Name = "ClientControl";
      this.Size = new System.Drawing.Size(914, 306);
      this.Load += new System.EventHandler(this.ClientControlLoad);
      this.Validating += new System.ComponentModel.CancelEventHandler(this.ClientControlValidating);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridClients)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewClients)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.genderLookUp)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridClients;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colFkClientCompany;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit genderLookUp;
        private System.Windows.Forms.BindingSource genderBindingSource;
        public DevExpress.XtraGrid.Views.Grid.GridView viewClients;
    }
}
