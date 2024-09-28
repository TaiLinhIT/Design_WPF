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

namespace RadioButtonDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rbTrump.IsChecked = true;
        }

        private void rbTrump_Checked(object sender, RoutedEventArgs e)
        {
            lbTrump.Background = Brushes.GhostWhite;
        }

        private void rbTrump_Unchecked(object sender, RoutedEventArgs e)
        {
            lbTrump.Background = Brushes.White;

        }
    }
}