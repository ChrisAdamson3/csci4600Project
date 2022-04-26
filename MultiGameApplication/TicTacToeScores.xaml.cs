﻿using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace MultiGameApplication
{
    /// <summary>
    /// Interaction logic for TicTacToeScores.xaml
    /// </summary>
    public partial class TicTacToeScores : Window
    {
        public TicTacToeScores()
        {
            InitializeComponent();
            string readText = File.ReadAllText("TicTacToeScoreboard.txt");
            AmountScore.Text = readText;

        }
       
        
    }
}
