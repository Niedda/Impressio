using Impressio.Models;

namespace Impressio.Controls
{
    partial class DataControl
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.remarkEdit = new DevExpress.XtraEditors.MemoEdit();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.gridData = new DevExpress.XtraGrid.GridControl();
      this.dataPositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.viewData = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTable = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFkDataDataPosition = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPricePerQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPriceTotal = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.remarkEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataPositionBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewData)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.remarkEdit);
      this.groupBox1.Controls.Add(this.labelControl2);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(879, 111);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Datenaufbereitung";
      // 
      // remarkEdit
      // 
      this.remarkEdit.Location = new System.Drawing.Point(126, 37);
      this.remarkEdit.Name = "remarkEdit";
      this.remarkEdit.Size = new System.Drawing.Size(332, 42);
      this.remarkEdit.TabIndex = 3;
      this.remarkEdit.EditValueChanged += new System.EventHandler(this.RemarkEditEditValueChanged);
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(22, 40);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(65, 13);
      this.labelControl2.TabIndex = 1;
      this.labelControl2.Text = "Bemerkungen";
      // 
      // gridData
      // 
      this.gridData.DataSource = this.dataPositionBindingSource;
      this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridData.Location = new System.Drawing.Point(0, 111);
      this.gridData.MainView = this.viewData;
      this.gridData.Name = "gridData";
      this.gridData.Size = new System.Drawing.Size(879, 297);
      this.gridData.TabIndex = 1;
      this.gridData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewData});
      // 
      // dataPositionBindingSource
      // 
      this.dataPositionBindingSource.DataSource = typeof(Impressio.Models.DataPosition);
      // 
      // viewData
      // 
      this.viewData.ColumnPanelRowHeight = 30;
      this.viewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colTable,
            this.colQuantity,
            this.colFkDataDataPosition,
            this.colDescription,
            this.colPricePerQuantity,
            this.colPriceTotal});
      this.viewData.GridControl = this.gridData;
      this.viewData.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PositionTotal", this.colPriceTotal, "{0:c}")});
      this.viewData.IndicatorWidth = 50;
      this.viewData.Name = "viewData";
      this.viewData.OptionsDetail.EnableMasterViewMode = false;
      this.viewData.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.viewData.OptionsView.ShowFooter = true;
      this.viewData.OptionsView.ShowGroupPanel = false;
      this.viewData.RowHeight = 30;
      this.viewData.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.ViewDataInitNewRow);
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
      // colQuantity
      // 
      this.colQuantity.Caption = "Anzahl";
      this.colQuantity.FieldName = "Quantity";
      this.colQuantity.Name = "colQuantity";
      this.colQuantity.Visible = true;
      this.colQuantity.VisibleIndex = 1;
      // 
      // colFkDataDataPosition
      // 
      this.colFkDataDataPosition.FieldName = "FkDataDataPosition";
      this.colFkDataDataPosition.Name = "colFkDataDataPosition";
      this.colFkDataDataPosition.OptionsColumn.AllowEdit = false;
      this.colFkDataDataPosition.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colDescription
      // 
      this.colDescription.Caption = "Beschreibung";
      this.colDescription.FieldName = "Description";
      this.colDescription.Name = "colDescription";
      this.colDescription.Visible = true;
      this.colDescription.VisibleIndex = 0;
      // 
      // colPricePerQuantity
      // 
      this.colPricePerQuantity.Caption = "Preis per Stk";
      this.colPricePerQuantity.DisplayFormat.FormatString = "c";
      this.colPricePerQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colPricePerQuantity.FieldName = "PricePerQuantity";
      this.colPricePerQuantity.Name = "colPricePerQuantity";
      this.colPricePerQuantity.Visible = true;
      this.colPricePerQuantity.VisibleIndex = 2;
      // 
      // colPriceTotal
      // 
      this.colPriceTotal.Caption = "Total";
      this.colPriceTotal.DisplayFormat.FormatString = "c";
      this.colPriceTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colPriceTotal.FieldName = "PositionTotal";
      this.colPriceTotal.Name = "colPriceTotal";
      this.colPriceTotal.OptionsColumn.AllowEdit = false;
      this.colPriceTotal.OptionsColumn.ShowInCustomizationForm = false;
      this.colPriceTotal.SummaryItem.DisplayFormat = "{0:c}";
      this.colPriceTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
      this.colPriceTotal.Visible = true;
      this.colPriceTotal.VisibleIndex = 3;
      // 
      // DataControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridData);
      this.Controls.Add(this.groupBox1);
      this.Name = "DataControl";
      this.Size = new System.Drawing.Size(879, 408);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.remarkEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataPositionBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewData)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.MemoEdit remarkEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridData;
        private DevExpress.XtraGrid.Views.Grid.GridView viewData;
        private System.Windows.Forms.BindingSource dataPositionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
        private DevExpress.XtraGrid.Columns.GridColumn colTable;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colFkDataDataPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePerQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceTotal;
    }
}
