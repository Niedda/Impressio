namespace Impressio.Controls
{
  partial class ClickCostControl
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
      this.gridClickCost = new DevExpress.XtraGrid.GridControl();
      this.clickCostBindingSource = new System.Windows.Forms.BindingSource();
      this.viewClickCost = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTable = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
      this.repositoryClickCost = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridClickCost)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.clickCostBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewClickCost)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryClickCost)).BeginInit();
      this.SuspendLayout();
      // 
      // gridClickCost
      // 
      this.gridClickCost.DataSource = this.clickCostBindingSource;
      this.gridClickCost.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridClickCost.Location = new System.Drawing.Point(0, 0);
      this.gridClickCost.MainView = this.viewClickCost;
      this.gridClickCost.Name = "gridClickCost";
      this.gridClickCost.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryClickCost});
      this.gridClickCost.Size = new System.Drawing.Size(879, 398);
      this.gridClickCost.TabIndex = 0;
      this.gridClickCost.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewClickCost});
      // 
      // clickCostBindingSource
      // 
      this.clickCostBindingSource.DataSource = typeof(Impressio.Models.ClickCost);
      // 
      // viewClickCost
      // 
      this.viewClickCost.ColumnPanelRowHeight = 30;
      this.viewClickCost.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colTable,
            this.colName,
            this.colCost});
      this.viewClickCost.GridControl = this.gridClickCost;
      this.viewClickCost.IndicatorWidth = 30;
      this.viewClickCost.Name = "viewClickCost";
      this.viewClickCost.OptionsDetail.AllowZoomDetail = false;
      this.viewClickCost.OptionsDetail.EnableMasterViewMode = false;
      this.viewClickCost.OptionsDetail.ShowDetailTabs = false;
      this.viewClickCost.OptionsDetail.SmartDetailExpand = false;
      this.viewClickCost.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.viewClickCost.OptionsView.ShowGroupPanel = false;
      this.viewClickCost.RowHeight = 30;
      // 
      // colIdentity
      // 
      this.colIdentity.FieldName = "Identity";
      this.colIdentity.Name = "colIdentity";
      // 
      // colTable
      // 
      this.colTable.FieldName = "Table";
      this.colTable.Name = "colTable";
      this.colTable.OptionsColumn.ReadOnly = true;
      // 
      // colName
      // 
      this.colName.Caption = "Name";
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // colCost
      // 
      this.colCost.Caption = "Klickkosten";
      this.colCost.ColumnEdit = this.repositoryClickCost;
      this.colCost.DisplayFormat.FormatString = "c";
      this.colCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colCost.FieldName = "Cost";
      this.colCost.Name = "colCost";
      this.colCost.Visible = true;
      this.colCost.VisibleIndex = 1;
      // 
      // repositoryClickCost
      // 
      this.repositoryClickCost.AutoHeight = false;
      this.repositoryClickCost.DisplayFormat.FormatString = "n0";
      this.repositoryClickCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.repositoryClickCost.EditFormat.FormatString = "n0";
      this.repositoryClickCost.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.repositoryClickCost.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
      this.repositoryClickCost.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.repositoryClickCost.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            196608});
      this.repositoryClickCost.Name = "repositoryClickCost";
      // 
      // ClickCostControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridClickCost);
      this.Name = "ClickCostControl";
      this.Size = new System.Drawing.Size(879, 398);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridClickCost)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.clickCostBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewClickCost)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryClickCost)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridClickCost;
    private DevExpress.XtraGrid.Views.Grid.GridView viewClickCost;
    private System.Windows.Forms.BindingSource clickCostBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
    private DevExpress.XtraGrid.Columns.GridColumn colTable;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colCost;
    private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryClickCost;
  }
}
