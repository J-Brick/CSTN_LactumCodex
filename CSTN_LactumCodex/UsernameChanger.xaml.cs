using CSTN_LactumCodex.pages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

namespace CSTN_LactumCodex
{
    /// <summary>
    /// Interaction logic for UsernameChanger.xaml
    /// </summary>
    public partial class UsernameChanger : Window
    {

        DataTable DataTab = new DataTable();
        Hashtable HB = new Hashtable();
        DataRow rows;
        string query1;

        public UsernameChanger()
        {
            InitializeComponent();
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {

            HB.Add("@userName", NameChanger.Text);
            HB.Add("@CuruserName", CurChanger.Text);
            query1 = "update AccountDetailTable set UserName = @userName where UserName = @CuruserName";
            DataTab = ExDB.GetDataTable("CapstoneDBs", HB, query1);


        }

        private void Close_click(object sender, RoutedEventArgs e)
        {

            ProfilePage pfp = new ProfilePage();
            pfp.UsernameBX.Content = NameChanger.Text;
            this.Close();
            pfp.Show();
        }
    }
}
