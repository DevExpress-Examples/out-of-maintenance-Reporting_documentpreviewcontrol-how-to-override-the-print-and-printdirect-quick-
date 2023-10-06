using System.Windows;

namespace DXSample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            XtraReport1 report = new XtraReport1();
            var preview = new MyDocumentPreviewControl() { DocumentSource = report };
            var window = new Window() { Content = preview };
            report.CreateDocument(true);
            window.ShowDialog();
        }
    }
}
