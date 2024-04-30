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
    /// Interaction logic for FactionPageOrder.xaml
    /// </summary>
    public partial class FactionPageOrder : Window
    {
        public FactionPageOrder()
        {
            InitializeComponent();
        }

        private void BackBTN(object sender, RoutedEventArgs e)
        {
            FactionsAOSSelect FAOSS = new FactionsAOSSelect();
            FAOSS.Show();
            this.Close();
        }
    }
}
