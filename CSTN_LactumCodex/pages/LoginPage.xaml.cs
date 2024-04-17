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
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace CSTN_LactumCodex.pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        
        DataTable DataTab = new DataTable();
        Hashtable HB = new Hashtable();
        string query;

        public Boolean Userlog = false;

        public string CUser;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginBTNsubmit_Click(object sender, RoutedEventArgs e)
        {

                HB.Clear();
                HB.Add("@AccountUser", UsernameIPB.Text);
                HB.Add("@AccountPass", PasswordIPB.Text);
                query = "SELECT * from AccountDetailTable where UserName = @AccountUser and Password = @AccountPass ";
            DataTab = ExDB.GetDataTable("CapstoneDBs",HB,query);

            CUser = UsernameIPB.Text;

            if (string.IsNullOrWhiteSpace(PasswordIPB.Text) || string.IsNullOrWhiteSpace(UsernameIPB.Text))
            {

                Checkbox.Background = new SolidColorBrush(Colors.Crimson);
                Checkbox.Text = "please enter Username or password";
            }
            else if (DataTab == null || DataTab.Rows.Count != 0)
            {

                Userlog = true;
                CUser = UsernameIPB.Text;


                WHvariationPage WHV = new WHvariationPage();
                WHV.Show();
                this.Hide();
            }
            else 
            {

                Checkbox.Background = new SolidColorBrush(Colors.Crimson);
                Checkbox.Text = "Username or password is incorrect, try again";

            }
        }
    }
}
