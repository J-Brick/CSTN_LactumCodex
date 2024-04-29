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

namespace CSTN_LactumCodex.pages.VariationPages.Factions.WHAos
{
    /// <summary>
    /// Interaction logic for FactionPageOrruk.xaml
    /// </summary>
    public partial class FactionPageOrruk : Window
    {
        public FactionPageOrruk()
        {
            InitializeComponent();
        }

        private void BackBTN(object sender, RoutedEventArgs e)
        {
            Factions40kSelect F40kS = new Factions40kSelect();
            F40kS.Show();
            this.Close();
        }
    }
}
