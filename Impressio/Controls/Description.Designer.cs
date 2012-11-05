using Impressio.Models;

namespace Impressio.Controls
{
  partial class Description
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
      this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
      this.gridDescription = new DevExpress.XtraGrid.GridControl();
      this.descriptionBindingSource = new System.Windows.Forms.BindingSource();
      this.viewDescription = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colJobTitel = new DevExpress.XtraGrid.Columns.GridColumn();
      this.predefinedDescriptionCombo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
      this.colFkDescriptionOrder = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colArrange = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colMoveUp = new DevExpress.XtraGrid.Columns.GridColumn();
      this.descriptionMoveUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
      this.colMoveDown = new DevExpress.XtraGrid.Columns.GridColumn();
      this.descriptionMoveDownEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
      this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPredefinedDescription = new DevExpress.XtraGrid.Columns.GridColumn();
      this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
      this.gridDetail = new DevExpress.XtraGrid.GridControl();
      this.detailsBindingSource = new System.Windows.Forms.BindingSource();
      this.viewDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentityDetail = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFkDetailDescription = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDetailContent = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colArrangeDetail = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDetailTitle = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.detailMoveUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
      this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.detailMoveDownEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
      this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
      this.groupControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridDescription)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.descriptionBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewDescription)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.predefinedDescriptionCombo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.descriptionMoveUpEdit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.descriptionMoveDownEdit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
      this.groupControl2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewDetail)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.detailMoveUpEdit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.detailMoveDownEdit)).BeginInit();
      this.SuspendLayout();
      // 
      // groupControl1
      // 
      this.groupControl1.Controls.Add(this.gridDescription);
      this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupControl1.Location = new System.Drawing.Point(0, 0);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new System.Drawing.Size(1013, 166);
      this.groupControl1.TabIndex = 0;
      this.groupControl1.Text = "Positionen";
      // 
      // gridDescription
      // 
      this.gridDescription.DataSource = this.descriptionBindingSource;
      this.gridDescription.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridDescription.Location = new System.Drawing.Point(2, 22);
      this.gridDescription.MainView = this.viewDescription;
      this.gridDescription.Name = "gridDescription";
      this.gridDescription.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.predefinedDescriptionCombo,
            this.descriptionMoveUpEdit,
            this.descriptionMoveDownEdit});
      this.gridDescription.Size = new System.Drawing.Size(1009, 142);
      this.gridDescription.TabIndex = 0;
      this.gridDescription.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDescription});
      // 
      // descriptionBindingSource
      // 
      this.descriptionBindingSource.DataSource = typeof(Impressio.Models.Description);
      // 
      // viewDescription
      // 
      this.viewDescription.ColumnPanelRowHeight = 30;
      this.viewDescription.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colJobTitel,
            this.colFkDescriptionOrder,
            this.colArrange,
            this.colMoveUp,
            this.colMoveDown,
            this.colPrice,
            this.colPredefinedDescription});
      this.viewDescription.GridControl = this.gridDescription;
      this.viewDescription.IndicatorWidth = 50;
      this.viewDescription.Name = "viewDescription";
      this.viewDescription.OptionsCustomization.AllowColumnMoving = false;
      this.viewDescription.OptionsCustomization.AllowGroup = false;
      this.viewDescription.OptionsCustomization.AllowSort = false;
      this.viewDescription.OptionsDetail.AllowZoomDetail = false;
      this.viewDescription.OptionsDetail.EnableMasterViewMode = false;
      this.viewDescription.OptionsDetail.ShowDetailTabs = false;
      this.viewDescription.OptionsDetail.SmartDetailExpand = false;
      this.viewDescription.OptionsMenu.EnableColumnMenu = false;
      this.viewDescription.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.viewDescription.OptionsView.RowAutoHeight = true;
      this.viewDescription.OptionsView.ShowGroupPanel = false;
      this.viewDescription.RowHeight = 30;
      this.viewDescription.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colArrange, DevExpress.Data.ColumnSortOrder.Ascending)});
      this.viewDescription.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.ViewDescriptionInitNewRow);
      this.viewDescription.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ViewDescriptionFocusedRowChanged);
      this.viewDescription.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.ViewDescriptionCellValueChanging);
      this.viewDescription.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.ViewDescriptionInvalidRowException);
      this.viewDescription.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.ViewDescriptionValidateRow);
      // 
      // colIdentity
      // 
      this.colIdentity.FieldName = "Identity";
      this.colIdentity.Name = "colIdentity";
      this.colIdentity.OptionsColumn.AllowEdit = false;
      this.colIdentity.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colJobTitel
      // 
      this.colJobTitel.Caption = "Auftragstitel";
      this.colJobTitel.ColumnEdit = this.predefinedDescriptionCombo;
      this.colJobTitel.FieldName = "JobTitel";
      this.colJobTitel.Name = "colJobTitel";
      this.colJobTitel.Visible = true;
      this.colJobTitel.VisibleIndex = 0;
      this.colJobTitel.Width = 542;
      // 
      // predefinedDescriptionCombo
      // 
      this.predefinedDescriptionCombo.AutoHeight = false;
      this.predefinedDescriptionCombo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.predefinedDescriptionCombo.Name = "predefinedDescriptionCombo";
      // 
      // colFkDescriptionOrder
      // 
      this.colFkDescriptionOrder.FieldName = "FkDescriptionOrder";
      this.colFkDescriptionOrder.Name = "colFkDescriptionOrder";
      this.colFkDescriptionOrder.OptionsColumn.AllowEdit = false;
      this.colFkDescriptionOrder.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colArrange
      // 
      this.colArrange.Caption = "Reihenfolge";
      this.colArrange.FieldName = "Arrange";
      this.colArrange.Name = "colArrange";
      this.colArrange.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
      this.colArrange.Width = 80;
      // 
      // colMoveUp
      // 
      this.colMoveUp.ColumnEdit = this.descriptionMoveUpEdit;
      this.colMoveUp.Name = "colMoveUp";
      this.colMoveUp.Visible = true;
      this.colMoveUp.VisibleIndex = 2;
      this.colMoveUp.Width = 25;
      // 
      // descriptionMoveUpEdit
      // 
      this.descriptionMoveUpEdit.AutoHeight = false;
      this.descriptionMoveUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Up)});
      this.descriptionMoveUpEdit.Name = "descriptionMoveUpEdit";
      this.descriptionMoveUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
      this.descriptionMoveUpEdit.Click += new System.EventHandler(this.DescriptionMoveUpEditClick);
      // 
      // colMoveDown
      // 
      this.colMoveDown.ColumnEdit = this.descriptionMoveDownEdit;
      this.colMoveDown.Name = "colMoveDown";
      this.colMoveDown.Visible = true;
      this.colMoveDown.VisibleIndex = 3;
      this.colMoveDown.Width = 25;
      // 
      // descriptionMoveDownEdit
      // 
      this.descriptionMoveDownEdit.AutoHeight = false;
      this.descriptionMoveDownEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)});
      this.descriptionMoveDownEdit.Name = "descriptionMoveDownEdit";
      this.descriptionMoveDownEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
      this.descriptionMoveDownEdit.Click += new System.EventHandler(this.DescriptionMoveDownEditClick);
      // 
      // colPrice
      // 
      this.colPrice.Caption = "Preis";
      this.colPrice.DisplayFormat.FormatString = "c";
      this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colPrice.FieldName = "Price";
      this.colPrice.Name = "colPrice";
      this.colPrice.Visible = true;
      this.colPrice.VisibleIndex = 1;
      // 
      // colPredefinedDescription
      // 
      this.colPredefinedDescription.FieldName = "IsPredefined";
      this.colPredefinedDescription.Name = "colPredefinedDescription";
      // 
      // groupControl2
      // 
      this.groupControl2.Controls.Add(this.gridDetail);
      this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupControl2.Location = new System.Drawing.Point(0, 166);
      this.groupControl2.Name = "groupControl2";
      this.groupControl2.Size = new System.Drawing.Size(1013, 140);
      this.groupControl2.TabIndex = 1;
      this.groupControl2.Text = "Inhalt von Position";
      // 
      // gridDetail
      // 
      this.gridDetail.DataSource = this.detailsBindingSource;
      this.gridDetail.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridDetail.Location = new System.Drawing.Point(2, 22);
      this.gridDetail.MainView = this.viewDetail;
      this.gridDetail.Name = "gridDetail";
      this.gridDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.detailMoveUpEdit,
            this.detailMoveDownEdit});
      this.gridDetail.Size = new System.Drawing.Size(1009, 116);
      this.gridDetail.TabIndex = 0;
      this.gridDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDetail});
      // 
      // detailsBindingSource
      // 
      this.detailsBindingSource.DataSource = typeof(Impressio.Models.Detail);
      // 
      // viewDetail
      // 
      this.viewDetail.ColumnPanelRowHeight = 30;
      this.viewDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentityDetail,
            this.colFkDetailDescription,
            this.colDetailContent,
            this.colArrangeDetail,
            this.colDetailTitle,
            this.gridColumn3,
            this.gridColumn4});
      this.viewDetail.GridControl = this.gridDetail;
      this.viewDetail.IndicatorWidth = 50;
      this.viewDetail.Name = "viewDetail";
      this.viewDetail.OptionsCustomization.AllowColumnMoving = false;
      this.viewDetail.OptionsCustomization.AllowFilter = false;
      this.viewDetail.OptionsCustomization.AllowGroup = false;
      this.viewDetail.OptionsCustomization.AllowSort = false;
      this.viewDetail.OptionsDetail.EnableMasterViewMode = false;
      this.viewDetail.OptionsMenu.EnableColumnMenu = false;
      this.viewDetail.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.viewDetail.OptionsView.RowAutoHeight = true;
      this.viewDetail.OptionsView.ShowGroupPanel = false;
      this.viewDetail.RowHeight = 30;
      this.viewDetail.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colArrangeDetail, DevExpress.Data.ColumnSortOrder.Ascending)});
      this.viewDetail.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.ViewDetailInitNewRow);
      this.viewDetail.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.ViewDetailInvalidRowException);
      this.viewDetail.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.ViewDetailValidateRow);
      this.viewDetail.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.ViewDetailRowUpdated);
      // 
      // colIdentityDetail
      // 
      this.colIdentityDetail.FieldName = "Identity";
      this.colIdentityDetail.Name = "colIdentityDetail";
      this.colIdentityDetail.OptionsColumn.AllowEdit = false;
      this.colIdentityDetail.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colFkDetailDescription
      // 
      this.colFkDetailDescription.FieldName = "FkDetailDescription";
      this.colFkDetailDescription.Name = "colFkDetailDescription";
      this.colFkDetailDescription.OptionsColumn.AllowEdit = false;
      this.colFkDetailDescription.OptionsColumn.ShowInCustomizationForm = false;
      // 
      // colDetailContent
      // 
      this.colDetailContent.Caption = "Beschreibung";
      this.colDetailContent.FieldName = "DetailContent";
      this.colDetailContent.Name = "colDetailContent";
      this.colDetailContent.Visible = true;
      this.colDetailContent.VisibleIndex = 1;
      this.colDetailContent.Width = 294;
      // 
      // colArrangeDetail
      // 
      this.colArrangeDetail.Caption = "Reihenfolge";
      this.colArrangeDetail.FieldName = "Arrange";
      this.colArrangeDetail.Name = "colArrangeDetail";
      this.colArrangeDetail.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
      this.colArrangeDetail.Width = 80;
      // 
      // colDetailTitle
      // 
      this.colDetailTitle.Caption = "Abschnitt";
      this.colDetailTitle.FieldName = "DetailTitle";
      this.colDetailTitle.Name = "colDetailTitle";
      this.colDetailTitle.Visible = true;
      this.colDetailTitle.VisibleIndex = 0;
      this.colDetailTitle.Width = 294;
      // 
      // gridColumn3
      // 
      this.gridColumn3.ColumnEdit = this.detailMoveUpEdit;
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 2;
      // 
      // detailMoveUpEdit
      // 
      this.detailMoveUpEdit.AutoHeight = false;
      this.detailMoveUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Up)});
      this.detailMoveUpEdit.Name = "detailMoveUpEdit";
      this.detailMoveUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
      this.detailMoveUpEdit.Click += new System.EventHandler(this.DetailMoveUpEditClick);
      // 
      // gridColumn4
      // 
      this.gridColumn4.ColumnEdit = this.detailMoveDownEdit;
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Visible = true;
      this.gridColumn4.VisibleIndex = 3;
      // 
      // detailMoveDownEdit
      // 
      this.detailMoveDownEdit.AutoHeight = false;
      this.detailMoveDownEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)});
      this.detailMoveDownEdit.Name = "detailMoveDownEdit";
      this.detailMoveDownEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
      this.detailMoveDownEdit.Click += new System.EventHandler(this.DetailMoveDownEditClick);
      // 
      // splitterControl1
      // 
      this.splitterControl1.Cursor = System.Windows.Forms.Cursors.HSplit;
      this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
      this.splitterControl1.Location = new System.Drawing.Point(0, 166);
      this.splitterControl1.Name = "splitterControl1";
      this.splitterControl1.Size = new System.Drawing.Size(1013, 5);
      this.splitterControl1.TabIndex = 2;
      this.splitterControl1.TabStop = false;
      // 
      // Description
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitterControl1);
      this.Controls.Add(this.groupControl2);
      this.Controls.Add(this.groupControl1);
      this.MinimumSize = new System.Drawing.Size(450, 300);
      this.Name = "Description";
      this.Size = new System.Drawing.Size(1013, 306);
      this.Load += new System.EventHandler(this.DescriptionControlLoad);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
      this.groupControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridDescription)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.descriptionBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewDescription)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.predefinedDescriptionCombo)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.descriptionMoveUpEdit)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.descriptionMoveDownEdit)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
      this.groupControl2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewDetail)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.detailMoveUpEdit)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.detailMoveDownEdit)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.GroupControl groupControl1;
    private DevExpress.XtraEditors.GroupControl groupControl2;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
    private DevExpress.XtraGrid.Columns.GridColumn colJobTitel;
    private DevExpress.XtraGrid.Columns.GridColumn colFkDescriptionOrder;
    private System.Windows.Forms.BindingSource detailsBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colIdentityDetail;
    private DevExpress.XtraGrid.Columns.GridColumn colFkDetailDescription;
    private DevExpress.XtraGrid.Columns.GridColumn colDetailContent;
    private DevExpress.XtraGrid.Columns.GridColumn colArrangeDetail;
    private DevExpress.XtraGrid.Columns.GridColumn colDetailTitle;
    private DevExpress.XtraGrid.Columns.GridColumn colArrange;
    public System.Windows.Forms.BindingSource descriptionBindingSource;
    private DevExpress.XtraEditors.SplitterControl splitterControl1;
    private DevExpress.XtraEditors.Repository.RepositoryItemComboBox predefinedDescriptionCombo;
    public DevExpress.XtraGrid.GridControl gridDescription;
    public DevExpress.XtraGrid.GridControl gridDetail;
    public DevExpress.XtraGrid.Views.Grid.GridView viewDescription;
    public DevExpress.XtraGrid.Views.Grid.GridView viewDetail;
    private DevExpress.XtraGrid.Columns.GridColumn colMoveUp;
    private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit descriptionMoveUpEdit;
    private DevExpress.XtraGrid.Columns.GridColumn colMoveDown;
    private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit descriptionMoveDownEdit;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit detailMoveUpEdit;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit detailMoveDownEdit;
    private DevExpress.XtraGrid.Columns.GridColumn colPrice;
    private DevExpress.XtraGrid.Columns.GridColumn colPredefinedDescription;
  }
}
