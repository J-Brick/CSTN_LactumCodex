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

namespace CSTN_LactumCodex.pages.VariationPages
{
    /// <summary>
    /// Interaction logic for FactionsFantasySelect.xaml
    /// </summary>
    public partial class FactionsFantasySelect : Window
    {
        public FactionsFantasySelect()
        {
            InitializeComponent();
        }

        private void Faction_Select01(object sender, RoutedEventArgs e)
        {
            Factions.WHFant.FactionPageEmpire TE = new Factions.WHFant.FactionPageEmpire();
            this.Hide();
            TE.Show();

        }

        private void Faction_Select02(object sender, RoutedEventArgs e)
        {
            Factions.WHFant.FactionPageDwarves DW = new Factions.WHFant.FactionPageDwarves();
            this.Hide();
            DW.Show();
        }

        private void Faction_Select03(object sender, RoutedEventArgs e)
        {
            Factions.WHFant.FactionPageFantGreenskins FG = new Factions.WHFant.FactionPageFantGreenskins();
            this.Hide();
            FG.Show();
        }

        private void Faction_Select04(object sender, RoutedEventArgs e)
        {
            Factions.WHFant.FactionPageDarkElves DE = new Factions.WHFant.FactionPageDarkElves();
            this.Hide();
            DE.Show();
        }

        private void Faction_Select05(object sender, RoutedEventArgs e)
        {
            Factions.WHFant.FactionPageVampireCounts VC = new Factions.WHFant.FactionPageVampireCounts();
            this.Hide();
            VC.Show();
        }

        private void Faction_Select06(object sender, RoutedEventArgs e)
        {
            Factions.WHFant.FactionPageLizardMen LM = new Factions.WHFant.FactionPageLizardMen();
            this.Hide();
            LM.Show();
        }

        private void BackBTN(object sender, RoutedEventArgs e)
        {
            WHvariationPage WHP = new WHvariationPage();
            WHP.Show();
            this.Close();
        }
    }
}
