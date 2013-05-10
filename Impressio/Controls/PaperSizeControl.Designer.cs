namespace Impressio.Controls
{
  partial class PaperSizeControl
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
      this.paperSizeGrid = new DevExpress.XtraGrid.GridControl();
      this.paperSizesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.paperSizeView = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colWidth = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colHeight = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colIsFinishSize = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colIdentityColumn = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTable = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDatabase = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.paperSizeGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.paperSizesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.paperSizeView)).BeginInit();
      this.SuspendLayout();
      // 
      // paperSizeGrid
      // 
      this.paperSizeGrid.DataSource = this.paperSizesBindingSource;
      this.paperSizeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.paperSizeGrid.Location = new System.Drawing.Point(0, 0);
      this.paperSizeGrid.MainView = this.paperSizeView;
      this.paperSizeGrid.Name = "paperSizeGrid";
      this.paperSizeGrid.Size = new System.Drawing.Size(624, 376);
      this.paperSizeGrid.TabIndex = 0;
      this.paperSizeGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.paperSizeView});
      // 
      // paperSizesBindingSource
      // 
      this.paperSizesBindingSource.DataSource = typeof(Impressio.Models.PaperSizes);
      // 
      // paperSizeView
      // 
      this.paperSizeView.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
      this.paperSizeView.Appearance.EvenRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.paperSizeView.Appearance.EvenRow.Options.UseBackColor = true;
      this.paperSizeView.ColumnPanelRowHeight = 25;
      this.paperSizeView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWidth,
            this.colHeight,
            this.colSize,
            this.colName,
            this.colIsFinishSize,
            this.colIdentity,
            this.colIdentityColumn,
            this.colTable,
            this.colDatabase});
      this.paperSizeView.GridControl = this.paperSizeGrid;
      this.paperSizeView.GroupRowHeight = 25;
      this.paperSizeView.Name = "paperSizeView";
      this.paperSizeView.OptionsDetail.AllowZoomDetail = false;
      this.paperSizeView.OptionsDetail.EnableMasterViewMode = false;
      this.paperSizeView.OptionsDetail.ShowDetailTabs = false;
      this.paperSizeView.OptionsDetail.SmartDetailExpand = false;
      this.paperSizeView.OptionsView.EnableAppearanceEvenRow = true;
      this.paperSizeView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.paperSizeView.OptionsView.ShowGroupPanel = false;
      this.paperSizeView.OptionsView.ShowIndicator = false;
      this.paperSizeView.RowHeight = 25;
      // 
      // colWidth
      // 
      this.colWidth.Caption = "Breite";
      this.colWidth.DisplayFormat.FormatString = "{0} mm";
      this.colWidth.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colWidth.FieldName = "Width";
      this.colWidth.Name = "colWidth";
      this.colWidth.Visible = true;
      this.colWidth.VisibleIndex = 1;
      // 
      // colHeight
      // 
      this.colHeight.Caption = "Höhe";
      this.colHeight.DisplayFormat.FormatString = "{0} mm";
      this.colHeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colHeight.FieldName = "Height";
      this.colHeight.Name = "colHeight";
      this.colHeight.Visible = true;
      this.colHeight.VisibleIndex = 2;
      // 
      // colSize
      // 
      this.colSize.FieldName = "Size";
      this.colSize.Name = "colSize";
      this.colSize.OptionsColumn.AllowEdit = false;
      this.colSize.OptionsColumn.ReadOnly = true;
      this.colSize.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colName
      // 
      this.colName.Caption = "Name";
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // colIsFinishSize
      // 
      this.colIsFinishSize.Caption = "Endformat";
      this.colIsFinishSize.FieldName = "IsFinishSize";
      this.colIsFinishSize.Name = "colIsFinishSize";
      this.colIsFinishSize.Visible = true;
      this.colIsFinishSize.VisibleIndex = 3;
      // 
      // colIdentity
      // 
      this.colIdentity.FieldName = "Identity";
      this.colIdentity.Name = "colIdentity";
      this.colIdentity.OptionsColumn.AllowEdit = false;
      this.colIdentity.OptionsColumn.ReadOnly = true;
      this.colIdentity.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colIdentityColumn
      // 
      this.colIdentityColumn.FieldName = "IdentityColumn";
      this.colIdentityColumn.Name = "colIdentityColumn";
      this.colIdentityColumn.OptionsColumn.AllowEdit = false;
      this.colIdentityColumn.OptionsColumn.ReadOnly = true;
      this.colIdentityColumn.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colTable
      // 
      this.colTable.FieldName = "Table";
      this.colTable.Name = "colTable";
      this.colTable.OptionsColumn.AllowEdit = false;
      this.colTable.OptionsColumn.ReadOnly = true;
      this.colTable.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colDatabase
      // 
      this.colDatabase.FieldName = "Database";
      this.colDatabase.Name = "colDatabase";
      this.colDatabase.OptionsColumn.AllowEdit = false;
      this.colDatabase.OptionsColumn.ReadOnly = true;
      this.colDatabase.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // PaperSizeControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.paperSizeGrid);
      this.Name = "PaperSizeControl";
      this.Size = new System.Drawing.Size(624, 376);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.paperSizeGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.paperSizesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.paperSizeView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl paperSizeGrid;
    private System.Windows.Forms.BindingSource paperSizesBindingSource;
    private DevExpress.XtraGrid.Views.Grid.GridView paperSizeView;
    private DevExpress.XtraGrid.Columns.GridColumn colWidth;
    private DevExpress.XtraGrid.Columns.GridColumn colHeight;
    private DevExpress.XtraGrid.Columns.GridColumn colSize;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colIsFinishSize;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentityColumn;
    private DevExpress.XtraGrid.Columns.GridColumn colTable;
    private DevExpress.XtraGrid.Columns.GridColumn colDatabase;
  }
}
