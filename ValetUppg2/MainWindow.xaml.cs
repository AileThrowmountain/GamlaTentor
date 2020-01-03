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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ValetUppg2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        { int counter = 0; 
            
            int[] chairs = new int[] { 70, 31, 20, 22, 100, 28, 16, 62 };

            if (chkModeraterna.IsChecked == true)
            {
                counter += chairs[0];
                
            }
            if (chkCenterpartiet.IsChecked == true)
            {
                counter += chairs[1];
            }
            if (chkLiberalerna.IsChecked == true)
            {
                counter += chairs[2];
            }
            if (chkKristdemokraterna.IsChecked == true)
            {
                counter += chairs[3];
            }
            if (chkSocialdemokraterna.IsChecked == true)
            {
                counter += chairs[4];
            }
            if (chkVänsterpartiet.IsChecked == true)
            {
                counter += chairs[5];
            }
            if (chkMiljöpartiet.IsChecked == true)
            {
                counter += chairs[6];
            }
            if (chkSveriedemokraterna.IsChecked == true)
            {
                counter += chairs[7];
            }

            int result = counter;

            if (result >= 174)
            {
                MessageBox.Show($"Resultat: {result} av 349, mandat? JA");
            }
            else 
            {
                MessageBox.Show($"Resultat: {result} av 349, mandat? NEJ");
            }

        }
    }
}
