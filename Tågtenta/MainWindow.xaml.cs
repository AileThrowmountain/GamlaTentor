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

namespace Tågtenta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private Wagon wagon;
        //först skapa metod
        //skapa udda och jämna nummer
        //sätestyp
        // anropa metoden där vi räknar sätesplatser


        public MainWindow()
        {
            InitializeComponent();
            InitializeSeats(32);
        }

        public void InitializeSeats(int numberOfSeats)
        {
            wagon = new Wagon(numberOfSeats);
        }

        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {
            int seatNumber = int.Parse(textBoxSeat.Text); //DETTA VAR UPPGIFT NUMMER 1
            if (radioButtonUt.IsChecked == true)
            {
                if (seatNumber >= 9 && seatNumber <= 16) //om numret är större eller lika med 9 eller mindre eller lika med 16
                {
                    MessageBox.Show($"Sittplats nr {seatNumber} gör att du åker framlänges i tåget.");
                }
                else if (seatNumber >= 1 && seatNumber <= 8)
                {
                    MessageBox.Show($"Sittplats nr {seatNumber} gör att du åker baklänges i tåget.");
                }
            }
            else if (radioButtonHem.IsChecked == true)
            {
                if (seatNumber >= 9 && seatNumber <= 16)
                {
                    MessageBox.Show($"Sittplats nr {seatNumber} gör att du åker baklänges i tåget.");
                }
                else if (seatNumber >= 1 && seatNumber <= 8)
                {
                    MessageBox.Show($"Sittplats nr {seatNumber} gör att du åker framlänges i tåget.");
                }
            }

        }
     
        private void buttonSeats_Click(object sender, RoutedEventArgs e)
        {
            listBoxSäten.ItemsSource = wagon.GetSeats(); //för att få tag i listan använder jag field variabeln wagon som är en variabel av klassen Wagon. 
            wagon.FillSeats(); // använder metoden för att gå igenom listan och sätta upptaget/ledigt på platserna
            
        }

        private void buttontravelers_Click(object sender, RoutedEventArgs e)
        {
            listBoxSäten.ItemsSource = null;
            listBoxSäten.ItemsSource = wagon.GetFreeSeats(3);
        }

        private void buttonSätesPar_Click(object sender, RoutedEventArgs e)
        {
            listBoxSätesPar.ItemsSource = null;
            listBoxSätesPar.ItemsSource = wagon.GetFreeSeatPair();
        }
    }
}
