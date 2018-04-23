using DevExpress.Xpf.Printing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpf.Printing.PreviewControl;
using DevExpress.XtraPrinting;

namespace MinimalisticReportPreviewDemo {
    public class MyDocumentPreviewControl : DocumentPreviewControl {
        public override void Print() {
            PrintTool pt = new PrintTool(Document.PrintingSystem);
            pt.PrintingSystem.StartPrint += new PrintDocumentEventHandler(PrintingSystem_StartPrint);
            pt.PrintingSystem.PrintProgress += new PrintProgressEventHandler(PrintingSystem_PrintProgress);
            pt.PrintDialog();
        }

        void PrintingSystem_PrintProgress(object sender, PrintProgressEventArgs e) {

        }
        void PrintingSystem_StartPrint(object sender, PrintDocumentEventArgs e) {

        }

        public override void PrintDirect(string printerName = null) {
            PrintTool pt = new PrintTool(Document.PrintingSystem);
            pt.PrintingSystem.StartPrint += new PrintDocumentEventHandler(PrintingSystem_StartPrint);
            pt.PrintingSystem.PrintProgress += new PrintProgressEventHandler(PrintingSystem_PrintProgress);
            pt.Print();
        }

        public override void Export(ExportFormat? exportFormat) {
            if(exportFormat.HasValue && exportFormat.Value == ExportFormat.Xls) {
                Document.PrintingSystem.ExportToXls("test.xls");
                System.Windows.MessageBox.Show("!");
                System.Diagnostics.Process.Start("test.xls");
            } else if(exportFormat.HasValue && exportFormat.Value == ExportFormat.Pdf) {
                var exportModel = ExportOptionsViewModel.Create(Document.PrintingSystem, exportFormat.Value);
                exportModel.FileName = "test.pdf";
                new DocumentPublishEngine(Document.PrintingSystem).Export(exportModel);
            } else
                base.Export(exportFormat);
        }
    }
}
