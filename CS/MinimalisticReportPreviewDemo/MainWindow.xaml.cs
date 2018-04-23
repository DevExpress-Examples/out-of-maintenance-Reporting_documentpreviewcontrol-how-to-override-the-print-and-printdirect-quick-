using System.Windows;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Printing;
// ...

namespace MinimalisticReportPreviewDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            ThemeManager.ApplicationThemeName = "Office2007Silver";
            InitializeComponent();
        }

        private void ShowPreview(object sender, RoutedEventArgs e) {
            Report report = new Report();
            MyXtraReportPreviewModel model = new MyXtraReportPreviewModel(report);
            DocumentPreviewWindow window = new DocumentPreviewWindow() { Model = model };
            report.CreateDocument(true);
            window.ShowDialog();
        }
    }
}
