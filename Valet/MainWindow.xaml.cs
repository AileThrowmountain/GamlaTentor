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

namespace Valet
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
        public VoteCounter voteCounter = new VoteCounter();

        int counterNo;
        int counterYes;
        int counterNoOppinion;

        public void btnVote_Click(object sender, RoutedEventArgs e)
        {
            
            if (radioBtnNo.IsChecked == true)
            {
                counterNo++;
            }
            else if (radioBtnYes.IsChecked == true)
            {
                counterYes++;
            }
            else if (radioBtnNoOppinion.IsChecked == true)
            {
                counterNoOppinion++;
            }

        }

        private void buttonPresent_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(voteCounter.VoteCount(counterNo, counterYes, counterNoOppinion));
        }
    
    }
}
