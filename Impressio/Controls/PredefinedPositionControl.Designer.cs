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
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.lookUpTypes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.colFkOrder = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPositionTotal = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colIsPredefined = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAssignedControl = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDatabase = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.gridPosition)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewPosition)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpTypes)).BeginInit();
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
            this.lookUpTypes});
      this.gridPosition.Size = new System.Drawing.Size(824, 309);
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
            this.colDisplayName,
            this.colFkOrder,
            this.colPositionTotal,
            this.colIsPredefined,
            this.colAssignedControl,
            this.colDatabase});
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
      this.viewPosition.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ViewPositionFocusedRowChanged);
      this.viewPosition.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.ViewPositionInvalidRowException);
      this.viewPosition.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.ViewPositionValidateRow);
      // 
      // colIdentity
      // 
      this.colIdentity.FieldName = "Identity";
      this.colIdentity.Name = "colIdentity";
      this.colIdentity.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colName
      // 
      this.colName.Caption = "Name";
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // colDisplayName
      // 
      this.colDisplayName.Caption = "Typ";
      this.colDisplayName.ColumnEdit = this.lookUpTypes;
      this.colDisplayName.FieldName = "DisplayName";
      this.colDisplayName.Name = "colDisplayName";
      this.colDisplayName.Visible = true;
      this.colDisplayName.VisibleIndex = 1;
      // 
      // lookUpTypes
      // 
      this.lookUpTypes.AutoHeight = false;
      this.lookUpTypes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpTypes.Name = "lookUpTypes";
      this.lookUpTypes.NullText = "";
      this.lookUpTypes.ShowFooter = false;
      this.lookUpTypes.ShowHeader = false;
      // 
      // colFkOrder
      // 
      this.colFkOrder.FieldName = "FkOrder";
      this.colFkOrder.Name = "colFkOrder";
      this.colFkOrder.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colPositionTotal
      // 
      this.colPositionTotal.Caption = "Position Total";
      this.colPositionTotal.DisplayFormat.FormatString = "c";
      this.colPositionTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colPositionTotal.FieldName = "PositionTotal";
      this.colPositionTotal.Name = "colPositionTotal";
      this.colPositionTotal.OptionsColumn.AllowEdit = false;
      this.colPositionTotal.Visible = true;
      this.colPositionTotal.VisibleIndex = 2;
      // 
      // colIsPredefined
      // 
      this.colIsPredefined.FieldName = "IsPredefined";
      this.colIsPredefined.Name = "colIsPredefined";
      this.colIsPredefined.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colAssignedControl
      // 
      this.colAssignedControl.FieldName = "AssignedControl";
      this.colAssignedControl.Name = "colAssignedControl";
      this.colAssignedControl.OptionsColumn.ReadOnly = true;
      this.colAssignedControl.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colDatabase
      // 
      this.colDatabase.FieldName = "Database";
      this.colDatabase.Name = "colDatabase";
      this.colDatabase.OptionsColumn.ReadOnly = true;
      this.colDatabase.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // PredefinedPositionControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridPosition);
      this.Name = "PredefinedPositionControl";
      this.Size = new System.Drawing.Size(824, 309);
      ((System.ComponentModel.ISupportInitialize)(this.gridPosition)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewPosition)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpTypes)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridPosition;
    private DevExpress.XtraGrid.Views.Grid.GridView viewPosition;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpTypes;
    private System.Windows.Forms.BindingSource positionBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colDisplayName;
    private DevExpress.XtraGrid.Columns.GridColumn colFkOrder;
    private DevExpress.XtraGrid.Columns.GridColumn colPositionTotal;
    private DevExpress.XtraGrid.Columns.GridColumn colIsPredefined;
    private DevExpress.XtraGrid.Columns.GridColumn colAssignedControl;
    private DevExpress.XtraGrid.Columns.GridColumn colDatabase;
  }
}
