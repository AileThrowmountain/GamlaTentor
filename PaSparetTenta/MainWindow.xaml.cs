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

namespace PaSparetTenta
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

        Programme programme = new Programme();
        private void buttonGuess_Click(object sender, RoutedEventArgs e)
        {
            string answerOne = "Etna";
            string answerTwo = "3";


            if (textBoxA1.Text == answerOne && textBoxA2.Text == answerTwo)
            {
                labelNmbrofPoint.Content = "3";
            }
            else if (textBoxA1.Text == answerOne)
            {
                labelNmbrofPoint.Content = "1";
            }
            else if (textBoxA1.Text == answerTwo)
            {
                labelNmbrofPoint.Content = "1";
            }
            else
            {
                labelNmbrofPoint.Content = "0";
            }
        }

        private void buttonlst_Click(object sender, RoutedEventArgs e)
        {
            programme.GetUnansweredQuestions();
        }
    }
}
