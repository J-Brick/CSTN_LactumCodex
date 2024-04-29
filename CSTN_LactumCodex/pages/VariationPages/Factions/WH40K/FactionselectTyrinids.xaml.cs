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
    /// Interaction logic for FactionselectTyrinids.xaml
    /// </summary>
    public partial class FactionselectTyrinids : Window
    {

        DataTable DataTab = new DataTable();
        Hashtable HB = new Hashtable();
        string query;
        DataRow rows;

        public bool showinfo = true;

        public FactionselectTyrinids()
        {
            InitializeComponent();
        }

        private void BackBTN(object sender, RoutedEventArgs e)
        {
            Factions40kSelect F40kS = new Factions40kSelect();
            F40kS.Show();
            this.Close();
        }

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
            query = "SELECT * from FactionDetails where FactionName = @FactionNamE";
            DataTab = ExDB.GetDataTable("CapstoneDBs", HB, query);

            //and FactionGovernment = @FactionGovernmenT and FactionCurrency = @FactionCurrencY and FactionLeaders = @FactionLeaderS and FactionReligion = @FactionReligioN and FactionDeities = @FactionDeitieS and FactionLanguage = @FactionLanguagE

            if (DataTab != null && showinfo == true) { }

            rows = DataTab.Rows[0];

            string FacName = (string)rows["FactionName"];
            string FacGov = (string)rows["FactionGovernment"];
            string FacCur = (string)rows["FactionCurrency"];
            string FacLead = (string)rows["FactionLeaders"];
            string FacRel = (string)rows["FactionReligion"];
            string FacDeit = (string)rows["FactionDeities"];
            string FacLang = (string)rows["FactionLanguage"];

            FnBLK.Text = FacName;
            FgBLK.Text = FacGov;
            FcBLK.Text = FacCur;
            FlBLK.Text = FacLead;
            FrBLK.Text = FacRel;
            FdtyBLK.Text = FacDeit;
            FaBLk.Text = FacLang;

            ExDB.ExecuteIt("CapstoneDBs", query, HB);
        }

        public void displayInfo()
        {
            infoShow();
        }

    }
}
