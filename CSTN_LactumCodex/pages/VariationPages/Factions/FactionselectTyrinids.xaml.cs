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

namespace CSTN_LactumCodex.pages.VariationPages.Factions
{
    /// <summary>
    /// Interaction logic for FactionselectTyrinids.xaml
    /// </summary>
    public partial class FactionselectTyrinids : Window
    {
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
    }
}