using Impressio.Models;

namespace Impressio.Controls
{
    partial class AddressControl
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
      this.gridAddress = new DevExpress.XtraGrid.GridControl();
      this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.viewAddress = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIdentity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colFkAddressCompany = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colStreet = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colStreetNumber = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colZipCode = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAddition = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridAddress)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewAddress)).BeginInit();
      this.SuspendLayout();
      // 
      // gridAddress
      // 
      this.gridAddress.DataSource = this.addressBindingSource;
      this.gridAddress.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridAddress.Location = new System.Drawing.Point(0, 0);
      this.gridAddress.MainView = this.viewAddress;
      this.gridAddress.Name = "gridAddress";
      this.gridAddress.Size = new System.Drawing.Size(791, 345);
      this.gridAddress.TabIndex = 0;
      this.gridAddress.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewAddress});
      // 
      // addressBindingSource
      // 
      this.addressBindingSource.DataSource = typeof(Impressio.Models.Address);
      // 
      // viewAddress
      // 
      this.viewAddress.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.viewAddress.ColumnPanelRowHeight = 30;
      this.viewAddress.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdentity,
            this.colFkAddressCompany,
            this.colStreet,
            this.colStreetNumber,
            this.colCity,
            this.colZipCode,
            this.colAddition});
      this.viewAddress.GridControl = this.gridAddress;
      this.viewAddress.IndicatorWidth = 50;
      this.viewAddress.Name = "viewAddress";
      this.viewAddress.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
      this.viewAddress.OptionsCustomization.AllowQuickHideColumns = false;
      this.viewAddress.OptionsFind.AlwaysVisible = true;
      this.viewAddress.OptionsFind.ShowCloseButton = false;
      this.viewAddress.OptionsMenu.EnableColumnMenu = false;
      this.viewAddress.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.viewAddress.OptionsView.ShowDetailButtons = false;
      this.viewAddress.OptionsView.ShowGroupPanel = false;
      this.viewAddress.RowHeight = 30;
      this.viewAddress.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.ViewAddressInitNewRow);
      this.viewAddress.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.ViewAddressInvalidRowException);
      this.viewAddress.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.ViewAddressValidateRow);
      this.viewAddress.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.ViewAddressRowUpdated);
      // 
      // colIdentity
      // 
      this.colIdentity.FieldName = "Identity";
      this.colIdentity.Name = "colIdentity";
      // 
      // colFkAddressCompany
      // 
      this.colFkAddressCompany.FieldName = "FkAddressCompany";
      this.colFkAddressCompany.Name = "colFkAddressCompany";
      // 
      // colStreet
      // 
      this.colStreet.Caption = "Strasse";
      this.colStreet.FieldName = "Street";
      this.colStreet.Name = "colStreet";
      this.colStreet.Visible = true;
      this.colStreet.VisibleIndex = 0;
      // 
      // colStreetNumber
      // 
      this.colStreetNumber.Caption = "Str. Nummer";
      this.colStreetNumber.FieldName = "StreetNumber";
      this.colStreetNumber.Name = "colStreetNumber";
      this.colStreetNumber.Visible = true;
      this.colStreetNumber.VisibleIndex = 1;
      // 
      // colCity
      // 
      this.colCity.Caption = "Ortschaft";
      this.colCity.FieldName = "City";
      this.colCity.Name = "colCity";
      this.colCity.Visible = true;
      this.colCity.VisibleIndex = 3;
      // 
      // colZipCode
      // 
      this.colZipCode.Caption = "Postcode";
      this.colZipCode.FieldName = "ZipCode";
      this.colZipCode.Name = "colZipCode";
      this.colZipCode.Visible = true;
      this.colZipCode.VisibleIndex = 2;
      // 
      // colAddition
      // 
      this.colAddition.Caption = "Zusatz";
      this.colAddition.FieldName = "Addition";
      this.colAddition.Name = "colAddition";
      this.colAddition.Visible = true;
      this.colAddition.VisibleIndex = 4;
      // 
      // AddressControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridAddress);
      this.Name = "AddressControl";
      this.Size = new System.Drawing.Size(791, 345);
      this.Load += new System.EventHandler(this.AddressControlLoad);
      this.Validating += new System.ComponentModel.CancelEventHandler(this.AddressControlValidating);
      ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridAddress)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewAddress)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridAddress;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentity;
        private DevExpress.XtraGrid.Columns.GridColumn colFkAddressCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colStreet;
        private DevExpress.XtraGrid.Columns.GridColumn colStreetNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colZipCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAddition;
        public DevExpress.XtraGrid.Views.Grid.GridView viewAddress;
    }
}
