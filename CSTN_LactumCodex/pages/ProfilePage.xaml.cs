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
        string query;
        DataRow rows;
        string sourceURI;


        private void ChangeImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            Openfile.Filter = "Image Files|*.bmp;*.jpg*.png";
            Openfile.FilterIndex = 1;
            if (Openfile.ShowDialog() == true)
            {
                ProfPicture.Source = new BitmapImage(new Uri(Openfile.FileName));
                sourceURI = Openfile.FileName;
            }
            HB.Add("@profSource",ProfPicture.Source);
            HB.Add("@userName",UsernameBX.Content);
            query = "SELECT * from where UserName = @userName";
            DataTab = ExDB.GetDataTable("CapstoneDBs", HB, query);

            if (DataTab != null) { }

            rows = DataTab.Rows[0];

/*            string userNM = (string)rows["UserName"];
            string userPI = (string)rows["UserProfImg"];*/
            

        }

        private void saveInfo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
