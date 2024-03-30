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
        
        //SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-T0MJ1C2;Initial Catalog=CapstoneDBs;Integrated Security=True;Trust Server Certificate=True");
        DataTable DataTab = new DataTable();
        Hashtable HB = new Hashtable();
        string query;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginBTNsubmit_Click(object sender, RoutedEventArgs e)
        {


/*            
            try
            {*/
                /*if(sqlConn.State == ConnectionState.Closed)
                sqlConn.Open();*/
                HB.Clear();
                HB.Add("@AccountUser", UsernameIPB.Text);
                HB.Add("@AccountPass", PasswordIPB.Text);
                query = "SELECT * from AccountDetails where UserName = @AccountUser and Password @AccountPass ";
            DataTab = ExDB.GetDataTable("CapstoneDBs",HB,query);


            if (string.IsNullOrWhiteSpace(PasswordIPB.Text) || string.IsNullOrWhiteSpace(UsernameIPB.Text) )
            {


            }
            else if (DataTab == null || DataTab.Rows.Count != 0) 
            {
            

            }

            /*}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                throw;
            }*/

        }
    }
}
