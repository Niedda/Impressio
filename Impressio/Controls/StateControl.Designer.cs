namespace Impressio.Controls
{
  partial class StateControl
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
      this.gridState = new DevExpress.XtraGrid.GridControl();
      this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.viewState = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTable = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colStateName = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridState)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewState)).BeginInit();
      this.SuspendLayout();
      // 
      // gridState
      // 
      this.gridState.DataSource = this.stateBindingSource;
      this.gridState.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridState.Location = new System.Drawing.Point(0, 0);
      this.gridState.MainView = this.viewState;
      this.gridState.Name = "gridState";
      this.gridState.Size = new System.Drawing.Size(896, 416);
      this.gridState.TabIndex = 0;
      this.gridState.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewState});
      // 
      // stateBindingSource
      // 
      this.stateBindingSource.DataSource = typeof(Impressio.Models.State);
      // 
      // viewState
      // 
      this.viewState.ColumnPanelRowHeight = 30;
      this.viewState.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colTable,
            this.colStateName});
      this.viewState.GridControl = this.gridState;
      this.viewState.IndicatorWidth = 30;
      this.viewState.Name = "viewState";
      this.viewState.OptionsDetail.AllowZoomDetail = false;
      this.viewState.OptionsDetail.EnableMasterViewMode = false;
      this.viewState.OptionsDetail.ShowDetailTabs = false;
      this.viewState.OptionsDetail.SmartDetailExpand = false;
      this.viewState.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.viewState.OptionsView.ShowGroupPanel = false;
      this.viewState.RowHeight = 30;
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
      // colStateName
      // 
      this.colStateName.Caption = "Status";
      this.colStateName.FieldName = "StateName";
      this.colStateName.Name = "colStateName";
      this.colStateName.Visible = true;
      this.colStateName.VisibleIndex = 0;
      // 
      // StateControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridState);
      this.Name = "StateControl";
      this.Size = new System.Drawing.Size(896, 416);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridState)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewState)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridState;
    private DevExpress.XtraGrid.Views.Grid.GridView viewState;
    private System.Windows.Forms.BindingSource stateBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
    private DevExpress.XtraGrid.Columns.GridColumn colTable;
    private DevExpress.XtraGrid.Columns.GridColumn colStateName;
  }
}
