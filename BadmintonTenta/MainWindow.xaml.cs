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

namespace BadmintonTenta
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
        Match match = new Match();
        private void buttonBalls_Click(object sender, RoutedEventArgs e)
        {
            float ballsPerPack = float.Parse(textBoxBallsPerBox.Text);
            float numberOfGames = float.Parse(textBoxGames.Text);
            MessageBox.Show($"Du måste köpa {NumberOfBallPacks(ballsPerPack, numberOfGames)}");
        }

        public int NumberOfBallPacks(float ballsPerPack, float numberOfGames)
        {
            float ballpacks = (numberOfGames * 3) / ballsPerPack;
            
            return (int)Math.Ceiling(ballpacks);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Person Spelare1 = new Person("Humle", 18, null, 0, false);
            Person Spelare2 = new Person("Dumle", 18, null, 0, false);
            match = new Match(Spelare1, Spelare2, 1);
            UpdateUI(match.Spelare1.Poäng, match.Spelare2.Poäng, match.Spelare1.AntalVunnaSet, match.Spelare2.AntalVunnaSet);



        }
        public void UpdateUI(int spelarPoäng1, int spelarPoäng2, int spelarSet1, int spelarSet2)
        {
            labelPointsPL1.Content = spelarPoäng1;
            labelPointsPL2.Content = spelarPoäng2;
            labelSetPL1.Content = spelarSet1;
            labelSetPL2.Content = spelarSet2;

        }

        private void labelPointsPL1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
            match.GePoäng(match.Spelare1, match.Spelare2);
            UpdateUI(match.Spelare1.Poäng, match.Spelare2.Poäng, match.Spelare1.AntalVunnaSet, match.Spelare2.AntalVunnaSet);

            

        }

        private void labelPointsPL2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            match.GePoäng(match.Spelare2, match.Spelare1);
            UpdateUI(match.Spelare1.Poäng, match.Spelare2.Poäng, match.Spelare1.AntalVunnaSet, match.Spelare2.AntalVunnaSet);

        }
    }
}
