namespace Impressio.Controls
{
  partial class PredefinedOrderControl
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
      this.gridPredefindedOrder = new DevExpress.XtraGrid.GridControl();
      this.predefinedOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.viewPredefinedOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colIdentityColumn = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTable = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFkOrderId = new DevExpress.XtraGrid.Columns.GridColumn();
      this.orderSearchLookUp = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
      this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colIdentityColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTable1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFkOrderCompany = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colOrderName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFkOrderState = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDateModified = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colUserModified = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colIsPredefined = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFkOrderClient = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFkOrderAddress = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFolderPath = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colClient = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDatabase1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPages = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colColorFront = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colColorBack = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colKind = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDatabase = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridPredefindedOrder)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.predefinedOrderBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewPredefinedOrder)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderSearchLookUp)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
      this.SuspendLayout();
      // 
      // gridPredefindedOrder
      // 
      this.gridPredefindedOrder.DataSource = this.predefinedOrderBindingSource;
      this.gridPredefindedOrder.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridPredefindedOrder.Location = new System.Drawing.Point(0, 0);
      this.gridPredefindedOrder.MainView = this.viewPredefinedOrder;
      this.gridPredefindedOrder.Name = "gridPredefindedOrder";
      this.gridPredefindedOrder.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.orderSearchLookUp});
      this.gridPredefindedOrder.Size = new System.Drawing.Size(677, 397);
      this.gridPredefindedOrder.TabIndex = 0;
      this.gridPredefindedOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewPredefinedOrder});
      // 
      // predefinedOrderBindingSource
      // 
      this.predefinedOrderBindingSource.DataSource = typeof(Impressio.Models.PredefinedOrder);
      // 
      // viewPredefinedOrder
      // 
      this.viewPredefinedOrder.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
      this.viewPredefinedOrder.Appearance.EvenRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.viewPredefinedOrder.Appearance.EvenRow.Options.UseBackColor = true;
      this.viewPredefinedOrder.ColumnPanelRowHeight = 25;
      this.viewPredefinedOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colIdentityColumn,
            this.colTable,
            this.colFkOrderId,
            this.colPages,
            this.colColorFront,
            this.colColorBack,
            this.colKind,
            this.colName,
            this.colDatabase,
            this.colQuantity});
      this.viewPredefinedOrder.GridControl = this.gridPredefindedOrder;
      this.viewPredefinedOrder.GroupRowHeight = 25;
      this.viewPredefinedOrder.IndicatorWidth = 30;
      this.viewPredefinedOrder.Name = "viewPredefinedOrder";
      this.viewPredefinedOrder.OptionsDetail.AllowZoomDetail = false;
      this.viewPredefinedOrder.OptionsDetail.EnableMasterViewMode = false;
      this.viewPredefinedOrder.OptionsDetail.ShowDetailTabs = false;
      this.viewPredefinedOrder.OptionsDetail.SmartDetailExpand = false;
      this.viewPredefinedOrder.OptionsFind.AlwaysVisible = true;
      this.viewPredefinedOrder.OptionsView.EnableAppearanceEvenRow = true;
      this.viewPredefinedOrder.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.viewPredefinedOrder.OptionsView.ShowIndicator = false;
      this.viewPredefinedOrder.RowHeight = 25;
      // 
      // colIdentity
      // 
      this.colIdentity.FieldName = "Identity";
      this.colIdentity.Name = "colIdentity";
      this.colIdentity.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colIdentityColumn
      // 
      this.colIdentityColumn.FieldName = "IdentityColumn";
      this.colIdentityColumn.Name = "colIdentityColumn";
      this.colIdentityColumn.OptionsColumn.ReadOnly = true;
      this.colIdentityColumn.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colTable
      // 
      this.colTable.FieldName = "Table";
      this.colTable.Name = "colTable";
      this.colTable.OptionsColumn.ReadOnly = true;
      this.colTable.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colFkOrderId
      // 
      this.colFkOrderId.Caption = "Auftrag";
      this.colFkOrderId.ColumnEdit = this.orderSearchLookUp;
      this.colFkOrderId.FieldName = "FkOrderId";
      this.colFkOrderId.Name = "colFkOrderId";
      this.colFkOrderId.OptionsColumn.AllowEdit = false;
      this.colFkOrderId.Visible = true;
      this.colFkOrderId.VisibleIndex = 6;
      // 
      // orderSearchLookUp
      // 
      this.orderSearchLookUp.AutoHeight = false;
      this.orderSearchLookUp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.orderSearchLookUp.DataSource = this.orderBindingSource;
      this.orderSearchLookUp.DisplayMember = "OrderName";
      this.orderSearchLookUp.Name = "orderSearchLookUp";
      this.orderSearchLookUp.NullText = "";
      this.orderSearchLookUp.ValueMember = "Identity";
      this.orderSearchLookUp.View = this.repositoryItemSearchLookUpEdit1View;
      this.orderSearchLookUp.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.OrderSearchLookUpEditValueChanging);
      // 
      // orderBindingSource
      // 
      this.orderBindingSource.DataSource = typeof(Impressio.Models.Order);
      // 
      // repositoryItemSearchLookUpEdit1View
      // 
      this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity1,
            this.colIdentityColumn1,
            this.colTable1,
            this.colFkOrderCompany,
            this.colOrderName,
            this.colState,
            this.colFkOrderState,
            this.colDateCreated,
            this.colUserCreated,
            this.colDateModified,
            this.colUserModified,
            this.colIsPredefined,
            this.colFkOrderClient,
            this.colFkOrderAddress,
            this.colFolderPath,
            this.colClient,
            this.colAddress,
            this.colCompany,
            this.colDatabase1});
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      // 
      // colIdentity1
      // 
      this.colIdentity1.FieldName = "Identity";
      this.colIdentity1.Name = "colIdentity1";
      this.colIdentity1.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colIdentityColumn1
      // 
      this.colIdentityColumn1.FieldName = "IdentityColumn";
      this.colIdentityColumn1.Name = "colIdentityColumn1";
      this.colIdentityColumn1.OptionsColumn.ReadOnly = true;
      this.colIdentityColumn1.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colTable1
      // 
      this.colTable1.FieldName = "Table";
      this.colTable1.Name = "colTable1";
      this.colTable1.OptionsColumn.ReadOnly = true;
      this.colTable1.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colFkOrderCompany
      // 
      this.colFkOrderCompany.FieldName = "FkOrderCompany";
      this.colFkOrderCompany.Name = "colFkOrderCompany";
      this.colFkOrderCompany.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colOrderName
      // 
      this.colOrderName.FieldName = "OrderName";
      this.colOrderName.Name = "colOrderName";
      this.colOrderName.Visible = true;
      this.colOrderName.VisibleIndex = 0;
      // 
      // colState
      // 
      this.colState.FieldName = "State";
      this.colState.Name = "colState";
      this.colState.OptionsColumn.ReadOnly = true;
      this.colState.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colFkOrderState
      // 
      this.colFkOrderState.FieldName = "FkOrderState";
      this.colFkOrderState.Name = "colFkOrderState";
      this.colFkOrderState.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colDateCreated
      // 
      this.colDateCreated.FieldName = "DateCreated";
      this.colDateCreated.Name = "colDateCreated";
      this.colDateCreated.OptionsColumn.ReadOnly = true;
      this.colDateCreated.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colUserCreated
      // 
      this.colUserCreated.FieldName = "UserCreated";
      this.colUserCreated.Name = "colUserCreated";
      this.colUserCreated.OptionsColumn.ReadOnly = true;
      this.colUserCreated.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colDateModified
      // 
      this.colDateModified.FieldName = "DateModified";
      this.colDateModified.Name = "colDateModified";
      this.colDateModified.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colUserModified
      // 
      this.colUserModified.FieldName = "UserModified";
      this.colUserModified.Name = "colUserModified";
      this.colUserModified.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colIsPredefined
      // 
      this.colIsPredefined.FieldName = "IsPredefined";
      this.colIsPredefined.Name = "colIsPredefined";
      this.colIsPredefined.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colFkOrderClient
      // 
      this.colFkOrderClient.FieldName = "FkOrderClient";
      this.colFkOrderClient.Name = "colFkOrderClient";
      this.colFkOrderClient.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colFkOrderAddress
      // 
      this.colFkOrderAddress.FieldName = "FkOrderAddress";
      this.colFkOrderAddress.Name = "colFkOrderAddress";
      this.colFkOrderAddress.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colFolderPath
      // 
      this.colFolderPath.FieldName = "FolderPath";
      this.colFolderPath.Name = "colFolderPath";
      this.colFolderPath.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colClient
      // 
      this.colClient.FieldName = "Client";
      this.colClient.Name = "colClient";
      this.colClient.OptionsColumn.ReadOnly = true;
      this.colClient.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colAddress
      // 
      this.colAddress.FieldName = "Address";
      this.colAddress.Name = "colAddress";
      this.colAddress.OptionsColumn.ReadOnly = true;
      this.colAddress.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colCompany
      // 
      this.colCompany.FieldName = "Company";
      this.colCompany.Name = "colCompany";
      this.colCompany.OptionsColumn.ReadOnly = true;
      this.colCompany.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colDatabase1
      // 
      this.colDatabase1.FieldName = "Database";
      this.colDatabase1.Name = "colDatabase1";
      this.colDatabase1.OptionsColumn.ReadOnly = true;
      this.colDatabase1.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colPages
      // 
      this.colPages.Caption = "Anzahl Seiten";
      this.colPages.FieldName = "Pages";
      this.colPages.Name = "colPages";
      this.colPages.Visible = true;
      this.colPages.VisibleIndex = 2;
      // 
      // colColorFront
      // 
      this.colColorFront.Caption = "Farben Vorderseite";
      this.colColorFront.FieldName = "ColorFront";
      this.colColorFront.Name = "colColorFront";
      this.colColorFront.Visible = true;
      this.colColorFront.VisibleIndex = 3;
      // 
      // colColorBack
      // 
      this.colColorBack.Caption = "Farben Rückseite";
      this.colColorBack.FieldName = "ColorBack";
      this.colColorBack.Name = "colColorBack";
      this.colColorBack.Visible = true;
      this.colColorBack.VisibleIndex = 4;
      // 
      // colKind
      // 
      this.colKind.Caption = "Ausführung";
      this.colKind.FieldName = "Kind";
      this.colKind.Name = "colKind";
      this.colKind.Visible = true;
      this.colKind.VisibleIndex = 1;
      // 
      // colName
      // 
      this.colName.Caption = "Name";
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // colDatabase
      // 
      this.colDatabase.FieldName = "Database";
      this.colDatabase.Name = "colDatabase";
      this.colDatabase.OptionsColumn.ReadOnly = true;
      this.colDatabase.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colQuantity
      // 
      this.colQuantity.Caption = "Auflage";
      this.colQuantity.FieldName = "Quantity";
      this.colQuantity.Name = "colQuantity";
      this.colQuantity.Visible = true;
      this.colQuantity.VisibleIndex = 5;
      // 
      // PredefinedOrderControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridPredefindedOrder);
      this.Name = "PredefinedOrderControl";
      this.Size = new System.Drawing.Size(677, 397);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridPredefindedOrder)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.predefinedOrderBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewPredefinedOrder)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderSearchLookUp)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridPredefindedOrder;
    private DevExpress.XtraGrid.Views.Grid.GridView viewPredefinedOrder;
    private System.Windows.Forms.BindingSource predefinedOrderBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentityColumn;
    private DevExpress.XtraGrid.Columns.GridColumn colTable;
    private DevExpress.XtraGrid.Columns.GridColumn colFkOrderId;
    private DevExpress.XtraGrid.Columns.GridColumn colPages;
    private DevExpress.XtraGrid.Columns.GridColumn colColorFront;
    private DevExpress.XtraGrid.Columns.GridColumn colColorBack;
    private DevExpress.XtraGrid.Columns.GridColumn colKind;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colDatabase;
    private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit orderSearchLookUp;
    private System.Windows.Forms.BindingSource orderBindingSource;
    private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentity1;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentityColumn1;
    private DevExpress.XtraGrid.Columns.GridColumn colTable1;
    private DevExpress.XtraGrid.Columns.GridColumn colFkOrderCompany;
    private DevExpress.XtraGrid.Columns.GridColumn colOrderName;
    private DevExpress.XtraGrid.Columns.GridColumn colState;
    private DevExpress.XtraGrid.Columns.GridColumn colFkOrderState;
    private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
    private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
    private DevExpress.XtraGrid.Columns.GridColumn colDateModified;
    private DevExpress.XtraGrid.Columns.GridColumn colUserModified;
    private DevExpress.XtraGrid.Columns.GridColumn colIsPredefined;
    private DevExpress.XtraGrid.Columns.GridColumn colFkOrderClient;
    private DevExpress.XtraGrid.Columns.GridColumn colFkOrderAddress;
    private DevExpress.XtraGrid.Columns.GridColumn colFolderPath;
    private DevExpress.XtraGrid.Columns.GridColumn colClient;
    private DevExpress.XtraGrid.Columns.GridColumn colAddress;
    private DevExpress.XtraGrid.Columns.GridColumn colCompany;
    private DevExpress.XtraGrid.Columns.GridColumn colDatabase1;
    private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
  }
}
