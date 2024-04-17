using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CSTN_LactumCodex.pages
{
    /// <summary>
    /// Interaction logic for MainSelection.xaml
    /// </summary>
    public partial class MainSelection : Window
    {
        public MainSelection()
        {
            InitializeComponent();
        }

        private void ChatBTN(object sender, RoutedEventArgs e)
        {
            pages.LoginPage LP = new pages.LoginPage();
            if ( LP.Userlog == false )
            {
                LP.Show();
                this.Hide();
            }

        }

        private void InfoPagesBTN(object sender, RoutedEventArgs e)
        {
            WHvariationPage WHV = new WHvariationPage();
            WHV.Show();
            this.Hide();
        }
    }
}
