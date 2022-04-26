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

namespace MultiGameApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public bool dark = true;
        public MainWindow()
        {
            InitializeComponent();
        }

    

        private void PlayTicTacToeButton(object sender, RoutedEventArgs e)
        {
            TicTacToeGame ticWindow = new TicTacToeGame();
            ticWindow.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void PlayConnectFourButton(object sender, RoutedEventArgs e)
        {
            Window2 connectFourWindow = new Window2();
            connectFourWindow.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void PlayTicTacToeScoresButton(object sender, RoutedEventArgs e)
        {
            TicTacToeScores ticScoreWindow = new TicTacToeScores();
            ticScoreWindow.Show();  
        }

        private void ChangeColors(object sender, RoutedEventArgs e)
        {
            
            if (dark)
            {
                MainWindowScreen.Background = new SolidColorBrush(Colors.Azure);
                MainDockPanel.Background = new SolidColorBrush(Colors.LightGray);
                ChangeColorButton.Background = new SolidColorBrush(Colors.LightGray);
                PlayConnectButton.Background = new SolidColorBrush(Colors.LightGray);
                PlayTicButton.Background = new SolidColorBrush(Colors.LightGray);
                TicTacToeScoreButton.Background = new SolidColorBrush(Colors.LightGray);   

                ChangeColorButton.Foreground = new SolidColorBrush(Colors.Black);
                PlayConnectButton.Foreground = new SolidColorBrush(Colors.Black);
                PlayTicButton.Foreground = new SolidColorBrush(Colors.Black);
                TicTacToeScoreButton.Foreground = new SolidColorBrush(Colors.Black);
                dark = false;
            }
            else
            {
                MainWindowScreen.Background = new SolidColorBrush(Color.FromRgb(46, 51, 73));
                MainDockPanel.Background = new SolidColorBrush(Color.FromRgb(24, 30, 54));
                ChangeColorButton.Background = new SolidColorBrush(Color.FromRgb(24, 30, 54));
                PlayConnectButton.Background = new SolidColorBrush(Color.FromRgb(24, 30, 54));
                PlayTicButton.Background = new SolidColorBrush(Color.FromRgb(24, 30, 54));
                TicTacToeScoreButton.Background = new SolidColorBrush(Color.FromRgb(24, 30, 54));

                ChangeColorButton.Foreground = new SolidColorBrush(Color.FromRgb(0, 119, 219));
                PlayConnectButton.Foreground = new SolidColorBrush(Color.FromRgb(0, 119, 219));
                PlayTicButton.Foreground = new SolidColorBrush(Color.FromRgb(0, 119, 219));
                TicTacToeScoreButton.Foreground = new SolidColorBrush(Color.FromRgb(0, 119, 219));
                dark = true;
            }
        }
    }
}
