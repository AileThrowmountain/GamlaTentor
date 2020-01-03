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

namespace TvattTenta
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
        int[] washTemp = new int[] { 30, 60, 40, 30, 40, 60 };
        int lowestTemp = 0;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            LetaIgenom();

        }

        public void LetaIgenom()
        {

            //jag har ett värde som är din lägsta temp..
            //och den ska bara bytas ut OM ett annat värde är lägre


            foreach (int temp in washTemp)
            {
                if (temp < lowestTemp)
                {
                    lowestTemp = temp;
                    //någon messagebox 
                }


            }

        }
    }
}

