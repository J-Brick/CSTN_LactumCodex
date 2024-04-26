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

namespace CSTN_LactumCodex.pages.chatArea
{
    /// <summary>
    /// Interaction logic for ChatArea.xaml
    /// </summary>
    public partial class ChatArea : Window
    {
        public ChatArea()
        {
            InitializeComponent();
        }

        private void Border_mouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Min_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void Max_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }

        }

        private void BackBTN(object sender, RoutedEventArgs e)
        {
            MainSelection MS = new MainSelection();
            MS.Show();
            this.Hide();

            MS.UsernameLabel.Content = CUsername.Content;
        }
    }
}

//for testing porposes