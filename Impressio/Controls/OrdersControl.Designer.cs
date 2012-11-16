using Impressio.Models;

namespace Impressio.Controls
{
    partial class OrdersControl
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
      this.gridOrder = new DevExpress.XtraGrid.GridControl();
      this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.viewOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFkOrderCompany = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colOrderName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
      this.stateLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDateModified = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colUserModified = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colIsPredefined = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFkOrderClient = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFkOrderAddress = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
      this.companySearchLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
      this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAddition = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
      this.avaibleClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.avaibleAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewOrder)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateLookUpEdit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.companySearchLookUpEdit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.avaibleClientsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.avaibleAddressBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // gridOrder
      // 
      this.gridOrder.DataSource = this.orderBindingSource;
      this.gridOrder.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridOrder.Location = new System.Drawing.Point(0, 0);
      this.gridOrder.MainView = this.viewOrder;
      this.gridOrder.Name = "gridOrder";
      this.gridOrder.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.companySearchLookUpEdit,
            this.stateLookUpEdit});
      this.gridOrder.Size = new System.Drawing.Size(790, 347);
      this.gridOrder.TabIndex = 0;
      this.gridOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewOrder});
      // 
      // orderBindingSource
      // 
      this.orderBindingSource.DataSource = typeof(Impressio.Models.Order);
      // 
      // viewOrder
      // 
      this.viewOrder.ColumnPanelRowHeight = 30;
      this.viewOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colFkOrderCompany,
            this.colOrderName,
            this.colState,
            this.colDateCreated,
            this.colUserCreated,
            this.colDateModified,
            this.colUserModified,
            this.colIsPredefined,
            this.colFkOrderClient,
            this.colFkOrderAddress,
            this.colCompany});
      this.viewOrder.GridControl = this.gridOrder;
      this.viewOrder.IndicatorWidth = 50;
      this.viewOrder.Name = "viewOrder";
      this.viewOrder.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
      this.viewOrder.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
      this.viewOrder.OptionsDetail.AllowZoomDetail = false;
      this.viewOrder.OptionsDetail.EnableMasterViewMode = false;
      this.viewOrder.OptionsDetail.ShowDetailTabs = false;
      this.viewOrder.OptionsDetail.SmartDetailExpand = false;
      this.viewOrder.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
      this.viewOrder.OptionsFind.AlwaysVisible = true;
      this.viewOrder.OptionsFind.ShowCloseButton = false;
      this.viewOrder.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.viewOrder.OptionsView.ShowAutoFilterRow = true;
      this.viewOrder.OptionsView.ShowDetailButtons = false;
      this.viewOrder.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
      this.viewOrder.OptionsView.ShowGroupPanel = false;
      this.viewOrder.RowHeight = 30;
      // 
      // colIdentity
      // 
      this.colIdentity.Caption = "Auftragsnummer";
      this.colIdentity.FieldName = "Identity";
      this.colIdentity.Name = "colIdentity";
      this.colIdentity.OptionsColumn.AllowEdit = false;
      this.colIdentity.OptionsColumn.ShowInCustomizationForm = false;
      this.colIdentity.Visible = true;
      this.colIdentity.VisibleIndex = 3;
      // 
      // colFkOrderCompany
      // 
      this.colFkOrderCompany.FieldName = "FkOrderCompany";
      this.colFkOrderCompany.Name = "colFkOrderCompany";
      this.colFkOrderCompany.OptionsColumn.AllowEdit = false;
      this.colFkOrderCompany.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colOrderName
      // 
      this.colOrderName.Caption = "Auftrag";
      this.colOrderName.FieldName = "OrderName";
      this.colOrderName.Name = "colOrderName";
      this.colOrderName.Visible = true;
      this.colOrderName.VisibleIndex = 0;
      // 
      // colState
      // 
      this.colState.Caption = "Status";
      this.colState.ColumnEdit = this.stateLookUpEdit;
      this.colState.FieldName = "FkOrderState";
      this.colState.Name = "colState";
      this.colState.Visible = true;
      this.colState.VisibleIndex = 2;
      // 
      // stateLookUpEdit
      // 
      this.stateLookUpEdit.AutoHeight = false;
      this.stateLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.stateLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Identity", "Identity", 61, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StateName", "State Name", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
      this.stateLookUpEdit.DataSource = this.stateBindingSource;
      this.stateLookUpEdit.DisplayMember = "StateName";
      this.stateLookUpEdit.DropDownRows = 8;
      this.stateLookUpEdit.Name = "stateLookUpEdit";
      this.stateLookUpEdit.NullText = "";
      this.stateLookUpEdit.ShowHeader = false;
      this.stateLookUpEdit.ValueMember = "Identity";
      // 
      // stateBindingSource
      // 
      this.stateBindingSource.DataSource = typeof(Impressio.Models.State);
      // 
      // colDateCreated
      // 
      this.colDateCreated.FieldName = "DateCreated";
      this.colDateCreated.Name = "colDateCreated";
      this.colDateCreated.OptionsColumn.AllowEdit = false;
      // 
      // colUserCreated
      // 
      this.colUserCreated.FieldName = "UserCreated";
      this.colUserCreated.Name = "colUserCreated";
      this.colUserCreated.OptionsColumn.AllowEdit = false;
      // 
      // colDateModified
      // 
      this.colDateModified.FieldName = "DateModified";
      this.colDateModified.Name = "colDateModified";
      this.colDateModified.OptionsColumn.AllowEdit = false;
      // 
      // colUserModified
      // 
      this.colUserModified.FieldName = "UserModified";
      this.colUserModified.Name = "colUserModified";
      this.colUserModified.OptionsColumn.AllowEdit = false;
      // 
      // colIsPredefined
      // 
      this.colIsPredefined.FieldName = "IsPredefined";
      this.colIsPredefined.Name = "colIsPredefined";
      this.colIsPredefined.OptionsColumn.AllowEdit = false;
      this.colIsPredefined.OptionsColumn.AllowShowHide = false;
      this.colIsPredefined.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colFkOrderClient
      // 
      this.colFkOrderClient.FieldName = "FkOrderClient";
      this.colFkOrderClient.Name = "colFkOrderClient";
      this.colFkOrderClient.OptionsColumn.AllowEdit = false;
      this.colFkOrderClient.OptionsColumn.AllowShowHide = false;
      this.colFkOrderClient.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colFkOrderAddress
      // 
      this.colFkOrderAddress.FieldName = "FkOrderAddress";
      this.colFkOrderAddress.Name = "colFkOrderAddress";
      this.colFkOrderAddress.OptionsColumn.AllowEdit = false;
      this.colFkOrderAddress.OptionsColumn.AllowShowHide = false;
      this.colFkOrderAddress.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colCompany
      // 
      this.colCompany.Caption = "Firma";
      this.colCompany.ColumnEdit = this.companySearchLookUpEdit;
      this.colCompany.FieldName = "FkOrderCompany";
      this.colCompany.Name = "colCompany";
      this.colCompany.Visible = true;
      this.colCompany.VisibleIndex = 1;
      // 
      // companySearchLookUpEdit
      // 
      this.companySearchLookUpEdit.AutoHeight = false;
      this.companySearchLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.companySearchLookUpEdit.DataSource = this.companiesBindingSource;
      this.companySearchLookUpEdit.DisplayMember = "CompanyName";
      this.companySearchLookUpEdit.Name = "companySearchLookUpEdit";
      this.companySearchLookUpEdit.NullText = "";
      this.companySearchLookUpEdit.ValueMember = "Identity";
      this.companySearchLookUpEdit.View = this.repositoryItemSearchLookUpEdit1View;
      this.companySearchLookUpEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.CompanySearchLookUpEditEditValueChanging);
      // 
      // companiesBindingSource
      // 
      this.companiesBindingSource.DataSource = typeof(Impressio.Models.Company);
      // 
      // repositoryItemSearchLookUpEdit1View
      // 
      this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity1,
            this.colCompanyName,
            this.colAddition,
            this.colRemark});
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsBehavior.Editable = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      // 
      // colIdentity1
      // 
      this.colIdentity1.FieldName = "Identity";
      this.colIdentity1.Name = "colIdentity1";
      this.colIdentity1.OptionsColumn.AllowEdit = false;
      this.colIdentity1.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colCompanyName
      // 
      this.colCompanyName.Caption = "Firma";
      this.colCompanyName.FieldName = "CompanyName";
      this.colCompanyName.Name = "colCompanyName";
      this.colCompanyName.Visible = true;
      this.colCompanyName.VisibleIndex = 0;
      // 
      // colAddition
      // 
      this.colAddition.Caption = "Zusatz";
      this.colAddition.FieldName = "Addition";
      this.colAddition.Name = "colAddition";
      this.colAddition.OptionsColumn.AllowEdit = false;
      this.colAddition.OptionsColumn.ShowInCustomizationForm = false;
      this.colAddition.Visible = true;
      this.colAddition.VisibleIndex = 1;
      // 
      // colRemark
      // 
      this.colRemark.Caption = "Beschreibung";
      this.colRemark.FieldName = "Remark";
      this.colRemark.Name = "colRemark";
      this.colRemark.OptionsColumn.AllowEdit = false;
      this.colRemark.OptionsColumn.ShowInCustomizationForm = false;
      this.colRemark.Visible = true;
      this.colRemark.VisibleIndex = 2;
      // 
      // avaibleClientsBindingSource
      // 
      this.avaibleClientsBindingSource.DataMember = "AvaibleClients";
      this.avaibleClientsBindingSource.DataSource = this.orderBindingSource;
      // 
      // avaibleAddressBindingSource
      // 
      this.avaibleAddressBindingSource.DataMember = "AvaibleAddress";
      this.avaibleAddressBindingSource.DataSource = this.orderBindingSource;
      // 
      // OrdersControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridOrder);
      this.Name = "OrdersControl";
      this.Size = new System.Drawing.Size(790, 347);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewOrder)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateLookUpEdit)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.companySearchLookUpEdit)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.avaibleClientsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.avaibleAddressBindingSource)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridOrder;
        private System.Windows.Forms.BindingSource orderBindingSource;
        public DevExpress.XtraGrid.Views.Grid.GridView viewOrder;
        private System.Windows.Forms.BindingSource avaibleClientsBindingSource;
        private System.Windows.Forms.BindingSource avaibleAddressBindingSource;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
        private DevExpress.XtraGrid.Columns.GridColumn colFkOrderCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderName;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateModified;
        private DevExpress.XtraGrid.Columns.GridColumn colUserModified;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPredefined;
        private DevExpress.XtraGrid.Columns.GridColumn colFkOrderClient;
        private DevExpress.XtraGrid.Columns.GridColumn colFkOrderAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit companySearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit stateLookUpEdit;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentity1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddition;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
    }
}
