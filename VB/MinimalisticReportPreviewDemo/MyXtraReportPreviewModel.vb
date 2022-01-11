Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting

Namespace MinimalisticReportPreviewDemo
	Public Class MyXtraReportPreviewModel
		Inherits XtraReportPreviewModel

		Public Sub New(ByVal report As XtraReport)
			MyBase.New(report)
		End Sub
		Protected Overrides Sub Print(ByVal parameter As Object)
			Dim pt As New PrintTool(Me.Report.PrintingSystemBase)
			AddHandler pt.PrintingSystem.StartPrint, AddressOf PrintingSystem_StartPrint
			AddHandler pt.PrintingSystem.PrintProgress, AddressOf PrintingSystem_PrintProgress
			pt.PrintDialog()
		End Sub

		Private Sub PrintingSystem_PrintProgress(ByVal sender As Object, ByVal e As PrintProgressEventArgs)

		End Sub
		Private Sub PrintingSystem_StartPrint(ByVal sender As Object, ByVal e As PrintDocumentEventArgs)

		End Sub
		Protected Overrides Sub PrintDirect(ByVal parameter As Object)
			Dim pt As New PrintTool(Me.Report.PrintingSystemBase)
			AddHandler pt.PrintingSystem.StartPrint, AddressOf PrintingSystem_StartPrint
			AddHandler pt.PrintingSystem.PrintProgress, AddressOf PrintingSystem_PrintProgress
			pt.Print()
		End Sub
		Protected Overrides Sub Export(ByVal parameter As Object)
			If parameter IsNot Nothing Then
				If parameter.ToString() = "Xls" Then
					PrintingSystem.ExportToXls("test.xls")
					System.Windows.MessageBox.Show("!")
					System.Diagnostics.Process.Start("test.xls")
				Else
					MyBase.Export(parameter)
				End If
			End If
		End Sub
	End Class
End Namespace
