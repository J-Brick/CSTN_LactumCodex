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
using Firebase.Auth;
using Firebase.Auth.Providers;

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
        FirebaseAuthConfig FBConfig = new FirebaseAuthConfig();
        public static FirebaseAuthClient _FBCL;

        //        public Boolean Userlog;

        public string CUser;

        public LoginPage()
        {

            InitializeComponent();

            FBConfig.AuthDomain = "lactum-codex.web.app";
            FBConfig.ApiKey = "AIzaSyCUSGaC3ijY7SYc6HoOajvlL9XQQpS1R5M";
            FBConfig.Providers = new FirebaseAuthProvider[]
             {
             new EmailProvider()
             };

        }

        private async void LoginBTNsubmit_Click(object sender, RoutedEventArgs e)
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


                _FBCL = new FirebaseAuthClient(FBConfig);

                try
                {
                    await _FBCL.SignInWithEmailAndPasswordAsync(EmailIPB.Text, PasswordIPB.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("invalid input: one of these is incorrect: Email or password", "Login Error", MessageBoxButton.OK);
                }


                CUser = UsernameIPB.Text;

                MainSelection MS = new MainSelection();
                MS.Show();
                this.Hide();

                MS.UsernameLabel.Content = CUser;
            }
            else 
            {

                Checkbox.Background = new SolidColorBrush(Colors.Crimson);
                Checkbox.Text = "Username or password is incorrect, try again";

            }
        }

        private void back_page(object sender, RoutedEventArgs e)
        {

            MainWindow mw = new MainWindow();
            this.Hide();
            mw.Show();
        }
    }
}
