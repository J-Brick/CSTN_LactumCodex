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

namespace CSTN_LactumCodex.pages
{
    /// <summary>
    /// Interaction logic for WHvariationPage.xaml
    /// </summary>
    public partial class WHvariationPage : Window
    {
        public WHvariationPage()
        {
            InitializeComponent();
        }

        private void Variation_Select01(object sender, RoutedEventArgs e)
        {
           VariationPages.Factions40kSelect  faction40k = new VariationPages.Factions40kSelect ();
            faction40k.Show();
            this.Close();
        }

        private void Variation_Select02(object sender, RoutedEventArgs e)
        {
            VariationPages.FactionsAOSSelect FactionAgeofSigmar = new VariationPages.FactionsAOSSelect();
            FactionAgeofSigmar.Show();
            this.Close();
        }

        private void Variation_Select03(object sender, RoutedEventArgs e)
        {
            VariationPages.FactionsFantasySelect FactionFantasy = new VariationPages.FactionsFantasySelect();
            FactionFantasy.Show();
            this.Close();
        }
    }
}


//bout 1hr 45min