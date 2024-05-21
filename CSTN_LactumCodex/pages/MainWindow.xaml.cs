using CSTN_LactumCodex.pages;
using CSTN_LactumCodex.pages.VariationPages;
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

namespace CSTN_LactumCodex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Warning_Page wp = new Warning_Page();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LGNButton_Click(object sender, RoutedEventArgs e)
        {

            wp.Show();
            this.Close();
           //Login.Userlog = false;

        }

        private void OCButton_Click(object sender, RoutedEventArgs e)
        {
    
            wp.Show();
            this.Hide();
        }

        private void SgnpButton_Click(object sender, RoutedEventArgs e)
        {

            wp.Show();
            this.Hide();
        }
    }
}