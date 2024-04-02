﻿using System;
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
    /// Interaction logic for Factions40kSelect.xaml
    /// </summary>
    public partial class Factions40kSelect : Window
    {
        public Factions40kSelect()
        {
            InitializeComponent();
        }

        private void Faction_Select01(object sender, RoutedEventArgs e)
        {
           Factions.FactionpageImperium IOM  = new Factions.FactionpageImperium();
            IOM.Show();
            this.Hide();
        }

        private void Faction_Select02(object sender, RoutedEventArgs e)
        {
            Factions.FactionpageForcesChaos FOC = new Factions.FactionpageForcesChaos();
            FOC.Show();
            this.Hide();
        }

        private void Faction_Select03(object sender, RoutedEventArgs e)
        {
            Factions.FactionpageGreenskins ORK = new Factions.FactionpageGreenskins ();
            ORK.Show();
            this.Hide();
        }

        private void Faction_Select04(object sender, RoutedEventArgs e)
        {
           Factions.FactionpageEldar ELD = new Factions.FactionpageEldar();
            ELD.Show();
            this.Hide();
        }

        private void Faction_Select05(object sender, RoutedEventArgs e)
        {
            Factions.FactionselectNecrons NEC = new Factions.FactionselectNecrons();
            NEC.Show();
            this.Hide();
        }

        private void Faction_Select06(object sender, RoutedEventArgs e)
        {
            Factions.FactionselectTyrinids TND = new Factions.FactionselectTyrinids();
            TND.Show();
            this.Hide();
        }
    }
}
