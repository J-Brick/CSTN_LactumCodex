using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
    /// Interaction logic for SoundSampler.xaml
    /// </summary>
    public partial class SoundSampler : Window
    {
        public SoundSampler()
        {
            InitializeComponent();
        }

        private void PlayORKS(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\jbrickwedde\source\repos\CSC160\Capstone\CSTN_LactumCodex\CSTN_LactumCodex\pages\VariationPages\sound bites\Waaagh!.wav");
            player.Load();
            player.Play();
        }

        private void PlayIMP(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\jbrickwedde\source\repos\CSC160\Capstone\CSTN_LactumCodex\CSTN_LactumCodex\pages\VariationPages\sound bites\Imperium.wav");
            player.Load();
            player.Play();
        }

        private void BackBTN(object sender, RoutedEventArgs e)
        {
            MainSelection ms = new MainSelection();
            this.Hide();
            ms.Show();

        }
    }
}
