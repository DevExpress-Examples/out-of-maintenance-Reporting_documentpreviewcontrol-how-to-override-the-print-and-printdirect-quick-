<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MinimalisticReportPreviewDemo/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MinimalisticReportPreviewDemo/MainWindow.xaml))
* **[MainWindow.xaml.cs](./CS/MinimalisticReportPreviewDemo/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MinimalisticReportPreviewDemo/MainWindow.xaml.vb))**
* [MyDocumentPreviewControl.cs](./CS/MinimalisticReportPreviewDemo/MyDocumentPreviewControl.cs) (VB: [MyDocumentPreviewControl.vb](./VB/MinimalisticReportPreviewDemo/MyDocumentPreviewControl.vb))
<!-- default file list end -->
# DocumentPreviewControl - How to override the Print and PrintDirect (Quick Print) commands


<p>This example demonstrates how to override commands in the <a href="https://documentation.devexpress.com/#WPF/CustomDocument9697">Document Preview</a> (<a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfPrintingDocumentPreviewControltopic">DocumentPreviewControl</a>). Create a DocumentPreviewControl descendant and override the corresponding methods, e.g., Print and PrintDirect.</p>
<p>For example:</p>
```cs
public class MyDocumentPreviewControl : DocumentPreviewControl {
    public override void Print() {
        PrintTool pt = new PrintTool(Document.PrintingSystem);
        pt.PrintingSystem.StartPrint += new PrintDocumentEventHandler(PrintingSystem_StartPrint);
        pt.PrintingSystem.PrintProgress += new PrintProgressEventHandler(PrintingSystem_PrintProgress);
        pt.PrintDialog();
    }
    public override void PrintDirect(string printerName = null) {
        PrintTool pt = new PrintTool(Document.PrintingSystem);
        pt.PrintingSystem.StartPrint += new PrintDocumentEventHandler(PrintingSystem_StartPrint);
        pt.PrintingSystem.PrintProgress += new PrintProgressEventHandler(PrintingSystem_PrintProgress);
        pt.Print();
    }
    void PrintingSystem_PrintProgress(object sender, PrintProgressEventArgs e) {

    }
    void PrintingSystem_StartPrint(object sender, PrintDocumentEventArgs e) {
    
    }
}
```
<p><strong><br></strong>See also: <a href="https://www.devexpress.com/Support/Center/p/E4482">DocumentPreviewControl - How to override the Export command</a>.</p>

<br/>


