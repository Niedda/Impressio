namespace Impressio.Controls
{
  partial class MachineControl
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
      this.gridMachine = new DevExpress.XtraGrid.GridControl();
      this.machineBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.viewMachine = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTable = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPlateCost = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPricePerColor = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colSpeed = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCostPerHour = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridMachine)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.machineBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewMachine)).BeginInit();
      this.SuspendLayout();
      // 
      // gridMachine
      // 
      this.gridMachine.DataSource = this.machineBindingSource;
      this.gridMachine.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridMachine.Location = new System.Drawing.Point(0, 0);
      this.gridMachine.MainView = this.viewMachine;
      this.gridMachine.Name = "gridMachine";
      this.gridMachine.Size = new System.Drawing.Size(747, 355);
      this.gridMachine.TabIndex = 0;
      this.gridMachine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewMachine});
      // 
      // machineBindingSource
      // 
      this.machineBindingSource.DataSource = typeof(Impressio.Models.Machine);
      // 
      // viewMachine
      // 
      this.viewMachine.ColumnPanelRowHeight = 30;
      this.viewMachine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colTable,
            this.colName,
            this.colPlateCost,
            this.colPricePerColor,
            this.colSpeed,
            this.colCostPerHour});
      this.viewMachine.GridControl = this.gridMachine;
      this.viewMachine.IndicatorWidth = 30;
      this.viewMachine.Name = "viewMachine";
      this.viewMachine.OptionsDetail.AllowZoomDetail = false;
      this.viewMachine.OptionsDetail.EnableMasterViewMode = false;
      this.viewMachine.OptionsDetail.ShowDetailTabs = false;
      this.viewMachine.OptionsDetail.SmartDetailExpand = false;
      this.viewMachine.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.viewMachine.OptionsView.ShowGroupPanel = false;
      this.viewMachine.RowHeight = 30;
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
      // colPlateCost
      // 
      this.colPlateCost.Caption = "Plattenkosten";
      this.colPlateCost.DisplayFormat.FormatString = "c";
      this.colPlateCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colPlateCost.FieldName = "PlateCost";
      this.colPlateCost.Name = "colPlateCost";
      this.colPlateCost.Visible = true;
      this.colPlateCost.VisibleIndex = 4;
      // 
      // colPricePerColor
      // 
      this.colPricePerColor.Caption = "Preis per Farbe einrichten";
      this.colPricePerColor.DisplayFormat.FormatString = "c";
      this.colPricePerColor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colPricePerColor.FieldName = "PricePerColor";
      this.colPricePerColor.Name = "colPricePerColor";
      this.colPricePerColor.Visible = true;
      this.colPricePerColor.VisibleIndex = 1;
      // 
      // colSpeed
      // 
      this.colSpeed.Caption = "Geschwindigkeit";
      this.colSpeed.DisplayFormat.FormatString = "N0";
      this.colSpeed.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colSpeed.FieldName = "Speed";
      this.colSpeed.Name = "colSpeed";
      this.colSpeed.Visible = true;
      this.colSpeed.VisibleIndex = 2;
      // 
      // colCostPerHour
      // 
      this.colCostPerHour.Caption = "Stundensatz";
      this.colCostPerHour.DisplayFormat.FormatString = "c";
      this.colCostPerHour.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colCostPerHour.FieldName = "PricePerHour";
      this.colCostPerHour.Name = "colCostPerHour";
      this.colCostPerHour.Visible = true;
      this.colCostPerHour.VisibleIndex = 3;
      // 
      // MachineControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridMachine);
      this.Name = "MachineControl";
      this.Size = new System.Drawing.Size(747, 355);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridMachine)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.machineBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewMachine)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridMachine;
    private System.Windows.Forms.BindingSource machineBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
    private DevExpress.XtraGrid.Columns.GridColumn colTable;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colPlateCost;
    private DevExpress.XtraGrid.Columns.GridColumn colPricePerColor;
    private DevExpress.XtraGrid.Columns.GridColumn colSpeed;
    private DevExpress.XtraGrid.Columns.GridColumn colCostPerHour;
    public DevExpress.XtraGrid.Views.Grid.GridView viewMachine;
  }
}
