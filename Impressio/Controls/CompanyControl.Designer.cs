namespace Impressio.Controls
{
    partial class CompanyControl
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
      this.gridCompany = new DevExpress.XtraGrid.GridControl();
      this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.viewCompany = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAddition = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
      this.Address = new DevExpress.XtraGrid.Views.Grid.GridView();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridCompany)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewCompany)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Address)).BeginInit();
      this.SuspendLayout();
      // 
      // gridCompany
      // 
      this.gridCompany.DataSource = this.companiesBindingSource;
      this.gridCompany.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridCompany.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.gridCompany.Location = new System.Drawing.Point(0, 0);
      this.gridCompany.MainView = this.viewCompany;
      this.gridCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.gridCompany.Name = "gridCompany";
      this.gridCompany.ShowOnlyPredefinedDetails = true;
      this.gridCompany.Size = new System.Drawing.Size(879, 398);
      this.gridCompany.TabIndex = 0;
      this.gridCompany.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewCompany,
            this.Address});
      // 
      // viewCompany
      // 
      this.viewCompany.ColumnPanelRowHeight = 30;
      this.viewCompany.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colCompanyName,
            this.colAddition,
            this.colRemark});
      this.viewCompany.GridControl = this.gridCompany;
      this.viewCompany.IndicatorWidth = 50;
      this.viewCompany.Name = "viewCompany";
      this.viewCompany.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
      this.viewCompany.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
      this.viewCompany.OptionsCustomization.AllowColumnMoving = false;
      this.viewCompany.OptionsCustomization.AllowGroup = false;
      this.viewCompany.OptionsDetail.EnableMasterViewMode = false;
      this.viewCompany.OptionsFind.AlwaysVisible = true;
      this.viewCompany.OptionsFind.ShowCloseButton = false;
      this.viewCompany.OptionsMenu.EnableColumnMenu = false;
      this.viewCompany.OptionsMenu.EnableFooterMenu = false;
      this.viewCompany.OptionsMenu.EnableGroupPanelMenu = false;
      this.viewCompany.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.viewCompany.OptionsView.ShowDetailButtons = false;
      this.viewCompany.OptionsView.ShowGroupPanel = false;
      this.viewCompany.RowHeight = 30;
      // 
      // colIdentity
      // 
      this.colIdentity.FieldName = "Identity";
      this.colIdentity.Name = "colIdentity";
      // 
      // colCompanyName
      // 
      this.colCompanyName.Caption = "Firma";
      this.colCompanyName.FieldName = "CompanyName";
      this.colCompanyName.Name = "colCompanyName";
      this.colCompanyName.Visible = true;
      this.colCompanyName.VisibleIndex = 0;
      // 
      // colAddition
      // 
      this.colAddition.Caption = "Zusatz";
      this.colAddition.FieldName = "Addition";
      this.colAddition.Name = "colAddition";
      this.colAddition.Visible = true;
      this.colAddition.VisibleIndex = 1;
      // 
      // colRemark
      // 
      this.colRemark.Caption = "Bemerkung";
      this.colRemark.FieldName = "Remark";
      this.colRemark.Name = "colRemark";
      this.colRemark.Visible = true;
      this.colRemark.VisibleIndex = 2;
      // 
      // Address
      // 
      this.Address.GridControl = this.gridCompany;
      this.Address.Name = "Address";
      // 
      // CompanyControl
      // 
      this.Appearance.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Appearance.Options.UseFont = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridCompany);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "CompanyControl";
      this.Size = new System.Drawing.Size(879, 398);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridCompany)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewCompany)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Address)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView Address;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddition;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        public DevExpress.XtraGrid.Views.Grid.GridView viewCompany;
    }
}
