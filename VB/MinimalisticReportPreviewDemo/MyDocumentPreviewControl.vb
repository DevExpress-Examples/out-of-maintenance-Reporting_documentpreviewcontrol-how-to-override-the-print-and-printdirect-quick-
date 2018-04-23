Imports DevExpress.Xpf.Printing
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpf.Printing.PreviewControl
Imports DevExpress.XtraPrinting

Namespace MinimalisticReportPreviewDemo
    Public Class MyDocumentPreviewControl
        Inherits DocumentPreviewControl

        Public Overrides Sub Print()
            Dim pt As New PrintTool(Document.PrintingSystem)
            AddHandler pt.PrintingSystem.StartPrint, AddressOf PrintingSystem_StartPrint
            AddHandler pt.PrintingSystem.PrintProgress, AddressOf PrintingSystem_PrintProgress
            pt.PrintDialog()
        End Sub

        Private Sub PrintingSystem_PrintProgress(ByVal sender As Object, ByVal e As PrintProgressEventArgs)

        End Sub
        Private Sub PrintingSystem_StartPrint(ByVal sender As Object, ByVal e As PrintDocumentEventArgs)

        End Sub

        Public Overrides Sub PrintDirect(Optional ByVal printerName As String = Nothing)
            Dim pt As New PrintTool(Document.PrintingSystem)
            AddHandler pt.PrintingSystem.StartPrint, AddressOf PrintingSystem_StartPrint
            AddHandler pt.PrintingSystem.PrintProgress, AddressOf PrintingSystem_PrintProgress
            pt.Print()
        End Sub

        Public Overrides Sub Export(ByVal exportFormat? As ExportFormat)
            If exportFormat.HasValue AndAlso exportFormat.Value = DevExpress.XtraPrinting.ExportFormat.Xls Then
                Document.PrintingSystem.ExportToXls("test.xls")
                System.Windows.MessageBox.Show("!")
                System.Diagnostics.Process.Start("test.xls")
            ElseIf exportFormat.HasValue AndAlso exportFormat.Value = DevExpress.XtraPrinting.ExportFormat.Pdf Then
                Dim exportModel = ExportOptionsViewModel.Create(Document.PrintingSystem, exportFormat.Value)
                exportModel.FileName = "test.pdf"
                CType(New DocumentPublishEngine(Document.PrintingSystem), DocumentPublishEngine).Export(exportModel)
            Else
                MyBase.Export(exportFormat)
            End If
        End Sub
    End Class
End Namespace
