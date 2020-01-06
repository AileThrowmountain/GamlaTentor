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

namespace SpelTenta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SlumpCard();
        }

        Kortlek kortlek = new Kortlek();

        // Initialize the string array
        string[] strStrings = new string[] { "O", "$", "#" };
        // Choose a random slogan
        Random SlumpaFramEnAvMinaSymboler = new Random();

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            string A = strStrings[SlumpaFramEnAvMinaSymboler.Next(strStrings.Length)];
            string B = strStrings[SlumpaFramEnAvMinaSymboler.Next(strStrings.Length)];
            string C = strStrings[SlumpaFramEnAvMinaSymboler.Next(strStrings.Length)];

            labelA.Content = A;
            labelB.Content = B;
            labelC.Content = C;

            JackPot(A, B, C);
        }
        public void JackPot(string A, string B, string C)
        {

            if (A == "O" && B == "O" && C == "O")
            {
                MessageBox.Show("JACKPOT!!");
            }
            if (A == "#" && B == "#" && C == "#")
            {
                MessageBox.Show("JACKPOT!!");
            }
            if (A == "$" && B == "$" && C == "$")
            {
                MessageBox.Show("JACKPOT!!");
            }

        }
        Kort kort = null;
        public void SlumpCard()
        {
            kortlek.SkapaKortlek();
            kortlek.DraSlumpmässigtKort();
            kort = kortlek.DraSlumpmässigtKort();
            labelSvit.Content = kort.Svit;
            labelTyp.Content = kort.Korttyp;
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SlumpCard();

        }
        int antalratt = 0;
        int personbasta = 0;
        private void buttonHigher_Click(object sender, RoutedEventArgs e)
        {
            Kort nyttKort = kortlek.DraSlumpmässigtKort();
           
            if (nyttKort.Värde > kort.Värde)
            {
                MessageBox.Show("Rätt");
                RaknaAllaRatt();
                
            }
            
            else
            {
                antalratt = 0;
                labelARShow.Content = antalratt;
                
            }
            kort = nyttKort;
            labelSvit.Content = kort.Svit;
            labelTyp.Content = kort.Korttyp;
            

        }

        private void buttonLower_Click(object sender, RoutedEventArgs e)
        {
            Kort nyttKort = kortlek.DraSlumpmässigtKort();
            if (nyttKort.Värde < kort.Värde)
            {
                MessageBox.Show("Rätt");
                RaknaAllaRatt();
            }
            else
            {
                antalratt = 0;
                labelARShow.Content = antalratt;
            }
            kort = nyttKort;
            labelSvit.Content = kort.Svit;
            labelTyp.Content = kort.Korttyp;
            
        }
        public void RaknaAllaRatt()
        {
            antalratt++;
            if(antalratt > personbasta)
            {
                personbasta = antalratt;
            }
            labelARShow.Content = antalratt;
            labelPBShow.Content = personbasta;
        }

    }
}

 