﻿using Firebase.Auth;
using Firebase.Auth.Providers;
using FireSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
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
    /// Interaction logic for SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Window
    {

        Hashtable HB = new Hashtable();
        DataTable DataTab;
        string query;
        FirebaseAuthConfig FBConfig = new FirebaseAuthConfig();
        public static FirebaseAuthClient _FBCL;
//     bool AccDeetCheck = true; 
        

        public SignUpPage()
        {
            InitializeComponent();

            FBConfig.AuthDomain = "lactum-codex.web.app";
            FBConfig.ApiKey = "AIzaSyCUSGaC3ijY7SYc6HoOajvlL9XQQpS1R5M";
            FBConfig.Providers = new FirebaseAuthProvider[]
             {
             new EmailProvider()
             };

        }

        private async void Acc_Create(object sender, RoutedEventArgs e)
        {
            //User Name
            //Password
            //Email
            //First Name
            //Last Name

            HB.Clear();
            HB.Add("@UserUser", userUsername.Text);
            HB.Add("@UserPassword", userPassword.Text);
            HB.Add("@UserEmail", userEmail.Text);
            HB.Add("@UserFirstName", userFname.Text);
            HB.Add("@UserLastName", userLname.Text);
            query = "Select * from AccountDetailTable where UserName = @UserUser or Email = @UserEmail";
            DataTab = ExDB.GetDataTable("CapstoneDBs", HB, query);

            if (String.IsNullOrEmpty(userUsername.Text) || String.IsNullOrEmpty(userPassword.Text) || String.IsNullOrEmpty(userEmail.Text) || String.IsNullOrEmpty(userFname.Text) || String.IsNullOrEmpty(userLname.Text))
            {

                MessageBox.Show("invalid input: must include: \nUsername \nPassword \nEmail \nfirst and last names");

            } 
            else 
            {

                query = "insert into AccountDetailTable (UserName, Password, FirstName, LastName, Email) Values (@UserUser,@UserPassword,@UserFirstName,@UserLastName,@UserEmail)";
                ExDB.ExecuteIt("CapstoneDBs",query,HB);

                _FBCL = new FirebaseAuthClient(FBConfig);

                try
                {
                    await _FBCL.CreateUserWithEmailAndPasswordAsync(userEmail.Text, userPassword.Text, userUsername.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("invalid input: one of these is incorrect: \nUsername \nPassword \nEmail",  "Sign up Error",  MessageBoxButton.OK);
                }

                //creates user account in the user Accounts Database

                LoginPage Login = new LoginPage();
                Login.Show();
                this.Close();

            }
        
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Hide();
            mw.Show();
        }


    }
}
//4 hours
  