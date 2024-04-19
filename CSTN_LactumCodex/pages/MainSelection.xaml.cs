using CSTN_LactumCodex.pages.chatArea;
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
            LoginPage LP = new LoginPage();

        public MainSelection()
        {
            InitializeComponent();
        }

        private void ChatBTN(object sender, RoutedEventArgs e)
        {

            LP.CUser = (string)UsernameLabel.Content;

            if (UsernameLabel.Content == "" || UsernameLabel.Content == null)
            {
                LP.Show();
                this.Hide();
            }
            else if (UsernameLabel.Content == LP.CUser)
            {
            ChatArea chat = new ChatArea();
                chat.Show();
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
