Imports System.Windows
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Printing
' ...

Namespace DXSample
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim report As New XtraReport1()
			Dim preview = New MyDocumentPreviewControl() With {.DocumentSource = report}
			Dim window() As New Window() With {.Content = preview}
			report.CreateDocument(True)
			window.ShowDialog()
		End Sub
	End Class
End Namespace
