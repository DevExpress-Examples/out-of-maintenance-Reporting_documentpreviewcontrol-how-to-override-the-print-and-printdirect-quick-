Imports System
Imports DevExpress.XtraReports.UI

Namespace MinimalisticReportPreviewDemo

    Public Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private nwindDataSet1 As nwindDataSet

        Private productsTableAdapter As nwindDataSetTableAdapters.ProductsTableAdapter

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            Detail = New DevExpress.XtraReports.UI.DetailBand()
            xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            nwindDataSet1 = New nwindDataSet()
            productsTableAdapter = New nwindDataSetTableAdapters.ProductsTableAdapter()
            ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            CType(nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {xrLabel1})
            Detail.HeightF = 33.00001F
            Detail.Name = "Detail"
            Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel1
            ' 
            xrLabel1.BookmarkParent = xrLabel2
            xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName"), New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Products.ProductName")})
            xrLabel1.Font = New System.Drawing.Font("Arial", 9.75F)
            xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            xrLabel1.Name = "xrLabel1"
            xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel1.SizeF = New System.Drawing.SizeF(408.3333F, 23F)
            xrLabel1.StylePriority.UseFont = False
            xrLabel1.StylePriority.UseTextAlignment = False
            xrLabel1.Text = "xrLabel1"
            xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel2
            ' 
            xrLabel2.Bookmark = "Home"
            xrLabel2.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold)
            xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            xrLabel2.Name = "xrLabel2"
            xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel2.SizeF = New System.Drawing.SizeF(222.9167F, 23F)
            xrLabel2.StylePriority.UseFont = False
            xrLabel2.Text = "A sample report"
            ' 
            ' topMarginBand1
            ' 
            topMarginBand1.HeightF = 48F
            topMarginBand1.Name = "topMarginBand1"
            ' 
            ' bottomMarginBand1
            ' 
            bottomMarginBand1.HeightF = 48F
            bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' nwindDataSet1
            ' 
            nwindDataSet1.DataSetName = "nwindDataSet"
            nwindDataSet1.SchemaSerializationMode = Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' productsTableAdapter
            ' 
            productsTableAdapter.ClearBeforeFill = True
            ' 
            ' ReportHeader
            ' 
            ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {xrLabel2})
            ReportHeader.HeightF = 47F
            ReportHeader.Name = "ReportHeader"
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Detail, topMarginBand1, bottomMarginBand1, ReportHeader})
            Me.Bookmark = "Table of Contents"
            Me.DataAdapter = productsTableAdapter
            Me.DataMember = "Products"
            Me.DataSource = nwindDataSet1
            Me.FilterString = "[CategoryID] < 4"
            Me.Margins = New System.Drawing.Printing.Margins(49, 51, 48, 48)
            Me.Version = "12.2"
            CType(nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        End Sub
    End Class
End Namespace
