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

namespace Eggtenta
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
        {
            double egg = 3.56;
            int antalegg = int.Parse(textBoxantalagg.Text);

            int antalkartonger = antalegg / 12;
            int antalaggattfakturera = antalkartonger * 12;
            double pris = antalaggattfakturera * egg;

            textBlocktext.Text = $"Du ska leverera {antalkartonger} st kartonger till ett pris av {pris} kronor";

        }

        private void btncrash_Click(object sender, RoutedEventArgs e)
        {


            bool[] isBroken = new bool[] { true, true, true, false, true, false,
                false, true, true, false, true, true, false, false, true, true,
                false, true, false, false, true, false, true, true, true, true,
                false, false, false, false, false, false, false, true, false,
                false, true, false, false, true, false, true, true, true, false,
                true, false, true, false, true, true, true, false, true, false,
                false, false, false, false, false, false, false, true, false,
                true, false, false, true, false, false, false, true, true, false,
                false, true, true, false, true, true, false, false, true, true,
                true, false, false, false, false, true };

            int whole = 0;
            int broken = 0;

            foreach (var egg in isBroken)
            {

                if (egg == true)
                {
                    broken++;
                }
                else
                {
                    whole++;
                }

            };
            int alltheeggs = broken + whole;

            MessageBox.Show($"Av {alltheeggs} är det {broken} som är trasiga och {whole} som är hela.");
        }

        private void btncount_Click(object sender, RoutedEventArgs e)
        {
            int count = CountEggs(123);
        }
        public int CountEggs(int ID123)
        {
            int raknaegg = 0; //variabel för att räkna äggen när loopen går igenom listan
            List<string> pinkCodes = new List<string>() { "1SE123-2", "0SE675-6", //skapar en list och tillger dess innehåll.
                "2SE122-4", "0SE234-1", "0SE234-5", "2SE564-4", "0SE234-2",
                "1SE564-6", "2SE144-5", "0SE675-1", "1SE144-1", "2SE144-3",
                "1SE123-4", "2SE122-2", "1SE122-6", "0SE234-2", "2SE123-3",
                "1SE234-3", "1SE123-6", "1SE123-4", "0SE122-2", "1SE144-3",
                "0SE234-4", "0SE564-1", "0SE234-4", "2SE144-3", "2SE122-3",
                "1SE234-3", "1SE123-4", "1SE564-5", "1SE123-1", "2SE122-6",
                "0SE123-6", "1SE564-6", "1SE234-5", "1SE564-6", "2SE234-2",
                "1SE234-3", "0SE234-3", "2SE122-5", "2SE234-2", "2SE144-2",
                "2SE564-5", "1SE144-5", "1SE675-4", "1SE123-6", "2SE564-6",
                "1SE122-6", "1SE122-5", "2SE122-2", "1SE234-2", "0SE675-5",
                "2SE122-4", "1SE234-6", "0SE564-4", "1SE564-6", "2SE675-3",
                "1SE144-4", "2SE564-5", "0SE564-1", "1SE564-4", "1SE123-4",
                "1SE564-6", "2SE122-2", "1SE564-5", "2SE234-4", "1SE564-4",
                "2SE122-1", "2SE123-3", "2SE564-2", "2SE234-4", "1SE144-1",
                "1SE675-1", "0SE144-1", "2SE123-6", "0SE123-5", "2SE144-6",
                "0SE144-6", "1SE122-4", "1SE675-6", "0SE122-6", "2SE144-2",
                "2SE122-3", "1SE234-5", "1SE564-2", "1SE144-5", "0SE144-1",
                "1SE144-3", "1SE122-4", "1SE123-1" };

            foreach (string item in pinkCodes)
            {

                string producer = item[3].ToString() + item[4].ToString() + item[5].ToString();
                if (producer == ID123.ToString())
                {
                    raknaegg++;
                }

            }
            return raknaegg;

        }

        private void buttonMoveIn_Click(object sender, RoutedEventArgs e)
        {
            HenHouse henHouse = new HenHouse(250);
        }

        private void buttonLayEgg_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
