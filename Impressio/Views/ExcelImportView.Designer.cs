namespace Impressio.Views
{
  partial class ExcelImportView
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.gridExcel = new DevExpress.XtraGrid.GridControl();
      this.paperBindingSource = new System.Windows.Forms.BindingSource();
      this.viewExcel = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colIdentityColumn = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTable = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.columnsExcel = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
      this.colItemNumber = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colVendor = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPrice2 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPrice3 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPrice4 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAmount2 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAmount3 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDirection = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDirectionString = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colSizeL = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colSizeB = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDatabase = new DevExpress.XtraGrid.Columns.GridColumn();
      this.excelSheet = new DevExpress.XtraEditors.ComboBoxEdit();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
      this.vGridColumns = new DevExpress.XtraVerticalGrid.VGridControl();
      this.comboExcelColumn = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
      this.nameRow = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
      this.numberRow = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
      this.weightRow = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
      this.lenghtRow = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
      this.widthRow = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
      this.directionRow = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
      this.quantity1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
      this.quantity2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
      this.quantity3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
      this.price1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
      this.price2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
      this.price3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
      this.price4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
      this.vendorRow = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
      this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
      this.import = new DevExpress.XtraEditors.SimpleButton();
      this.preview = new DevExpress.XtraEditors.SimpleButton();
      this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
      this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
      ((System.ComponentModel.ISupportInitialize)(this.gridExcel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.paperBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewExcel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.columnsExcel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.excelSheet.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
      this.panelControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.vGridColumns)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.comboExcelColumn)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
      this.panelControl2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
      this.panelControl3.SuspendLayout();
      this.SuspendLayout();
      // 
      // gridExcel
      // 
      this.gridExcel.DataSource = this.paperBindingSource;
      this.gridExcel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridExcel.Location = new System.Drawing.Point(2, 2);
      this.gridExcel.MainView = this.viewExcel;
      this.gridExcel.Name = "gridExcel";
      this.gridExcel.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.columnsExcel});
      this.gridExcel.Size = new System.Drawing.Size(759, 208);
      this.gridExcel.TabIndex = 0;
      this.gridExcel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewExcel});
      // 
      // paperBindingSource
      // 
      this.paperBindingSource.DataSource = typeof(Impressio.Models.Paper);
      // 
      // viewExcel
      // 
      this.viewExcel.ColumnPanelRowHeight = 30;
      this.viewExcel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colIdentityColumn,
            this.colTable,
            this.colName,
            this.colItemNumber,
            this.colVendor,
            this.colPrice1,
            this.colPrice2,
            this.colPrice3,
            this.colPrice4,
            this.colAmount1,
            this.colAmount2,
            this.colAmount3,
            this.colDirection,
            this.colDirectionString,
            this.colWeight,
            this.colSizeL,
            this.colSizeB,
            this.colSize,
            this.colDatabase});
      this.viewExcel.GridControl = this.gridExcel;
      this.viewExcel.IndicatorWidth = 30;
      this.viewExcel.Name = "viewExcel";
      this.viewExcel.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
      this.viewExcel.OptionsBehavior.ReadOnly = true;
      this.viewExcel.OptionsDetail.AllowZoomDetail = false;
      this.viewExcel.OptionsDetail.EnableMasterViewMode = false;
      this.viewExcel.OptionsDetail.ShowDetailTabs = false;
      this.viewExcel.OptionsDetail.SmartDetailExpand = false;
      this.viewExcel.OptionsMenu.EnableColumnMenu = false;
      this.viewExcel.OptionsMenu.EnableFooterMenu = false;
      this.viewExcel.OptionsMenu.EnableGroupPanelMenu = false;
      this.viewExcel.OptionsMenu.ShowAutoFilterRowItem = false;
      this.viewExcel.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
      this.viewExcel.OptionsMenu.ShowGroupSortSummaryItems = false;
      this.viewExcel.OptionsView.ShowGroupPanel = false;
      this.viewExcel.RowHeight = 30;
      this.viewExcel.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ViewExcelFocusedRowChanged);
      // 
      // colIdentity
      // 
      this.colIdentity.FieldName = "Identity";
      this.colIdentity.Name = "colIdentity";
      this.colIdentity.OptionsColumn.AllowEdit = false;
      this.colIdentity.OptionsColumn.AllowShowHide = false;
      this.colIdentity.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colIdentityColumn
      // 
      this.colIdentityColumn.FieldName = "IdentityColumn";
      this.colIdentityColumn.Name = "colIdentityColumn";
      this.colIdentityColumn.OptionsColumn.AllowEdit = false;
      this.colIdentityColumn.OptionsColumn.AllowShowHide = false;
      this.colIdentityColumn.OptionsColumn.ReadOnly = true;
      this.colIdentityColumn.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colTable
      // 
      this.colTable.FieldName = "Table";
      this.colTable.Name = "colTable";
      this.colTable.OptionsColumn.AllowEdit = false;
      this.colTable.OptionsColumn.AllowShowHide = false;
      this.colTable.OptionsColumn.ReadOnly = true;
      this.colTable.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colName
      // 
      this.colName.ColumnEdit = this.columnsExcel;
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // columnsExcel
      // 
      this.columnsExcel.AutoHeight = false;
      this.columnsExcel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.columnsExcel.Name = "columnsExcel";
      this.columnsExcel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      // 
      // colItemNumber
      // 
      this.colItemNumber.Caption = "Bestellnummer";
      this.colItemNumber.ColumnEdit = this.columnsExcel;
      this.colItemNumber.FieldName = "ItemNumber";
      this.colItemNumber.Name = "colItemNumber";
      this.colItemNumber.Visible = true;
      this.colItemNumber.VisibleIndex = 1;
      // 
      // colVendor
      // 
      this.colVendor.Caption = "Verkäufer";
      this.colVendor.ColumnEdit = this.columnsExcel;
      this.colVendor.FieldName = "Vendor";
      this.colVendor.Name = "colVendor";
      this.colVendor.Visible = true;
      this.colVendor.VisibleIndex = 2;
      // 
      // colPrice1
      // 
      this.colPrice1.Caption = "Preis 1";
      this.colPrice1.ColumnEdit = this.columnsExcel;
      this.colPrice1.FieldName = "Price1";
      this.colPrice1.Name = "colPrice1";
      this.colPrice1.Visible = true;
      this.colPrice1.VisibleIndex = 3;
      // 
      // colPrice2
      // 
      this.colPrice2.Caption = "Preis 2";
      this.colPrice2.ColumnEdit = this.columnsExcel;
      this.colPrice2.FieldName = "Price2";
      this.colPrice2.Name = "colPrice2";
      this.colPrice2.Visible = true;
      this.colPrice2.VisibleIndex = 4;
      // 
      // colPrice3
      // 
      this.colPrice3.Caption = "Preis 3";
      this.colPrice3.ColumnEdit = this.columnsExcel;
      this.colPrice3.FieldName = "Price3";
      this.colPrice3.Name = "colPrice3";
      this.colPrice3.Visible = true;
      this.colPrice3.VisibleIndex = 5;
      // 
      // colPrice4
      // 
      this.colPrice4.Caption = "Preis 4";
      this.colPrice4.ColumnEdit = this.columnsExcel;
      this.colPrice4.FieldName = "Price4";
      this.colPrice4.Name = "colPrice4";
      this.colPrice4.Visible = true;
      this.colPrice4.VisibleIndex = 6;
      // 
      // colAmount1
      // 
      this.colAmount1.Caption = "Menge 1";
      this.colAmount1.ColumnEdit = this.columnsExcel;
      this.colAmount1.FieldName = "Amount1";
      this.colAmount1.Name = "colAmount1";
      this.colAmount1.Visible = true;
      this.colAmount1.VisibleIndex = 7;
      // 
      // colAmount2
      // 
      this.colAmount2.Caption = "Menge 2";
      this.colAmount2.ColumnEdit = this.columnsExcel;
      this.colAmount2.FieldName = "Amount2";
      this.colAmount2.Name = "colAmount2";
      this.colAmount2.Visible = true;
      this.colAmount2.VisibleIndex = 8;
      // 
      // colAmount3
      // 
      this.colAmount3.Caption = "Menge 3";
      this.colAmount3.ColumnEdit = this.columnsExcel;
      this.colAmount3.FieldName = "Amount3";
      this.colAmount3.Name = "colAmount3";
      this.colAmount3.Visible = true;
      this.colAmount3.VisibleIndex = 9;
      // 
      // colDirection
      // 
      this.colDirection.Caption = "Laufrichtung";
      this.colDirection.ColumnEdit = this.columnsExcel;
      this.colDirection.FieldName = "Direction";
      this.colDirection.Name = "colDirection";
      this.colDirection.Visible = true;
      this.colDirection.VisibleIndex = 10;
      // 
      // colDirectionString
      // 
      this.colDirectionString.FieldName = "DirectionString";
      this.colDirectionString.Name = "colDirectionString";
      this.colDirectionString.OptionsColumn.AllowEdit = false;
      this.colDirectionString.OptionsColumn.AllowShowHide = false;
      this.colDirectionString.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colWeight
      // 
      this.colWeight.Caption = "Grammatur";
      this.colWeight.ColumnEdit = this.columnsExcel;
      this.colWeight.FieldName = "Weight";
      this.colWeight.Name = "colWeight";
      this.colWeight.Visible = true;
      this.colWeight.VisibleIndex = 11;
      // 
      // colSizeL
      // 
      this.colSizeL.Caption = "Länge";
      this.colSizeL.ColumnEdit = this.columnsExcel;
      this.colSizeL.FieldName = "SizeL";
      this.colSizeL.Name = "colSizeL";
      this.colSizeL.Visible = true;
      this.colSizeL.VisibleIndex = 12;
      // 
      // colSizeB
      // 
      this.colSizeB.Caption = "Breite";
      this.colSizeB.ColumnEdit = this.columnsExcel;
      this.colSizeB.FieldName = "SizeB";
      this.colSizeB.Name = "colSizeB";
      this.colSizeB.Visible = true;
      this.colSizeB.VisibleIndex = 13;
      // 
      // colSize
      // 
      this.colSize.FieldName = "Size";
      this.colSize.Name = "colSize";
      this.colSize.OptionsColumn.AllowEdit = false;
      this.colSize.OptionsColumn.AllowShowHide = false;
      this.colSize.OptionsColumn.ReadOnly = true;
      this.colSize.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colDatabase
      // 
      this.colDatabase.FieldName = "Database";
      this.colDatabase.Name = "colDatabase";
      this.colDatabase.OptionsColumn.AllowEdit = false;
      this.colDatabase.OptionsColumn.AllowShowHide = false;
      this.colDatabase.OptionsColumn.ReadOnly = true;
      this.colDatabase.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // excelSheet
      // 
      this.excelSheet.Location = new System.Drawing.Point(101, 14);
      this.excelSheet.Name = "excelSheet";
      this.excelSheet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.excelSheet.Size = new System.Drawing.Size(276, 20);
      this.excelSheet.TabIndex = 1;
      this.excelSheet.SelectedIndexChanged += new System.EventHandler(this.ExcelSheetSelectedIndexChanged);
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(17, 17);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(52, 13);
      this.labelControl1.TabIndex = 2;
      this.labelControl1.Text = "Excel Seite";
      // 
      // panelControl1
      // 
      this.panelControl1.Controls.Add(this.vGridColumns);
      this.panelControl1.Controls.Add(this.panelControl2);
      this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelControl1.Location = new System.Drawing.Point(0, 0);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new System.Drawing.Size(763, 241);
      this.panelControl1.TabIndex = 3;
      // 
      // vGridColumns
      // 
      this.vGridColumns.Dock = System.Windows.Forms.DockStyle.Fill;
      this.vGridColumns.Location = new System.Drawing.Point(2, 2);
      this.vGridColumns.Name = "vGridColumns";
      this.vGridColumns.RecordWidth = 1500;
      this.vGridColumns.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.comboExcelColumn});
      this.vGridColumns.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.nameRow,
            this.numberRow,
            this.weightRow,
            this.lenghtRow,
            this.widthRow,
            this.directionRow,
            this.quantity1,
            this.quantity2,
            this.quantity3,
            this.price1,
            this.price2,
            this.price3,
            this.price4,
            this.vendorRow});
      this.vGridColumns.Size = new System.Drawing.Size(759, 191);
      this.vGridColumns.TabIndex = 3;
      // 
      // comboExcelColumn
      // 
      this.comboExcelColumn.AutoHeight = false;
      this.comboExcelColumn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.comboExcelColumn.Name = "comboExcelColumn";
      this.comboExcelColumn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      // 
      // nameRow
      // 
      this.nameRow.Height = 30;
      this.nameRow.Name = "nameRow";
      this.nameRow.Properties.Caption = "Papiername";
      this.nameRow.Properties.RowEdit = this.comboExcelColumn;
      // 
      // numberRow
      // 
      this.numberRow.Height = 30;
      this.numberRow.Name = "numberRow";
      this.numberRow.Properties.Caption = "Artikelnummer";
      this.numberRow.Properties.RowEdit = this.comboExcelColumn;
      // 
      // weightRow
      // 
      this.weightRow.Height = 30;
      this.weightRow.Name = "weightRow";
      this.weightRow.Properties.Caption = "Grammatur";
      this.weightRow.Properties.RowEdit = this.comboExcelColumn;
      // 
      // lenghtRow
      // 
      this.lenghtRow.Height = 30;
      this.lenghtRow.Name = "lenghtRow";
      this.lenghtRow.Properties.Caption = "Länge";
      this.lenghtRow.Properties.RowEdit = this.comboExcelColumn;
      // 
      // widthRow
      // 
      this.widthRow.Height = 30;
      this.widthRow.Name = "widthRow";
      this.widthRow.Properties.Caption = "Breite";
      this.widthRow.Properties.RowEdit = this.comboExcelColumn;
      // 
      // directionRow
      // 
      this.directionRow.Height = 30;
      this.directionRow.Name = "directionRow";
      this.directionRow.Properties.Caption = "Laufrichtung";
      this.directionRow.Properties.RowEdit = this.comboExcelColumn;
      // 
      // quantity1
      // 
      this.quantity1.Height = 30;
      this.quantity1.Name = "quantity1";
      this.quantity1.Properties.Caption = "Menge 1";
      this.quantity1.Properties.RowEdit = this.comboExcelColumn;
      // 
      // quantity2
      // 
      this.quantity2.Height = 30;
      this.quantity2.Name = "quantity2";
      this.quantity2.Properties.Caption = "Menge 2";
      this.quantity2.Properties.RowEdit = this.comboExcelColumn;
      // 
      // quantity3
      // 
      this.quantity3.Height = 30;
      this.quantity3.Name = "quantity3";
      this.quantity3.Properties.Caption = "Menge 3";
      this.quantity3.Properties.RowEdit = this.comboExcelColumn;
      // 
      // price1
      // 
      this.price1.Height = 30;
      this.price1.Name = "price1";
      this.price1.Properties.Caption = "Preisstufe 1";
      this.price1.Properties.RowEdit = this.comboExcelColumn;
      // 
      // price2
      // 
      this.price2.Height = 30;
      this.price2.Name = "price2";
      this.price2.Properties.Caption = "Preisstufe 2";
      this.price2.Properties.RowEdit = this.comboExcelColumn;
      // 
      // price3
      // 
      this.price3.Height = 30;
      this.price3.Name = "price3";
      this.price3.Properties.Caption = "Preisstufe 3";
      this.price3.Properties.RowEdit = this.comboExcelColumn;
      // 
      // price4
      // 
      this.price4.Height = 30;
      this.price4.Name = "price4";
      this.price4.Properties.Caption = "Preisstufe 4";
      this.price4.Properties.RowEdit = this.comboExcelColumn;
      // 
      // vendorRow
      // 
      this.vendorRow.Height = 30;
      this.vendorRow.Name = "vendorRow";
      this.vendorRow.Properties.Caption = "Verkäufer";
      this.vendorRow.Properties.RowEdit = this.comboExcelColumn;
      // 
      // panelControl2
      // 
      this.panelControl2.Controls.Add(this.excelSheet);
      this.panelControl2.Controls.Add(this.import);
      this.panelControl2.Controls.Add(this.labelControl1);
      this.panelControl2.Controls.Add(this.preview);
      this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelControl2.Location = new System.Drawing.Point(2, 193);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new System.Drawing.Size(759, 46);
      this.panelControl2.TabIndex = 4;
      // 
      // import
      // 
      this.import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.import.Location = new System.Drawing.Point(674, 11);
      this.import.Name = "import";
      this.import.Size = new System.Drawing.Size(75, 23);
      this.import.TabIndex = 5;
      this.import.Text = "Einfügen";
      this.import.Click += new System.EventHandler(this.ImportClick);
      // 
      // preview
      // 
      this.preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.preview.Location = new System.Drawing.Point(586, 11);
      this.preview.Name = "preview";
      this.preview.Size = new System.Drawing.Size(75, 23);
      this.preview.TabIndex = 4;
      this.preview.Text = "Vorschau";
      this.preview.Click += new System.EventHandler(this.PreviewButtonClick);
      // 
      // splitterControl1
      // 
      this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
      this.splitterControl1.Location = new System.Drawing.Point(0, 241);
      this.splitterControl1.Name = "splitterControl1";
      this.splitterControl1.Size = new System.Drawing.Size(763, 5);
      this.splitterControl1.TabIndex = 4;
      this.splitterControl1.TabStop = false;
      // 
      // panelControl3
      // 
      this.panelControl3.Controls.Add(this.gridExcel);
      this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelControl3.Location = new System.Drawing.Point(0, 246);
      this.panelControl3.Name = "panelControl3";
      this.panelControl3.Size = new System.Drawing.Size(763, 212);
      this.panelControl3.TabIndex = 5;
      // 
      // ExcelImportView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(763, 458);
      this.Controls.Add(this.panelControl3);
      this.Controls.Add(this.splitterControl1);
      this.Controls.Add(this.panelControl1);
      this.Name = "ExcelImportView";
      this.ShowIcon = false;
      this.Load += new System.EventHandler(this.ExcelImportViewLoad);
      ((System.ComponentModel.ISupportInitialize)(this.gridExcel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.paperBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewExcel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.columnsExcel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.excelSheet.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
      this.panelControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.vGridColumns)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.comboExcelColumn)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
      this.panelControl2.ResumeLayout(false);
      this.panelControl2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
      this.panelControl3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridExcel;
    private DevExpress.XtraGrid.Views.Grid.GridView viewExcel;
    private System.Windows.Forms.BindingSource paperBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentityColumn;
    private DevExpress.XtraGrid.Columns.GridColumn colTable;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colItemNumber;
    private DevExpress.XtraGrid.Columns.GridColumn colVendor;
    private DevExpress.XtraGrid.Columns.GridColumn colPrice1;
    private DevExpress.XtraGrid.Columns.GridColumn colPrice2;
    private DevExpress.XtraGrid.Columns.GridColumn colPrice3;
    private DevExpress.XtraGrid.Columns.GridColumn colPrice4;
    private DevExpress.XtraGrid.Columns.GridColumn colAmount1;
    private DevExpress.XtraGrid.Columns.GridColumn colAmount2;
    private DevExpress.XtraGrid.Columns.GridColumn colAmount3;
    private DevExpress.XtraGrid.Columns.GridColumn colDirection;
    private DevExpress.XtraGrid.Columns.GridColumn colDirectionString;
    private DevExpress.XtraGrid.Columns.GridColumn colWeight;
    private DevExpress.XtraGrid.Columns.GridColumn colSizeL;
    private DevExpress.XtraGrid.Columns.GridColumn colSizeB;
    private DevExpress.XtraGrid.Columns.GridColumn colSize;
    private DevExpress.XtraGrid.Columns.GridColumn colDatabase;
    private DevExpress.XtraEditors.Repository.RepositoryItemComboBox columnsExcel;
    private DevExpress.XtraEditors.ComboBoxEdit excelSheet;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraVerticalGrid.VGridControl vGridColumns;
    private DevExpress.XtraEditors.Repository.RepositoryItemComboBox comboExcelColumn;
    private DevExpress.XtraVerticalGrid.Rows.EditorRow nameRow;
    private DevExpress.XtraEditors.SimpleButton preview;
    private DevExpress.XtraEditors.SimpleButton import;
    private DevExpress.XtraVerticalGrid.Rows.EditorRow numberRow;
    private DevExpress.XtraVerticalGrid.Rows.EditorRow weightRow;
    private DevExpress.XtraVerticalGrid.Rows.EditorRow lenghtRow;
    private DevExpress.XtraVerticalGrid.Rows.EditorRow widthRow;
    private DevExpress.XtraVerticalGrid.Rows.EditorRow directionRow;
    private DevExpress.XtraVerticalGrid.Rows.EditorRow quantity1;
    private DevExpress.XtraVerticalGrid.Rows.EditorRow quantity2;
    private DevExpress.XtraVerticalGrid.Rows.EditorRow quantity3;
    private DevExpress.XtraVerticalGrid.Rows.EditorRow price1;
    private DevExpress.XtraVerticalGrid.Rows.EditorRow price2;
    private DevExpress.XtraVerticalGrid.Rows.EditorRow price3;
    private DevExpress.XtraVerticalGrid.Rows.EditorRow price4;
    private DevExpress.XtraVerticalGrid.Rows.EditorRow vendorRow;
    private DevExpress.XtraEditors.PanelControl panelControl2;
    private DevExpress.XtraEditors.SplitterControl splitterControl1;
    private DevExpress.XtraEditors.PanelControl panelControl3;
  }
}