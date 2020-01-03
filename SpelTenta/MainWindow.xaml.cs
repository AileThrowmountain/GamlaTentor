﻿using System;
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
            
            if (A == "O" && B =="O" && C=="O")
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Kort kort = new Kort();
            kortlek.SkapaKortlek();
            kort.DraSlumpmässigtKort();
        }
    }
}