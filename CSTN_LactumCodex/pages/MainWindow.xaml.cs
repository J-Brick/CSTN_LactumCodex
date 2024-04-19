using CSTN_LactumCodex.pages;
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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LGNButton_Click(object sender, RoutedEventArgs e)
        {
           LoginPage Login = new LoginPage();
            Login.Show();
            this.Close();
           //Login.Userlog = false;

        }

        private void OCButton_Click(object sender, RoutedEventArgs e)
        {
             MainSelection MS = new MainSelection();
            MS.Show();
            this.Hide();
        }

        private void SgnpButton_Click(object sender, RoutedEventArgs e)
        {
            SignUpPage SUP = new SignUpPage();
            SUP.Show();
            this.Hide();
        }
    }
}