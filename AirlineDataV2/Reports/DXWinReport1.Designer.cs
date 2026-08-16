namespace AirlineDataV2.Reports;

partial class DXWinReport1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if(disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DXWinReport1));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.kuyrukNoLbl = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 72.91666F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrLabel7,
            this.xrLine1,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel2,
            this.kuyrukNoLbl,
            this.xrLabel1});
            this.detailBand1.HeightF = 237.5F;
            this.detailBand1.Name = "detailBand1";
            // 
            // xrLabel8
            // 
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GorevTanimi]")});
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(10.00016F, 119.75F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(369.0594F, 23.00001F);
            this.xrLabel8.Text = "xrLabel8";
            // 
            // xrLabel7
            // 
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ArızaTalepSebebi]")});
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(10.00016F, 83.29166F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(369.0594F, 23F);
            this.xrLabel7.Text = "xrLabel7";
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(10.00016F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(629.9998F, 2F);
            // 
            // xrLabel6
            // 
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 46.83332F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(137.1058F, 23F);
            this.xrLabel6.Text = "ATA Kategori Kodu:";
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AtaKategoriKodu]")});
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(148.8513F, 46.83335F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(230.2083F, 23F);
            this.xrLabel5.Text = "xrLabel5";
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Model]")});
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Calibri", 11F, DevExpress.Drawing.DXFontStyle.Italic);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(403.125F, 10.00001F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(236.875F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "xrLabel2";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // kuyrukNoLbl
            // 
            this.kuyrukNoLbl.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KuyrukNo]")});
            this.kuyrukNoLbl.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.kuyrukNoLbl.LocationFloat = new DevExpress.Utils.PointFloat(148.8513F, 10.00001F);
            this.kuyrukNoLbl.Multiline = true;
            this.kuyrukNoLbl.Name = "kuyrukNoLbl";
            this.kuyrukNoLbl.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.kuyrukNoLbl.SizeF = new System.Drawing.SizeF(230.2083F, 23F);
            this.kuyrukNoLbl.StylePriority.UseFont = false;
            this.kuyrukNoLbl.Text = "kuyrukNoLbl";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9.75F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 9.999974F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(137.1059F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Kuyruk Numarası:";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataSource = typeof(global::AirlineDataV2.Reports.Models.UcakBakimDto);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.DetailReport1});
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9});
            this.Detail.HeightF = 100F;
            this.Detail.Name = "Detail";
            // 
            // xrLabel9
            // 
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UygulananIslem]")});
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(10.00023F, 10.00001F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(629.9998F, 90.00001F);
            this.xrLabel9.Text = "xrLabel9";
            // 
            // DetailReport1
            // 
            this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport1.DataMember = "BakimPersoneller";
            this.DetailReport1.Level = 0;
            this.DetailReport1.Name = "DetailReport1";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail1.Name = "Detail1";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(9.999971F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(137.1059F, 25F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "[Personel.AdSoyad]";
            this.xrTableCell1.Weight = 1.3710585021972657D;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrPictureBox1,
            this.xrLabel3});
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BakimTarihi]")});
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(10.00002F, 67F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel4.Text = "xrLabel4";
            this.xrLabel4.TextFormatString = "{0:dd/MMM/yyyy}";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(349.865F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(300.1351F, 100F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 16F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(9.999971F, 30.48649F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(169.2567F, 36.51351F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "Bakım Raporu";
            // 
            // DXWinReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1,
            this.DetailReport,
            this.PageHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.DataSource = this.objectDataSource1;
            this.Margins = new DevExpress.Drawing.DXMargins(100F, 100F, 72.91666F, 100F);
            this.Version = "26.1";
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
    private DevExpress.XtraReports.UI.DetailBand detailBand1;
    private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
    private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
    private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    private DevExpress.XtraReports.UI.XRLabel kuyrukNoLbl;
    private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
    private DevExpress.XtraReports.UI.XRLabel xrLabel3;
    private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
    private DevExpress.XtraReports.UI.XRLabel xrLabel4;
    private DevExpress.XtraReports.UI.DetailReportBand DetailReport1;
    private DevExpress.XtraReports.UI.DetailBand Detail1;
    private DevExpress.XtraReports.UI.XRTable xrTable1;
    private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
    private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    private DevExpress.XtraReports.UI.XRLabel xrLabel6;
    private DevExpress.XtraReports.UI.XRLabel xrLabel5;
    private DevExpress.XtraReports.UI.XRLine xrLine1;
    private DevExpress.XtraReports.UI.XRLabel xrLabel8;
    private DevExpress.XtraReports.UI.XRLabel xrLabel7;
    private DevExpress.XtraReports.UI.XRLabel xrLabel9;
}