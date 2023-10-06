using DevExpress.Xpf.Printing;
using DevExpress.XtraPrinting;

namespace DXSample {
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
}
