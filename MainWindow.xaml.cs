using AssureTec.AssureID.SDK;
using Llama_IDScanner.Scanner;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Llama_IDScanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly AssuretecScanner LlamaScanner;

        public MainWindow()
        {
            InitializeComponent();
            LlamaScanner = new AssuretecScanner();
        }

        private void TestBtn_Click(object sender, RoutedEventArgs e)
        {
            var bob = LlamaScanner.ScannerStatus;
            MessageBox.Show(bob.ToString());
            
        }
    }
}