using Impressio.Models;

namespace Impressio.Reports
{
  partial class DeliveryReport
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

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.Detail = new DevExpress.XtraReports.UI.DetailBand();
      this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
      this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
      this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
      this.logoBox = new DevExpress.XtraReports.UI.XRPictureBox();
      this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
      this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
      this.orderNameLabel = new DevExpress.XtraReports.UI.XRLabel();
      this.orderNumberLabel = new DevExpress.XtraReports.UI.XRLabel();
      this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
      this.footerLabel = new DevExpress.XtraReports.UI.XRLabel();
      this.greetsLabel = new DevExpress.XtraReports.UI.XRLabel();
      this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
      this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
      this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
      this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      // 
      // Detail
      // 
      this.Detail.HeightF = 4.166667F;
      this.Detail.Name = "Detail";
      this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // TopMargin
      // 
      this.TopMargin.Name = "TopMargin";
      this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // BottomMargin
      // 
      this.BottomMargin.Name = "BottomMargin";
      this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // ReportHeader
      // 
      this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.logoBox,
            this.xrPageInfo1,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.orderNameLabel,
            this.orderNumberLabel});
      this.ReportHeader.HeightF = 434.7917F;
      this.ReportHeader.Name = "ReportHeader";
      // 
      // logoBox
      // 
      this.logoBox.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top;
      this.logoBox.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
      this.logoBox.Name = "logoBox";
      this.logoBox.SizeF = new System.Drawing.SizeF(250F, 100F);
      this.logoBox.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
      // 
      // xrPageInfo1
      // 
      this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 10F);
      this.xrPageInfo1.Format = "{0:dddd, d MMMM, yyyy}";
      this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(412.5F, 335.3752F);
      this.xrPageInfo1.Name = "xrPageInfo1";
      this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.xrPageInfo1.SizeF = new System.Drawing.SizeF(237.5F, 23.00003F);
      this.xrPageInfo1.StylePriority.UseFont = false;
      this.xrPageInfo1.StylePriority.UseTextAlignment = false;
      this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // xrLabel8
      // 
      this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 10F);
      this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(412.5F, 170.1016F);
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel8.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
      this.xrLabel8.SizeF = new System.Drawing.SizeF(237.5F, 23.00001F);
      this.xrLabel8.StylePriority.UseFont = false;
      this.xrLabel8.StylePriority.UseTextAlignment = false;
      this.xrLabel8.Text = "[Address.Addition]";
      this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // xrLabel7
      // 
      this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 10F);
      this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(412.5F, 216.875F);
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel7.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
      this.xrLabel7.SizeF = new System.Drawing.SizeF(237.5F, 23.00001F);
      this.xrLabel7.StylePriority.UseFont = false;
      this.xrLabel7.StylePriority.UseTextAlignment = false;
      this.xrLabel7.Text = "[Address.ZipCode][Address.City]";
      this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // xrLabel4
      // 
      this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 10F);
      this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(412.5F, 193.4883F);
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel4.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
      this.xrLabel4.SizeF = new System.Drawing.SizeF(237.5F, 23F);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "[Address.Street] [Address.StreetNumber]";
      this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // xrLabel3
      // 
      this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Company.Addition")});
      this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 10F);
      this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(412.5F, 123.3283F);
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel3.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
      this.xrLabel3.SizeF = new System.Drawing.SizeF(237.5F, 23F);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "xrLabel3";
      this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // xrLabel2
      // 
      this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Company.CompanyName")});
      this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 10F);
      this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(412.5F, 99.94167F);
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel2.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
      this.xrLabel2.SizeF = new System.Drawing.SizeF(237.5F, 23F);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "xrLabel2";
      this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // xrLabel1
      // 
      this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Client.FullName")});
      this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 10F);
      this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(412.5F, 146.715F);
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel1.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
      this.xrLabel1.SizeF = new System.Drawing.SizeF(237.5F, 23F);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      this.xrLabel1.Text = "xrLabel1";
      this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // orderNameLabel
      // 
      this.orderNameLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.orderNameLabel.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 398.6666F);
      this.orderNameLabel.Name = "orderNameLabel";
      this.orderNameLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.orderNameLabel.SizeF = new System.Drawing.SizeF(452.0834F, 23F);
      this.orderNameLabel.StylePriority.UseFont = false;
      this.orderNameLabel.StylePriority.UseTextAlignment = false;
      this.orderNameLabel.Text = "[Order.OrderName]";
      this.orderNameLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // orderNumberLabel
      // 
      this.orderNumberLabel.Font = new System.Drawing.Font("Tahoma", 10F);
      this.orderNumberLabel.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 335.3752F);
      this.orderNumberLabel.Name = "orderNumberLabel";
      this.orderNumberLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.orderNumberLabel.SizeF = new System.Drawing.SizeF(387.5F, 23F);
      this.orderNumberLabel.StylePriority.UseFont = false;
      this.orderNumberLabel.StylePriority.UseTextAlignment = false;
      this.orderNumberLabel.Text = "Lieferung für Auftrag-Nummer: [Order.Identity]";
      this.orderNumberLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // ReportFooter
      // 
      this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.footerLabel,
            this.greetsLabel});
      this.ReportFooter.HeightF = 169.7917F;
      this.ReportFooter.Name = "ReportFooter";
      // 
      // footerLabel
      // 
      this.footerLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Order.UserModified")});
      this.footerLabel.Font = new System.Drawing.Font("Tahoma", 10F);
      this.footerLabel.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 136.7917F);
      this.footerLabel.Name = "footerLabel";
      this.footerLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.footerLabel.SizeF = new System.Drawing.SizeF(260.4167F, 22.99999F);
      this.footerLabel.StylePriority.UseFont = false;
      // 
      // greetsLabel
      // 
      this.greetsLabel.Font = new System.Drawing.Font("Tahoma", 10F);
      this.greetsLabel.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 69.37501F);
      this.greetsLabel.Name = "greetsLabel";
      this.greetsLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.greetsLabel.SizeF = new System.Drawing.SizeF(366.6667F, 20.62502F);
      this.greetsLabel.StylePriority.UseFont = false;
      this.greetsLabel.Text = "Mit freundlichen Grüssen";
      // 
      // DetailReport
      // 
      this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
      this.DetailReport.DataMember = "DeliveryPositions";
      this.DetailReport.DataSource = this.deliveryBindingSource;
      this.DetailReport.Level = 0;
      this.DetailReport.Name = "DetailReport";
      // 
      // Detail1
      // 
      this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.xrLabel5});
      this.Detail1.HeightF = 45.83333F;
      this.Detail1.Name = "Detail1";
      // 
      // xrLabel6
      // 
      this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "DeliveryPositions.Quantity")});
      this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 10F);
      this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(550F, 10.00001F);
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel6.SizeF = new System.Drawing.SizeF(100F, 23F);
      this.xrLabel6.StylePriority.UseFont = false;
      this.xrLabel6.Text = "xrLabel6";
      // 
      // xrLabel5
      // 
      this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "DeliveryPositions.Position")});
      this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 10F);
      this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(141.6667F, 10.00001F);
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel5.SizeF = new System.Drawing.SizeF(245.8333F, 23F);
      this.xrLabel5.StylePriority.UseFont = false;
      this.xrLabel5.Text = "xrLabel5";
      // 
      // deliveryBindingSource
      // 
      this.deliveryBindingSource.DataSource = typeof(Impressio.Models.Delivery);
      // 
      // DeliveryReport
      // 
      this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.ReportFooter,
            this.DetailReport});
      this.DataSource = this.deliveryBindingSource;
      this.Version = "10.2";
      ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
    private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
    private DevExpress.XtraReports.UI.XRLabel greetsLabel;
    private DevExpress.XtraReports.UI.XRLabel footerLabel;
    private DevExpress.XtraReports.UI.XRLabel orderNameLabel;
    private DevExpress.XtraReports.UI.XRLabel orderNumberLabel;
    private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
    private DevExpress.XtraReports.UI.XRLabel xrLabel8;
    private DevExpress.XtraReports.UI.XRLabel xrLabel7;
    private DevExpress.XtraReports.UI.XRLabel xrLabel4;
    private DevExpress.XtraReports.UI.XRLabel xrLabel3;
    private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    public System.Windows.Forms.BindingSource deliveryBindingSource;
    private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
    private DevExpress.XtraReports.UI.DetailBand Detail1;
    private DevExpress.XtraReports.UI.XRLabel xrLabel6;
    private DevExpress.XtraReports.UI.XRLabel xrLabel5;
    public DevExpress.XtraReports.UI.XRPictureBox logoBox;
  }
}
