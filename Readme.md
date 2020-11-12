<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MinimalisticReportPreviewDemo/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MinimalisticReportPreviewDemo/MainWindow.xaml))
* **[MainWindow.xaml.cs](./CS/MinimalisticReportPreviewDemo/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MinimalisticReportPreviewDemo/MainWindow.xaml.vb))**
* [MyDocumentPreviewControl.cs](./CS/MinimalisticReportPreviewDemo/MyDocumentPreviewControl.cs) (VB: [MyDocumentPreviewControl.vb](./VB/MinimalisticReportPreviewDemo/MyDocumentPreviewControl.vb))
<!-- default file list end -->
# DocumentPreviewControl - How to override the Print and PrintDirect (Quick Print) commands


This example demonstrates how to override commands in the [Document Preview](https://documentation.devexpress.com/#WPF/CustomDocument9697) [DocumentPreviewControl]((https://documentation.devexpress.com/#WPF/clsDevExpressXpfPrintingDocumentPreviewControltopic)). 
Create a DocumentPreviewControl descendant and override the corresponding methods, e.g., Print and PrintDirect.

For example:
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

See also: [DocumentPreviewControl - How to override the Export command](https://www.devexpress.com/Support/Center/p/E4482)

