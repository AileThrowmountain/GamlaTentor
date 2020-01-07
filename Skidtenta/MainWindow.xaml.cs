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
            if (temp <= (-20))
            {
                return "Du måste välja en vit vallaburk!";
            }
            else if (temp >= (-19) && temp <= (-10))
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

        private void buttonBonus_Click(object sender, RoutedEventArgs e)
        {
            List<Tävlande> startlista = new List<Tävlande>
             {
             new Tävlande() {Namn ="NILSSON Stina",Land="SWE",Bonussekunder = new int[]{44,0,0,15,15,60}},
             new Tävlande() {Namn ="WENG Heidi",Land="NOR",Bonussekunder = new int[]{48,15,0,5,10,35}},
             new Tävlande() {Namn ="PARMAKOSKI Krista",Land="FIN",Bonussekunder = new int[]{60,10,5,0,0,34}},
             new Tävlande() {Namn ="OESTBERG Ingvild Flugstad",Land="NOR",Bonussekunder = new int[]{30,5,15,0,5,52}},
             new Tävlande() {Namn ="DIGGINS Jessica",Land="USA",Bonussekunder = new int[]{56,0,10,0,0,40}},
             new Tävlande() {Namn ="NISKANEN Kerttu",Land="FIN",Bonussekunder = new int[]{52,0,0,0,0,38}},
             new Tävlande() {Namn ="KYLLOENEN Anne",Land="FIN",Bonussekunder = new int[]{42,0,0,10,0,36}},
             new Tävlande() {Namn ="VON SIEBENTHAL Nathalie",Land="SUI",Bonussekunder = new int[]{36,0,0,0,0,48}},
             new Tävlande() {Namn ="STADLOBER Teresa",Land="AUT",Bonussekunder = new int[]{32,0,0,0,0,44}},
             new Tävlande() {Namn ="TCHEKALEVA Yulia",Land="RUS",Bonussekunder = new int[]{40,0,0,0,0,34}},
             new Tävlande() {Namn ="KALLA Charlotte",Land="SWE",Bonussekunder = new int[]{38,0,0,0,0,32}},
             new Tävlande() {Namn ="MONONEN Laura",Land="FIN",Bonussekunder = new int[]{34,0,0,0,0,30}},
             new Tävlande() {Namn ="BOEHLER Stefanie",Land="GER",Bonussekunder = new int[]{18,0,0,0,0,18}},
             new Tävlande() {Namn ="STEPHEN Elizabeth",Land="USA",Bonussekunder = new int[]{17,0,0,0,0,17}},
             new Tävlande() {Namn ="FESSEL Nicole",Land="GER",Bonussekunder = new int[]{16,0,0,0,0,16}},
             new Tävlande() {Namn ="SLIND Silje Oeyre",Land="NOR",Bonussekunder = new int[]{15,0,0,0,0,15}},
             new Tävlande() {Namn ="SAARINEN Aino-Kaisa",Land="FIN",Bonussekunder = new int[]{14,0,0,0,0,14}},
             new Tävlande() {Namn ="HARSEM Kathrine Rolsted",Land="NOR",Bonussekunder = new int[]{13,0,0,0,0,13}},
             new Tävlande() {Namn ="DEBERTOLIS Ilaria",Land="ITA",Bonussekunder = new int[]{12,0,0,0,0,12}},
             new Tävlande() {Namn ="KALSINA Polina",Land="RUS",Bonussekunder = new int[]{11,0,0,0,0,11}},
             new Tävlande() {Namn ="BROCARD Elisa",Land="ITA",Bonussekunder = new int[]{10,0,0,0,0,10}},
             new Tävlande() {Namn ="SOBOLEVA Elena",Land="RUS",Bonussekunder = new int[]{9,0,0,0,0,9}},
             new Tävlande() {Namn ="WIKEN Emma",Land="SWE",Bonussekunder = new int[]{8,0,0,0,0,8}},
             new Tävlande() {Namn ="DE MARTIN TOPRANIN Virginia",Land="ITA",Bonussekunder = new int[]{7,0,0,0,0,7}},
             new Tävlande() {Namn ="SETTLIN Evelina",Land="SWE",Bonussekunder = new int[]{6,0,0,0,0,6}},
             new Tävlande() {Namn ="GUSCHINA Mariya",Land="RUS",Bonussekunder = new int[]{5,0,0,0,0,5}},
             new Tävlande() {Namn ="NORDSTROEM Maria",Land="SWE",Bonussekunder = new int[]{4,0,0,0,0,4}},
             new Tävlande() {Namn ="BRENNAN Rosie",Land="USA",Bonussekunder = new int[]{3,0,0,0,0,3}},
             new Tävlande() {Namn ="STUERZ Giulia",Land="ITA",Bonussekunder = new int[]{2,0,0,0,0,2}},
             new Tävlande() {Namn ="ZHAMBALOVA Alisa",Land="RUS",Bonussekunder = new int[]{1,0,0,0,0,1}}
             };

            int index = 1;
            foreach (Tävlande current in startlista)
            {
                lstBonus.Items.Add($"{index}. {current.Namn} {current.Land}");
                index++;
            }
            // ett sätt att lägga till i listbox
            //for (int i = 0; i < startlista.Count; i++)
            //{

            //    lstBonus.Items.Add(startlista[i]);
            //}

        }
  
            
        
    }
}
