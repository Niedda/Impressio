using Impressio.Models;

namespace Impressio.Reports
{
  partial class OfferReport
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
      this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
      this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
      this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
      this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
      this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
      this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
      this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
      this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
      this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
      this.orderBindingSourcew = new System.Windows.Forms.BindingSource(this.components);
      this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
      this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
      this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
      this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSourcew)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      // 
      // Detail
      // 
      this.Detail.HeightF = 10.41667F;
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
      this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
      this.BottomMargin.Name = "BottomMargin";
      this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // xrPageInfo1
      // 
      this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.xrPageInfo1.Format = "{0:d MMMM, yyyy}";
      this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(456.25F, 0F);
      this.xrPageInfo1.Name = "xrPageInfo1";
      this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.xrPageInfo1.SizeF = new System.Drawing.SizeF(193.7499F, 23F);
      this.xrPageInfo1.StylePriority.UseFont = false;
      this.xrPageInfo1.StylePriority.UseTextAlignment = false;
      this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
      // 
      // DetailReport
      // 
      this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.DetailReport1});
      this.DetailReport.DataMember = "Descriptions";
      this.DetailReport.DataSource = this.orderBindingSourcew;
      this.DetailReport.Level = 0;
      this.DetailReport.Name = "DetailReport";
      // 
      // Detail1
      // 
      this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9});
      this.Detail1.HeightF = 57.29168F;
      this.Detail1.KeepTogether = true;
      this.Detail1.Name = "Detail1";
      // 
      // xrLabel9
      // 
      this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Descriptions.JobTitle")});
      this.xrLabel9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 24.29167F);
      this.xrLabel9.Name = "xrLabel9";
      this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel9.SizeF = new System.Drawing.SizeF(278.5714F, 23F);
      this.xrLabel9.StylePriority.UseFont = false;
      this.xrLabel9.Text = "xrLabel9";
      // 
      // DetailReport1
      // 
      this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail2,
            this.GroupFooter1});
      this.DetailReport1.DataMember = "Descriptions.Details";
      this.DetailReport1.DataSource = this.orderBindingSourcew;
      this.DetailReport1.Level = 0;
      this.DetailReport1.Name = "DetailReport1";
      // 
      // Detail2
      // 
      this.Detail2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel12,
            this.xrLabel11});
      this.Detail2.HeightF = 41.66667F;
      this.Detail2.KeepTogether = true;
      this.Detail2.Name = "Detail2";
      // 
      // xrLabel12
      // 
      this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Descriptions.Details.DetailContent")});
      this.xrLabel12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(199.6366F, 10.00001F);
      this.xrLabel12.Multiline = true;
      this.xrLabel12.Name = "xrLabel12";
      this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel12.SizeF = new System.Drawing.SizeF(450.3633F, 23F);
      this.xrLabel12.StylePriority.UseFont = false;
      this.xrLabel12.Text = "xrLabel12";
      // 
      // xrLabel11
      // 
      this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Descriptions.Details.DetailTitle")});
      this.xrLabel11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
      this.xrLabel11.Name = "xrLabel11";
      this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel11.SizeF = new System.Drawing.SizeF(151.405F, 23F);
      this.xrLabel11.StylePriority.UseFont = false;
      this.xrLabel11.Text = "xrLabel11";
      // 
      // GroupFooter1
      // 
      this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10});
      this.GroupFooter1.HeightF = 84.73837F;
      this.GroupFooter1.KeepTogether = true;
      this.GroupFooter1.Name = "GroupFooter1";
      // 
      // xrLabel10
      // 
      this.xrLabel10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(456.25F, 21.02133F);
      this.xrLabel10.Name = "xrLabel10";
      this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel10.SizeF = new System.Drawing.SizeF(193.75F, 23F);
      this.xrLabel10.StylePriority.UseFont = false;
      this.xrLabel10.StylePriority.UseTextAlignment = false;
      this.xrLabel10.Text = "[Descriptions.Price!c]";
      this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
      // 
      // orderBindingSourcew
      // 
      this.orderBindingSourcew.DataSource = typeof(Impressio.Models.Order);
      // 
      // ReportHeader
      // 
      this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
      this.ReportHeader.HeightF = 385.4167F;
      this.ReportHeader.Name = "ReportHeader";
      // 
      // xrLabel8
      // 
      this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 335.75F);
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel8.SizeF = new System.Drawing.SizeF(640F, 23F);
      this.xrLabel8.StylePriority.UseFont = false;
      this.xrLabel8.Text = "Ihre Offerte für den Auftrag [OrderName]";
      // 
      // xrLabel7
      // 
      this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Client.Mail")});
      this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(400F, 261.2083F);
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel7.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
      this.xrLabel7.SizeF = new System.Drawing.SizeF(250F, 20F);
      this.xrLabel7.StylePriority.UseFont = false;
      this.xrLabel7.StylePriority.UseTextAlignment = false;
      this.xrLabel7.Text = "xrLabel7";
      this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // xrLabel6
      // 
      this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(399.9999F, 182.875F);
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel6.SizeF = new System.Drawing.SizeF(250F, 20F);
      this.xrLabel6.StylePriority.UseFont = false;
      this.xrLabel6.StylePriority.UseTextAlignment = false;
      this.xrLabel6.Text = "[Address.ZipCode] [Address.City]";
      this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // xrLabel5
      // 
      this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(399.9999F, 162.875F);
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel5.SizeF = new System.Drawing.SizeF(250F, 20F);
      this.xrLabel5.StylePriority.UseFont = false;
      this.xrLabel5.StylePriority.UseTextAlignment = false;
      this.xrLabel5.Text = "[Address.Street] [Address.StreetNumber]";
      this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // xrLabel4
      // 
      this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Client.Mobile")});
      this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(399.9999F, 241.2083F);
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel4.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
      this.xrLabel4.SizeF = new System.Drawing.SizeF(250F, 20F);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "xrLabel4";
      this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // xrLabel3
      // 
      this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Client.Phone")});
      this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(399.9999F, 221.2083F);
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel3.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
      this.xrLabel3.SizeF = new System.Drawing.SizeF(250F, 20F);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "xrLabel3";
      this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // xrLabel2
      // 
      this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Client.FullName")});
      this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(400F, 142.875F);
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel2.SizeF = new System.Drawing.SizeF(250F, 20F);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "xrLabel2";
      this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // xrLabel1
      // 
      this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Company.CompanyName")});
      this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(400F, 122.875F);
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel1.SizeF = new System.Drawing.SizeF(250F, 20F);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      this.xrLabel1.Text = "xrLabel1";
      this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // ReportFooter
      // 
      this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13});
      this.ReportFooter.Name = "ReportFooter";
      // 
      // xrLabel13
      // 
      this.xrLabel13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(0F, 9.999974F);
      this.xrLabel13.Multiline = true;
      this.xrLabel13.Name = "xrLabel13";
      this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel13.SizeF = new System.Drawing.SizeF(233.3333F, 67.79166F);
      this.xrLabel13.StylePriority.UseFont = false;
      this.xrLabel13.Text = "Mit freundlichen Grüssen\r\n\r\n\r\n[UserModified]";
      // 
      // OfferReport
      // 
      this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.DetailReport,
            this.ReportHeader,
            this.ReportFooter});
      this.DataSource = this.orderBindingSourcew;
      this.Version = "10.2";
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSourcew)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
    private DevExpress.XtraReports.UI.DetailBand Detail1;
    private DevExpress.XtraReports.UI.DetailReportBand DetailReport1;
    private DevExpress.XtraReports.UI.DetailBand Detail2;
    public System.Windows.Forms.BindingSource orderBindingSourcew;
    private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
    private DevExpress.XtraReports.UI.XRLabel xrLabel7;
    private DevExpress.XtraReports.UI.XRLabel xrLabel6;
    private DevExpress.XtraReports.UI.XRLabel xrLabel5;
    private DevExpress.XtraReports.UI.XRLabel xrLabel4;
    private DevExpress.XtraReports.UI.XRLabel xrLabel3;
    private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    private DevExpress.XtraReports.UI.XRLabel xrLabel8;
    private DevExpress.XtraReports.UI.XRLabel xrLabel9;
    private DevExpress.XtraReports.UI.XRLabel xrLabel12;
    private DevExpress.XtraReports.UI.XRLabel xrLabel11;
    private DevExpress.XtraReports.UI.XRLabel xrLabel10;
    private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
    private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
    private DevExpress.XtraReports.UI.XRLabel xrLabel13;
    private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
  }
}
