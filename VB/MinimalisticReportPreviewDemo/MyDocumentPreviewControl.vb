Imports DevExpress.Xpf.Printing
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpf.Printing.PreviewControl
Imports DevExpress.XtraPrinting

Namespace DXSample
	Public Class MyDocumentPreviewControl
		Inherits DocumentPreviewControl

		Public Overrides Sub Print()
			Dim pt As New PrintTool(Document.PrintingSystem)
			AddHandler pt.PrintingSystem.StartPrint, AddressOf PrintingSystem_StartPrint
			AddHandler pt.PrintingSystem.PrintProgress, AddressOf PrintingSystem_PrintProgress
			pt.PrintDialog()
		End Sub
		Public Overrides Sub PrintDirect(Optional ByVal printerName As String = Nothing)
			Dim pt As New PrintTool(Document.PrintingSystem)
			AddHandler pt.PrintingSystem.StartPrint, AddressOf PrintingSystem_StartPrint
			AddHandler pt.PrintingSystem.PrintProgress, AddressOf PrintingSystem_PrintProgress
			pt.Print()
		End Sub
		Private Sub PrintingSystem_PrintProgress(ByVal sender As Object, ByVal e As PrintProgressEventArgs)

		End Sub
		Private Sub PrintingSystem_StartPrint(ByVal sender As Object, ByVal e As PrintDocumentEventArgs)

		End Sub
	End Class
End Namespace
