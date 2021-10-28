Imports System.Windows
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Printing

' ...
Namespace MinimalisticReportPreviewDemo

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits System.Windows.Window

        Public Sub New()
            ThemeManager.ApplicationThemeName = "Office2007Silver"
            Me.InitializeComponent()
        End Sub

        Private Sub ShowPreview(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Dim report As MinimalisticReportPreviewDemo.Report = New MinimalisticReportPreviewDemo.Report()
            Dim model As MinimalisticReportPreviewDemo.MyXtraReportPreviewModel = New MinimalisticReportPreviewDemo.MyXtraReportPreviewModel(report)
            Dim window As DocumentPreviewWindow = New DocumentPreviewWindow() With {.Model = model}
            report.CreateDocument(True)
            window.ShowDialog()
        End Sub
    End Class
End Namespace
