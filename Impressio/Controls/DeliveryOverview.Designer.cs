using Impressio.Models;

namespace Impressio.Controls
{
  partial class DeliveryOverview
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
      this.gridDelivery = new DevExpress.XtraGrid.GridControl();
      this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.viewDelivery = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTable = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFkDeliveryCompany = new DevExpress.XtraGrid.Columns.GridColumn();
      this.companySearchLookUp = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
      this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTable1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAddition = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFkDeliveryOrder = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFkDeliveryAddress = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFkDeliveryClient = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDeliveryDate = new DevExpress.XtraGrid.Columns.GridColumn();
      this.deliveryDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridDelivery)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewDelivery)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.companySearchLookUp)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.deliveryDateEdit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.deliveryDateEdit.VistaTimeProperties)).BeginInit();
      this.SuspendLayout();
      // 
      // gridDelivery
      // 
      this.gridDelivery.DataSource = this.deliveryBindingSource;
      this.gridDelivery.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridDelivery.Font = new System.Drawing.Font("Frutiger LT Std 45 Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gridDelivery.Location = new System.Drawing.Point(0, 0);
      this.gridDelivery.MainView = this.viewDelivery;
      this.gridDelivery.Name = "gridDelivery";
      this.gridDelivery.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.deliveryDateEdit,
            this.companySearchLookUp});
      this.gridDelivery.Size = new System.Drawing.Size(739, 346);
      this.gridDelivery.TabIndex = 0;
      this.gridDelivery.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDelivery});
      // 
      // deliveryBindingSource
      // 
      this.deliveryBindingSource.DataSource = typeof(Models.Delivery);
      // 
      // viewDelivery
      // 
      this.viewDelivery.ColumnPanelRowHeight = 30;
      this.viewDelivery.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colTable,
            this.colFkDeliveryCompany,
            this.colFkDeliveryOrder,
            this.colFkDeliveryAddress,
            this.colFkDeliveryClient,
            this.colDeliveryDate});
      this.viewDelivery.GridControl = this.gridDelivery;
      this.viewDelivery.IndicatorWidth = 50;
      this.viewDelivery.Name = "viewDelivery";
      this.viewDelivery.OptionsDetail.EnableMasterViewMode = false;
      this.viewDelivery.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.viewDelivery.OptionsView.ShowGroupPanel = false;
      this.viewDelivery.RowHeight = 30;
      this.viewDelivery.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.ViewDeliveryInitNewRow);
      this.viewDelivery.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.ViewDeliveryInvalidRowException);
      this.viewDelivery.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.ViewDeliveryValidateRow);
      this.viewDelivery.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.ViewDeliveryRowUpdated);
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
      // colFkDeliveryCompany
      // 
      this.colFkDeliveryCompany.Caption = "Firma";
      this.colFkDeliveryCompany.ColumnEdit = this.companySearchLookUp;
      this.colFkDeliveryCompany.FieldName = "FkDeliveryCompany";
      this.colFkDeliveryCompany.Name = "colFkDeliveryCompany";
      this.colFkDeliveryCompany.Visible = true;
      this.colFkDeliveryCompany.VisibleIndex = 0;
      // 
      // companySearchLookUp
      // 
      this.companySearchLookUp.AutoHeight = false;
      this.companySearchLookUp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.companySearchLookUp.DataSource = this.companyBindingSource;
      this.companySearchLookUp.DisplayMember = "CompanyName";
      this.companySearchLookUp.Name = "companySearchLookUp";
      this.companySearchLookUp.NullText = "";
      this.companySearchLookUp.ValueMember = "Identity";
      this.companySearchLookUp.View = this.repositoryItemSearchLookUpEdit1View;
      // 
      // companyBindingSource
      // 
      this.companyBindingSource.DataSource = typeof(Models.Company);
      // 
      // repositoryItemSearchLookUpEdit1View
      // 
      this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity1,
            this.colTable1,
            this.colCompanyName,
            this.colAddition,
            this.colRemark});
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
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
      // colTable1
      // 
      this.colTable1.FieldName = "Table";
      this.colTable1.Name = "colTable1";
      this.colTable1.OptionsColumn.AllowEdit = false;
      this.colTable1.OptionsColumn.ReadOnly = true;
      this.colTable1.OptionsColumn.ShowInCustomizationForm = false;
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
      this.colAddition.Visible = true;
      this.colAddition.VisibleIndex = 1;
      // 
      // colRemark
      // 
      this.colRemark.Caption = "Bemerkung";
      this.colRemark.FieldName = "Remark";
      this.colRemark.Name = "colRemark";
      this.colRemark.Visible = true;
      this.colRemark.VisibleIndex = 2;
      // 
      // colFkDeliveryOrder
      // 
      this.colFkDeliveryOrder.FieldName = "FkDeliveryOrder";
      this.colFkDeliveryOrder.Name = "colFkDeliveryOrder";
      this.colFkDeliveryOrder.OptionsColumn.AllowEdit = false;
      this.colFkDeliveryOrder.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colFkDeliveryAddress
      // 
      this.colFkDeliveryAddress.FieldName = "FkDeliveryAddress";
      this.colFkDeliveryAddress.Name = "colFkDeliveryAddress";
      this.colFkDeliveryAddress.OptionsColumn.AllowEdit = false;
      this.colFkDeliveryAddress.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colFkDeliveryClient
      // 
      this.colFkDeliveryClient.FieldName = "FkDeliveryClient";
      this.colFkDeliveryClient.Name = "colFkDeliveryClient";
      this.colFkDeliveryClient.OptionsColumn.AllowEdit = false;
      this.colFkDeliveryClient.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colDeliveryDate
      // 
      this.colDeliveryDate.Caption = "Lieferdatum";
      this.colDeliveryDate.ColumnEdit = this.deliveryDateEdit;
      this.colDeliveryDate.DisplayFormat.FormatString = "d";
      this.colDeliveryDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.colDeliveryDate.FieldName = "DeliveryDate";
      this.colDeliveryDate.Name = "colDeliveryDate";
      this.colDeliveryDate.Visible = true;
      this.colDeliveryDate.VisibleIndex = 1;
      // 
      // deliveryDateEdit
      // 
      this.deliveryDateEdit.AutoHeight = false;
      this.deliveryDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.deliveryDateEdit.Name = "deliveryDateEdit";
      this.deliveryDateEdit.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      // 
      // DeliveryOverview
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridDelivery);
      this.Name = "DeliveryOverview";
      this.Size = new System.Drawing.Size(739, 346);
      this.Load += new System.EventHandler(this.DeliveryOverviewControlLoad);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridDelivery)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewDelivery)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.companySearchLookUp)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.deliveryDateEdit.VistaTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.deliveryDateEdit)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridDelivery;
    private System.Windows.Forms.BindingSource deliveryBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
    private DevExpress.XtraGrid.Columns.GridColumn colTable;
    private DevExpress.XtraGrid.Columns.GridColumn colFkDeliveryCompany;
    private DevExpress.XtraGrid.Columns.GridColumn colFkDeliveryOrder;
    private DevExpress.XtraGrid.Columns.GridColumn colFkDeliveryAddress;
    private DevExpress.XtraGrid.Columns.GridColumn colFkDeliveryClient;
    private DevExpress.XtraGrid.Columns.GridColumn colDeliveryDate;
    private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit deliveryDateEdit;
    private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit companySearchLookUp;
    private System.Windows.Forms.BindingSource companyBindingSource;
    private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
    public DevExpress.XtraGrid.Views.Grid.GridView viewDelivery;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentity1;
    private DevExpress.XtraGrid.Columns.GridColumn colTable1;
    private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
    private DevExpress.XtraGrid.Columns.GridColumn colAddition;
    private DevExpress.XtraGrid.Columns.GridColumn colRemark;
  }
}
