using Microsoft.Win32;
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

namespace CSTN_LactumCodex.pages
{
    /// <summary>
    /// Interaction logic for ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Window
    {
        MainSelection ms = new MainSelection();
        public ProfilePage()
        {
            InitializeComponent();
       
        }



        DataTable DataTab = new DataTable();
        Hashtable HB = new Hashtable();
        string query1;
        string query2;
        DataRow rows;
        string sourceURI;


        private void ChangeImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            Openfile.Filter = "Image Files|*.bmp;*.jpg*.png,*.jpeg";
            Openfile.FilterIndex = 1;
            if (Openfile.ShowDialog() == true)
            {
                ProfPicture.Source = new BitmapImage(new Uri(Openfile.FileName));
                sourceURI = Openfile.FileName;
            }
/*            HB.Add("@profSource",ProfPicture.Source);
            HB.Add("@userName",UsernameBX.Content);
            query1 = "SELECT * from UserProfImg where UserName = @userName";
            DataTab = ExDB.GetDataTable("CapstoneDBs", HB, query1);

            if (DataTab != null) { }

            rows = DataTab.Rows[0];*/

/*            string userNM = (string)rows["UserName"];
            string userPI = (string)rows["UserProfImg"];*/
            

        }

        private void saveInfo_Click(object sender, RoutedEventArgs e)
        {
/*            HB.Add("@profSource", ProfPicture.Source);*/
            HB.Add("@userName", UsernameBX.Content);
            HB.Add("@userFavFact", favFaction.Text);
            query1 = "update UserProfImg set UserName = @userName, FavFaction = @userFavFact";
            /* UserProfImg = @profSource*/
            query2 = "update AccountDetailTable set UserName = @userName";
            DataTab = ExDB.GetDataTable("CapstoneDBs", HB, query1);
            DataTab = ExDB.GetDataTable("CapstoneDBs", HB, query2);
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
