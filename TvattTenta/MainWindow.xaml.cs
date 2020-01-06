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
            Person person = new Person();
            person.NewWardrobe();
        }
        

        int[] washTemp = new int[] { 30, 60, 40, 30, 40, 60, 60 };


        public int LetaIgenom(int[] array)
        {
            int lowestTemp = array[0];
            //jag har ett värde som är din lägsta temp..
            //och den ska bara bytas ut OM tempens värde är lägre

            foreach (int temperature in array)
            {
                if (temperature < lowestTemp)
                {
                    lowestTemp = temperature;

                }
            }

            return lowestTemp;

        }
        public int LetaIgenom(int[] array, int highestTemp)
        {

            //jag har ett värde som är din högsta temp..
            //och den ska bara bytas ut OM tempens värde är högre

            foreach (int temperature in array)
            {
                if (temperature > highestTemp)
                {
                    highestTemp = temperature;

                }
            }

            return highestTemp;

        }

        public int StörstaTvättkorgen(int[] array)
        {
            int sextioGrader = 0;
            int trettioGrader = 0;
            int fyrtioGrader = 0;

            foreach (int i in array)
            {
                if (i == 60)
                {
                    sextioGrader++;
                }
                else if (i == 30)
                {
                    trettioGrader++;
                }
                else
                {
                    fyrtioGrader++;
                }
            }
            
            if (sextioGrader >= fyrtioGrader && sextioGrader >= trettioGrader)
            { 
                return 60; 
            }

            if (fyrtioGrader >= trettioGrader)

            { 
                return 40; 
            }

            else
            { 
                return 30; 
            }
           
         

        }
        private void button_Click(object sender, RoutedEventArgs e)
        {

            int highestTemp = washTemp[0];
            LetaIgenom(washTemp);
            LetaIgenom(washTemp, highestTemp);
            StörstaTvättkorgen(washTemp);

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Person personenslista = new Person();
            listBoxKläder.ItemsSource = null;
            listBoxKläder.ItemsSource = personenslista.CollectionFriday;
            listBoxKläder.ItemsSource = personenslista.CollectionSaturday;

        }

        //måste antagligen göra en metod med en lista där kläderna läggs till i klassen.
    }
}

