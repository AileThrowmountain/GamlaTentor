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

namespace Skidtenta
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

        private void buttonStav_Click(object sender, RoutedEventArgs e)
        {
            double myLength = double.Parse(textBoxLängd.Text);
            double myStick = myLength * 0.83;

            if (myLength < 140 || myLength > 210)
            {
                MessageBox.Show("Du har angett en orimlig längd på skidåkaren.");
            }
            else
            {
                MessageBox.Show($"Dina stavar får vara {myStick} cm");
            }
        }

        public string VilkenVallaburk(int temp)
        {
            if (temp <=  (-20))
            {
                return "Du måste välja en vit vallaburk!";
            }
            else if (temp >= (-19) && temp <=(-10))
            {
                return "Du måste välja en grön vallaburk!";

            }
            else if (temp >= (-9) && temp <= (-3))
            {
                return "Du måste välja en blå vallaburk!";

            }
            else if (temp >= (-2) && temp <= 1)
            {
                return "Du måste välja en violett vallaburk!";

            }
            else
            
                return "Du måste välja en röd vallaburk!";

            

        }

        private void buttonVallaburk_Click(object sender, RoutedEventArgs e)
        {
            int temp = int.Parse(textBoxValla.Text);
            MessageBox.Show($"{VilkenVallaburk(temp)}");

        }
    }
}
