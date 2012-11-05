using Impressio.Models;

namespace Impressio.Controls
{
    partial class Finish
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
      this.gridFinish = new DevExpress.XtraGrid.GridControl();
      this.finishPositionBindingSource = new System.Windows.Forms.BindingSource();
      this.viewFinish = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTable = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFkFinishFinishPosition = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPricePerQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPriceTotal = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colIsPredefined = new DevExpress.XtraGrid.Columns.GridColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.remarkEdit = new DevExpress.XtraEditors.MemoEdit();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.nameEdit = new DevExpress.XtraEditors.TextEdit();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridFinish)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.finishPositionBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewFinish)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.remarkEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameEdit.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // gridFinish
      // 
      this.gridFinish.DataSource = this.finishPositionBindingSource;
      this.gridFinish.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridFinish.Location = new System.Drawing.Point(0, 134);
      this.gridFinish.MainView = this.viewFinish;
      this.gridFinish.Name = "gridFinish";
      this.gridFinish.Size = new System.Drawing.Size(929, 146);
      this.gridFinish.TabIndex = 0;
      this.gridFinish.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewFinish});
      // 
      // finishPositionBindingSource
      // 
      this.finishPositionBindingSource.DataSource = typeof(Impressio.Models.FinishPosition);
      // 
      // viewFinish
      // 
      this.viewFinish.ColumnPanelRowHeight = 30;
      this.viewFinish.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colTable,
            this.colFkFinishFinishPosition,
            this.colDescription,
            this.colQuantity,
            this.colPricePerQuantity,
            this.colPriceTotal,
            this.colIsPredefined});
      this.viewFinish.GridControl = this.gridFinish;
      this.viewFinish.IndicatorWidth = 50;
      this.viewFinish.Name = "viewFinish";
      this.viewFinish.OptionsDetail.EnableMasterViewMode = false;
      this.viewFinish.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.viewFinish.OptionsView.ShowGroupPanel = false;
      this.viewFinish.RowHeight = 30;
      this.viewFinish.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.ViewFinishInitNewRow);
      this.viewFinish.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.ViewFinishCellValueChanged);
      this.viewFinish.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.ViewFinishInvalidRowException);
      this.viewFinish.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.ViewFinishValidateRow);
      this.viewFinish.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.ViewFinishRowUpdated);
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
      // colFkFinishFinishPosition
      // 
      this.colFkFinishFinishPosition.FieldName = "FkFinishFinishPosition";
      this.colFkFinishFinishPosition.Name = "colFkFinishFinishPosition";
      // 
      // colDescription
      // 
      this.colDescription.Caption = "Beschreibung";
      this.colDescription.FieldName = "Description";
      this.colDescription.Name = "colDescription";
      this.colDescription.Visible = true;
      this.colDescription.VisibleIndex = 0;
      // 
      // colQuantity
      // 
      this.colQuantity.Caption = "Anzahl";
      this.colQuantity.FieldName = "Quantity";
      this.colQuantity.Name = "colQuantity";
      this.colQuantity.Visible = true;
      this.colQuantity.VisibleIndex = 1;
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
      this.colPriceTotal.Visible = true;
      this.colPriceTotal.VisibleIndex = 3;
      // 
      // colIsPredefined
      // 
      this.colIsPredefined.FieldName = "IsPredefined";
      this.colIsPredefined.Name = "colIsPredefined";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.remarkEdit);
      this.groupBox1.Controls.Add(this.labelControl2);
      this.groupBox1.Controls.Add(this.nameEdit);
      this.groupBox1.Controls.Add(this.labelControl1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(929, 134);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Weiterverarbeitung";
      // 
      // remarkEdit
      // 
      this.remarkEdit.Location = new System.Drawing.Point(86, 71);
      this.remarkEdit.Name = "remarkEdit";
      this.remarkEdit.Size = new System.Drawing.Size(256, 44);
      this.remarkEdit.TabIndex = 4;
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(22, 74);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(53, 13);
      this.labelControl2.TabIndex = 2;
      this.labelControl2.Text = "Bemerkung";
      // 
      // nameEdit
      // 
      this.nameEdit.Location = new System.Drawing.Point(86, 32);
      this.nameEdit.Name = "nameEdit";
      this.nameEdit.Size = new System.Drawing.Size(256, 20);
      this.nameEdit.TabIndex = 1;
      this.nameEdit.Validating += new System.ComponentModel.CancelEventHandler(this.NameEditValidating);
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(22, 35);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(27, 13);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Name";
      // 
      // Finish
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridFinish);
      this.Controls.Add(this.groupBox1);
      this.Name = "Finish";
      this.Size = new System.Drawing.Size(929, 280);
      this.Load += new System.EventHandler(this.FinishControlLoad);
      this.Validating += new System.ComponentModel.CancelEventHandler(this.FinishControlValidating);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridFinish)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.finishPositionBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewFinish)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.remarkEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameEdit.Properties)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridFinish;
        private DevExpress.XtraGrid.Views.Grid.GridView viewFinish;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit nameEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource finishPositionBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit remarkEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
        private DevExpress.XtraGrid.Columns.GridColumn colTable;
        private DevExpress.XtraGrid.Columns.GridColumn colFkFinishFinishPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePerQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPredefined;
    }
}
