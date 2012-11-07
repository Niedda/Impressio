namespace Impressio.Controls
{
  partial class PredefinedPositionControl
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
      this.colTable = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFkOrder = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPriceTotal = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colIsPredefined = new DevExpress.XtraGrid.Columns.GridColumn();
      this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.typeCombo = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridPosition)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewPosition)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.typeCombo)).BeginInit();
      this.SuspendLayout();
      // 
      // gridPosition
      // 
      this.gridPosition.DataSource = this.positionBindingSource;
      this.gridPosition.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridPosition.Location = new System.Drawing.Point(0, 0);
      this.gridPosition.MainView = this.viewPosition;
      this.gridPosition.Name = "gridPosition";
      this.gridPosition.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.typeCombo});
      this.gridPosition.Size = new System.Drawing.Size(898, 373);
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
      this.viewPosition.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colTable,
            this.colName,
            this.colFkOrder,
            this.colPriceTotal,
            this.colType,
            this.colIsPredefined});
      this.viewPosition.GridControl = this.gridPosition;
      this.viewPosition.GroupRowHeight = 30;
      this.viewPosition.IndicatorWidth = 30;
      this.viewPosition.Name = "viewPosition";
      this.viewPosition.OptionsDetail.AllowZoomDetail = false;
      this.viewPosition.OptionsDetail.EnableMasterViewMode = false;
      this.viewPosition.OptionsDetail.ShowDetailTabs = false;
      this.viewPosition.OptionsDetail.SmartDetailExpand = false;
      this.viewPosition.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.viewPosition.OptionsView.ShowGroupPanel = false;
      this.viewPosition.RowHeight = 30;
      this.viewPosition.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.ViewPositionRowClick);
      this.viewPosition.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.ViewPositionInitNewRow);
      this.viewPosition.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.ViewPositionInvalidRowException);
      this.viewPosition.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.ViewPositionValidateRow);
      this.viewPosition.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.ViewPositionRowUpdated);
      // 
      // colIdentity
      // 
      this.colIdentity.FieldName = "Identity";
      this.colIdentity.Name = "colIdentity";
      this.colIdentity.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colTable
      // 
      this.colTable.FieldName = "Table";
      this.colTable.Name = "colTable";
      this.colTable.OptionsColumn.ReadOnly = true;
      this.colTable.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colName
      // 
      this.colName.Caption = "Name";
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // colFkOrder
      // 
      this.colFkOrder.FieldName = "FkOrder";
      this.colFkOrder.Name = "colFkOrder";
      this.colFkOrder.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colPriceTotal
      // 
      this.colPriceTotal.FieldName = "PositionTotal";
      this.colPriceTotal.Name = "colPriceTotal";
      this.colPriceTotal.OptionsColumn.ShowInCustomizationForm = false;
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
      // colIsPredefined
      // 
      this.colIsPredefined.FieldName = "IsPredefined";
      this.colIsPredefined.Name = "colIsPredefined";
      this.colIsPredefined.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // typeBindingSource
      // 
      this.typeBindingSource.DataSource = typeof(Impressio.Models.Type);
      // 
      // typeCombo
      // 
      this.typeCombo.AutoHeight = false;
      this.typeCombo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.typeCombo.DropDownRows = 4;
      this.typeCombo.Name = "typeCombo";
      // 
      // PredefinedPositionControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridPosition);
      this.Name = "PredefinedPositionControl";
      this.Size = new System.Drawing.Size(898, 373);
      this.Load += new System.EventHandler(this.PredefinedPositionControlLoad);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridPosition)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewPosition)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.typeCombo)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridPosition;
    private DevExpress.XtraGrid.Views.Grid.GridView viewPosition;
    private System.Windows.Forms.BindingSource positionBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
    private DevExpress.XtraGrid.Columns.GridColumn colTable;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colFkOrder;
    private DevExpress.XtraGrid.Columns.GridColumn colPriceTotal;
    private DevExpress.XtraGrid.Columns.GridColumn colType;
    private System.Windows.Forms.BindingSource typeBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colIsPredefined;
    private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox typeCombo;
  }
}
