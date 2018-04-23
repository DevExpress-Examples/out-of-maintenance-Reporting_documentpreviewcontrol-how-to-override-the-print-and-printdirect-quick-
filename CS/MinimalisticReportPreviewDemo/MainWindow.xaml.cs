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
            ApplicationThemeHelper.ApplicationThemeName = Theme.Office2016WhiteName;
            InitializeComponent();
        }

        private void ShowPreview(object sender, RoutedEventArgs e) {
            Report report = new Report();
            var preview = new MyDocumentPreviewControl() { DocumentSource = report };
            var window = new Window() { Content = preview };
            report.CreateDocument(true);
            window.ShowDialog();
        }
    }
}
