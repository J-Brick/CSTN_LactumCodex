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

namespace CSTN_LactumCodex.pages.VariationPages.Factions
{
    /// <summary>
    /// Interaction logic for FactionpageGreenskins.xaml
    /// </summary>
    public partial class FactionpageGreenskins : Window
    {


        DataTable DataTab = new DataTable();
        Hashtable HB = new Hashtable();
        string query;

        public bool showinfo = true;

        public FactionpageGreenskins()
        {
            InitializeComponent();
        }

        private void BackBTN(object sender, RoutedEventArgs e)
        {
            Factions40kSelect F40kS = new Factions40kSelect();
            F40kS.Show();
            this.Close();
        }
        /*
        private void infoShow()
        {
            HB.Clear();
            HB.Add("@FactionNamE", FnBLK.Text);
            HB.Add("@FactionGovernmenT", FgBLK.Text);
            HB.Add("@FactionCurrencY", FcBLK.Text);
            HB.Add("@FactionLeaderS", FlBLK.Text);
            HB.Add("@FactionReligioN", FrBLK.Text);
            HB.Add("@FactionDeitieS", FdtyBLK.Text);
            HB.Add("@FactionLanguagE", FaBLk.Text);
            query = "SELECT * from FactionDetails where FactionName = @FactionNamE, FactionGovernment = @FactionGovernmenT, FactionCurrency = @FactionCurrencY, FactionLeaders = @FactionLeaderS, FactionReligion = @FactionReligioN, FactionDeities = @FactionDeitieS, FactionLanguage = @FactionLanguagE";
            DataTab = ExDB.GetDataTable("CapstoneDBs", HB, query);


            if (showinfo == true)
            {

              
                
            }
            else if (showinfo == false)
            {
                showinfo = true;
            }
           
            
        }
        */
    }
}
