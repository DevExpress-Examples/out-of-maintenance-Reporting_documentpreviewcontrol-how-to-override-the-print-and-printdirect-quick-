using DevExpress.Xpf.Printing;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;

namespace MinimalisticReportPreviewDemo {
    public class MyXtraReportPreviewModel : XtraReportPreviewModel {
        public MyXtraReportPreviewModel(XtraReport report) : base(report) { }
        protected override void Print(object parameter) {
            PrintTool pt = new PrintTool(this.Report.PrintingSystemBase);
            pt.PrintingSystem.StartPrint += new PrintDocumentEventHandler(PrintingSystem_StartPrint);
            pt.PrintingSystem.PrintProgress += new PrintProgressEventHandler(PrintingSystem_PrintProgress);
            pt.PrintDialog();
        }

        void PrintingSystem_PrintProgress(object sender, PrintProgressEventArgs e) {
            
        }
        void PrintingSystem_StartPrint(object sender, PrintDocumentEventArgs e) {
           
        }
        protected override void PrintDirect(object parameter) {
            PrintTool pt = new PrintTool(this.Report.PrintingSystemBase);
            pt.PrintingSystem.StartPrint += new PrintDocumentEventHandler(PrintingSystem_StartPrint);
            pt.PrintingSystem.PrintProgress += new PrintProgressEventHandler(PrintingSystem_PrintProgress);
            pt.Print();
        }
        protected override void Export(object parameter) {
            if(parameter != null) {
                if(parameter.ToString() == "Xls") {
                    PrintingSystem.ExportToXls("test.xls");
                    System.Windows.MessageBox.Show("!");
                    System.Diagnostics.Process.Start("test.xls");
                } else
                    base.Export(parameter);
            }
        }
    }
}
