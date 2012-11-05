using Impressio.Models;

namespace Impressio.Controls
{
  partial class Paper
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
      this.gridPaper = new DevExpress.XtraGrid.GridControl();
      this.paperBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.viewPaper = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTable = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
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
      this.directionComobBox = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
      this.colDirectionString = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colSizeL = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colSizeB = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
      this.directionLookUp = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridPaper)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.paperBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewPaper)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.directionComobBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.directionLookUp)).BeginInit();
      this.SuspendLayout();
      // 
      // gridPaper
      // 
      this.gridPaper.DataSource = this.paperBindingSource;
      this.gridPaper.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridPaper.Location = new System.Drawing.Point(0, 0);
      this.gridPaper.MainView = this.viewPaper;
      this.gridPaper.Name = "gridPaper";
      this.gridPaper.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.directionComobBox,
            this.directionLookUp});
      this.gridPaper.Size = new System.Drawing.Size(892, 354);
      this.gridPaper.TabIndex = 0;
      this.gridPaper.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewPaper});
      // 
      // paperBindingSource
      // 
      this.paperBindingSource.DataSource = typeof(Models.Paper);
      // 
      // viewPaper
      // 
      this.viewPaper.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
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
            this.colSizeL,
            this.colSizeB,
            this.colSize});
      this.viewPaper.GridControl = this.gridPaper;
      this.viewPaper.Name = "viewPaper";
      this.viewPaper.OptionsDetail.AllowZoomDetail = false;
      this.viewPaper.OptionsDetail.EnableMasterViewMode = false;
      this.viewPaper.OptionsDetail.ShowDetailTabs = false;
      this.viewPaper.OptionsDetail.SmartDetailExpand = false;
      this.viewPaper.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.viewPaper.OptionsView.ShowAutoFilterRow = true;
      this.viewPaper.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.ViewPaperInvalidRowException);
      this.viewPaper.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.ViewPaperValidateRow);
      this.viewPaper.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.ViewPaperRowUpdated);
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
      // colItemNumber
      // 
      this.colItemNumber.Caption = "Art Nummer";
      this.colItemNumber.FieldName = "ItemNumber";
      this.colItemNumber.Name = "colItemNumber";
      this.colItemNumber.Visible = true;
      this.colItemNumber.VisibleIndex = 1;
      // 
      // colVendor
      // 
      this.colVendor.Caption = "Verkäufer";
      this.colVendor.FieldName = "Vendor";
      this.colVendor.Name = "colVendor";
      this.colVendor.Visible = true;
      this.colVendor.VisibleIndex = 2;
      // 
      // colPrice1
      // 
      this.colPrice1.Caption = "Preisstufe 1";
      this.colPrice1.DisplayFormat.FormatString = "c";
      this.colPrice1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colPrice1.FieldName = "Price1";
      this.colPrice1.Name = "colPrice1";
      this.colPrice1.Visible = true;
      this.colPrice1.VisibleIndex = 3;
      // 
      // colPrice2
      // 
      this.colPrice2.Caption = "Preisstufe 2";
      this.colPrice2.DisplayFormat.FormatString = "c";
      this.colPrice2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colPrice2.FieldName = "Price2";
      this.colPrice2.Name = "colPrice2";
      this.colPrice2.Visible = true;
      this.colPrice2.VisibleIndex = 4;
      // 
      // colPrice3
      // 
      this.colPrice3.Caption = "Preisstufe 3";
      this.colPrice3.DisplayFormat.FormatString = "c";
      this.colPrice3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colPrice3.FieldName = "Price3";
      this.colPrice3.Name = "colPrice3";
      this.colPrice3.Visible = true;
      this.colPrice3.VisibleIndex = 5;
      // 
      // colPrice4
      // 
      this.colPrice4.Caption = "Preisstufe 4";
      this.colPrice4.DisplayFormat.FormatString = "c";
      this.colPrice4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colPrice4.FieldName = "Price4";
      this.colPrice4.Name = "colPrice4";
      this.colPrice4.Visible = true;
      this.colPrice4.VisibleIndex = 6;
      // 
      // colAmount1
      // 
      this.colAmount1.Caption = "Menge 1";
      this.colAmount1.DisplayFormat.FormatString = "N0";
      this.colAmount1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colAmount1.FieldName = "Amount1";
      this.colAmount1.Name = "colAmount1";
      this.colAmount1.Visible = true;
      this.colAmount1.VisibleIndex = 7;
      // 
      // colAmount2
      // 
      this.colAmount2.Caption = "Menge 2";
      this.colAmount2.DisplayFormat.FormatString = "N0";
      this.colAmount2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colAmount2.FieldName = "Amount2";
      this.colAmount2.Name = "colAmount2";
      this.colAmount2.Visible = true;
      this.colAmount2.VisibleIndex = 8;
      // 
      // colAmount3
      // 
      this.colAmount3.Caption = "Menge 3";
      this.colAmount3.DisplayFormat.FormatString = "N0";
      this.colAmount3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colAmount3.FieldName = "Amount3";
      this.colAmount3.Name = "colAmount3";
      this.colAmount3.Visible = true;
      this.colAmount3.VisibleIndex = 9;
      // 
      // colDirection
      // 
      this.colDirection.ColumnEdit = this.directionComobBox;
      this.colDirection.FieldName = "Direction";
      this.colDirection.Name = "colDirection";
      // 
      // directionComobBox
      // 
      this.directionComobBox.AutoHeight = false;
      this.directionComobBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.directionComobBox.DropDownRows = 2;
      this.directionComobBox.EditFormat.FormatString = "N0";
      this.directionComobBox.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.directionComobBox.Items.AddRange(new object[] {
            "SB",
            "BB"});
      this.directionComobBox.Name = "directionComobBox";
      this.directionComobBox.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      // 
      // colDirectionString
      // 
      this.colDirectionString.Caption = "Laufrichtung";
      this.colDirectionString.ColumnEdit = this.directionComobBox;
      this.colDirectionString.FieldName = "DirectionString";
      this.colDirectionString.Name = "colDirectionString";
      this.colDirectionString.Visible = true;
      this.colDirectionString.VisibleIndex = 10;
      // 
      // colSizeL
      // 
      this.colSizeL.Caption = "Länge";
      this.colSizeL.DisplayFormat.FormatString = "{0} mm";
      this.colSizeL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
      this.colSizeL.FieldName = "SizeL";
      this.colSizeL.Name = "colSizeL";
      this.colSizeL.Visible = true;
      this.colSizeL.VisibleIndex = 11;
      // 
      // colSizeB
      // 
      this.colSizeB.Caption = "Breite";
      this.colSizeB.DisplayFormat.FormatString = "{0} mm";
      this.colSizeB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
      this.colSizeB.FieldName = "SizeB";
      this.colSizeB.Name = "colSizeB";
      this.colSizeB.Visible = true;
      this.colSizeB.VisibleIndex = 12;
      // 
      // colSize
      // 
      this.colSize.FieldName = "Size";
      this.colSize.Name = "colSize";
      this.colSize.OptionsColumn.ReadOnly = true;
      // 
      // directionLookUp
      // 
      this.directionLookUp.AutoHeight = false;
      this.directionLookUp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.directionLookUp.DropDownRows = 2;
      this.directionLookUp.Name = "directionLookUp";
      this.directionLookUp.NullText = "";
      this.directionLookUp.ShowFooter = false;
      this.directionLookUp.ShowHeader = false;
      this.directionLookUp.ShowLines = false;
      // 
      // Paper
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridPaper);
      this.Name = "Paper";
      this.Size = new System.Drawing.Size(892, 354);
      this.Load += new System.EventHandler(this.PaperControlLoad);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridPaper)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.paperBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewPaper)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.directionComobBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.directionLookUp)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridPaper;
    private System.Windows.Forms.BindingSource paperBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
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
    private DevExpress.XtraGrid.Columns.GridColumn colSizeL;
    private DevExpress.XtraGrid.Columns.GridColumn colSizeB;
    private DevExpress.XtraGrid.Columns.GridColumn colSize;
    private DevExpress.XtraEditors.Repository.RepositoryItemComboBox directionComobBox;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit directionLookUp;
    public DevExpress.XtraGrid.Views.Grid.GridView viewPaper;
  }
}
