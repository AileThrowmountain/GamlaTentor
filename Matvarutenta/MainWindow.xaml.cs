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

            listBoxGroceries.ItemsSource = null;
            listBoxGroceries.ItemsSource = varukorg.varulista;

            labelSUMMAN.Content = ($"{varukorg.GetTotalSum():C}");


        }
    }
}
