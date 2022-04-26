using System;
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
    /// Interaction logic for TicTacToeGame.xaml
    /// </summary>
    public partial class TicTacToeGame : Window
    {
        private readonly Dictionary<Player, ImageSource> imageSources = new()
        {
            { Player.X, new BitmapImage(new Uri("pack://application:,,,/Assets/X15.png")) },
            { Player.O, new BitmapImage(new Uri("pack://application:,,,/Assets/O15.png")) }
        };


        private Image[,] imageControls = new Image[3, 3];
        private GameState gameState = new GameState();

        private void SetupGameGrid()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Image imageControl = new Image();
                    GameGrid.Children.Add(imageControl);
                    imageControls[r, c] = imageControl;
                }
            }
        }

        private void OnMoveMade(int r, int c)
        {
            Player player = gameState.GameGrid[r, c];
            imageControls[r, c].Source = imageSources[player];
            PlayerImage.Source = imageSources[gameState.CurrentPlayer];
        }

        private async void OnGameEnded(GameResult gameResult)
        {
            await Task.Delay(100);
            if (gameResult.Winner == Player.None)
            {
                TransitionToEndScreen("It's a tie!", null);
            }
            else
            {
                TransitionToEndScreen("Winner: ", imageSources[gameResult.Winner]);
            }
            using (StreamWriter writer = new StreamWriter("TicTacToeScoreboard.txt"))
            {
                writer.WriteLine(gameState.AmountGamesPlayed);
            }
            }
        private void TransitionToGameScreen()
        {
            EndScreen.Visibility = Visibility.Hidden;
            TurnPanel.Visibility = Visibility.Visible;
            GameCanvas.Visibility = Visibility.Visible; 
        }
        private void OnGameRestarted()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    imageControls[r, c].Source = null;
                }
            }
            PlayerImage.Source = imageSources[gameState.CurrentPlayer];
            TransitionToGameScreen();
        }

        private void TransitionToEndScreen(string text, ImageSource winnerImage)
        {
            TurnPanel.Visibility = Visibility.Hidden;
            GameCanvas.Visibility = Visibility.Hidden;
            ResultText.Text = text;
            WinnerImage.Source = winnerImage;
            EndScreen.Visibility = Visibility.Visible;
        }

        public TicTacToeGame()
        {
            InitializeComponent();
            SetupGameGrid();

            gameState.MoveMade += OnMoveMade;
            gameState.GameEnded += OnGameEnded;
            gameState.GameRestarted += OnGameRestarted;
        }

        private void GameGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            double squareSize = GameGrid.Width / 3;
            Point clickPosition = e.GetPosition(GameGrid);
            int row = (int)(clickPosition.Y / squareSize);
            int col = (int)(clickPosition.X / squareSize);
            gameState.MakeMove(row, col);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gameState.Reset();

            

        }

        private void HelpClick(object sender, RoutedEventArgs e)
        {
            TicTacToeHelp helpWindow = new TicTacToeHelp();
            helpWindow.Show();
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Visibility = Visibility.Visible;
            this.Close();
        }
    }
}
