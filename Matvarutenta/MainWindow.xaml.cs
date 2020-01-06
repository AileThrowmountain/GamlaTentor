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

namespace Matvarutenta
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

        Varukorg varukorg = new Varukorg(); // skapar ett objekt för att kunna anropa List<Varukorg>


        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        { //började med att göra variabler att koppla till textboxarna

            string type = textBoxType.Text;
            int numberOf = int.Parse(textBoxNumber.Text);
            double price = double.Parse(textBoxPris.Text);

            Product minaVaror = new Product(type, numberOf, price); //skapar ett objekt för att kunna lägga till mina värden från textboxarna
            varukorg.AddProduct(minaVaror);

            if (varukorg.IsItToMuch(varukorg.GetTotalSum(), CountProducts()) == true)
            {
                MessageBox.Show("Du har överstigit din budget, prova lägg tillbaka en vara");
                varukorg.varulista.Remove(minaVaror);
            }

            labelSUMMAN.Content = ($"{varukorg.GetTotalSum():C}");
            labelnumberofPShow.Content = ($"{CountProducts()}");
            listBoxGroceries.ItemsSource = null;
            listBoxGroceries.ItemsSource = varukorg.varulista;

        }
        public int CountProducts()// gör en metod för att räkna antalvaror i varukorgen
        {
            int number = 0;
            foreach (Product product in varukorg.varulista)
            {

                number += product.NumberOf; // antal av varje varor ska adderas, tilldelas int number.
                
            }
            return number;
        }
        Product selectedProduct = new Product();
        private void buttonRemove_Click(object sender, RoutedEventArgs e)
        {
            selectedProduct = (Product)listBoxGroceries.SelectedItem;
            varukorg.varulista.Remove(selectedProduct);
            listBoxGroceries.ItemsSource = null;
            listBoxGroceries.ItemsSource = varukorg.varulista;

            labelSUMMAN.Content = ($"{varukorg.GetTotalSum():C}");
            labelnumberofPShow.Content = ($"{CountProducts()}");

        }
    }
}
