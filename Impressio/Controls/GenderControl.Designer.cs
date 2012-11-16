namespace Impressio.Controls
{
  partial class GenderControl
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
      this.gridGender = new DevExpress.XtraGrid.GridControl();
      this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.viewGender = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTable = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridGender)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewGender)).BeginInit();
      this.SuspendLayout();
      // 
      // gridGender
      // 
      this.gridGender.DataSource = this.genderBindingSource;
      this.gridGender.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridGender.Location = new System.Drawing.Point(0, 0);
      this.gridGender.MainView = this.viewGender;
      this.gridGender.Name = "gridGender";
      this.gridGender.Size = new System.Drawing.Size(879, 425);
      this.gridGender.TabIndex = 0;
      this.gridGender.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewGender});
      // 
      // genderBindingSource
      // 
      this.genderBindingSource.DataSource = typeof(Impressio.Models.Gender);
      // 
      // viewGender
      // 
      this.viewGender.ColumnPanelRowHeight = 30;
      this.viewGender.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colTable,
            this.colName});
      this.viewGender.GridControl = this.gridGender;
      this.viewGender.IndicatorWidth = 30;
      this.viewGender.Name = "viewGender";
      this.viewGender.OptionsDetail.AllowZoomDetail = false;
      this.viewGender.OptionsDetail.EnableMasterViewMode = false;
      this.viewGender.OptionsDetail.ShowDetailTabs = false;
      this.viewGender.OptionsDetail.SmartDetailExpand = false;
      this.viewGender.OptionsMenu.EnableColumnMenu = false;
      this.viewGender.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.viewGender.OptionsView.ShowGroupPanel = false;
      this.viewGender.RowHeight = 30;
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
      // GenderControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridGender);
      this.Name = "GenderControl";
      this.Size = new System.Drawing.Size(879, 425);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridGender)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewGender)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridGender;
    private DevExpress.XtraGrid.Views.Grid.GridView viewGender;
    private System.Windows.Forms.BindingSource genderBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
    private DevExpress.XtraGrid.Columns.GridColumn colTable;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
  }
}
