using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RocheColinProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // Variables
        int plyTrn;

        // Initialized Variables
        int ply1Score = 0;
        int ply2Score = 0;
        int maxScore = 5;

        public MainPage()
        {
            this.InitializeComponent();
        }

        // Player 1 - first turn, is 'X's
        // Player 2 - second turn, is 'O's
        private void Click1(object sender, RoutedEventArgs e)
        {   if (ply1Score < maxScore || ply2Score < maxScore)
            {
                if (plyTrn == 0)
                {
                    Square_1.Content = "X";
                    plyTrn++;
                }
                else if (plyTrn == 1)
                {
                    Square_1.Content = "O";
                    plyTrn--;
                }

                Square_1.IsEnabled = false;

                result();
            }
            if (ply1Score == maxScore || ply2Score == maxScore)
            {
                Square_1.Content = "";
                Square_1.IsEnabled = true;
            }
        }

        private void Click2(object sender, RoutedEventArgs e)
        {
            if (ply1Score < maxScore || ply2Score < maxScore)
            {
                if (plyTrn == 0)
                {
                    Square_2.Content = "X";
                    plyTrn++;
                }
                else if (plyTrn == 1)
                {
                    Square_2.Content = "O";
                    plyTrn--;
                }

                Square_2.IsEnabled = false;

                result();
            }
            if (ply1Score == maxScore || ply2Score == maxScore)
            {
                Square_2.Content = "";
                Square_2.IsEnabled = true;
            }
        }

        private void Click3(object sender, RoutedEventArgs e)
        {
            if (ply1Score < maxScore || ply2Score < maxScore)
            {
                if (plyTrn == 0)
                {
                    Square_3.Content = "X";
                    plyTrn++;
                }
                else if (plyTrn == 1)
                {
                    Square_3.Content = "O";
                    plyTrn--;
                }

                Square_3.IsEnabled = false;

                result();
            }
            if (ply1Score == maxScore || ply2Score == maxScore)
            {
                Square_3.Content = "";
                Square_3.IsEnabled = true;
            }
        }

        private void Click4(object sender, RoutedEventArgs e)
        {
            if (ply1Score < maxScore || ply2Score < maxScore)
            {
                if (plyTrn == 0)
                {
                    Square_4.Content = "X";
                    plyTrn++;
                }
                else if (plyTrn == 1)
                {
                    Square_4.Content = "O";
                    plyTrn--;
                }

                Square_4.IsEnabled = false;

                result();
            }
            if (ply1Score == maxScore || ply2Score == maxScore)
            {
                Square_4.Content = "";
                Square_4.IsEnabled = true;
            }
        }

        private void Click5(object sender, RoutedEventArgs e)
        {
            if (ply1Score < maxScore || ply2Score < maxScore)
            {
                if (plyTrn == 0)
                {
                    Square_5.Content = "X";
                    plyTrn++;
                }
                else if (plyTrn == 1)
                {
                    Square_5.Content = "O";
                    plyTrn--;
                }

                Square_5.IsEnabled = false;

                result();
            }
            if (ply1Score == maxScore || ply2Score == maxScore)
            {
                Square_5.Content = "";
                Square_5.IsEnabled = true;
            }
        }

        private void Click6(object sender, RoutedEventArgs e)
        {
            if (ply1Score < maxScore || ply2Score < maxScore)
            {
                if (plyTrn == 0)
                {
                    Square_6.Content = "X";
                    plyTrn++;
                }
                else if (plyTrn == 1)
                {
                    Square_6.Content = "O";
                    plyTrn--;
                }

                Square_6.IsEnabled = false;

                result();
            }
            if (ply1Score == maxScore || ply2Score == maxScore)
            {
                Square_6.Content = "";
                Square_6.IsEnabled = true;
            }
        }

        private void Click7(object sender, RoutedEventArgs e)
        {
            if (ply1Score < maxScore || ply2Score < maxScore)
            {
                if (plyTrn == 0)
                {
                    Square_7.Content = "X";
                    plyTrn++;
                }
                else if (plyTrn == 1)
                {
                    Square_7.Content = "O";
                    plyTrn--;
                }

                Square_7.IsEnabled = false;

                result();
            }
            if (ply1Score == maxScore || ply2Score == maxScore)
            {
                Square_7.Content = "";
                Square_7.IsEnabled = true;
            }
        }

        private void Click8(object sender, RoutedEventArgs e)
        {
            if (ply1Score < maxScore || ply2Score < maxScore)
            {
                if (plyTrn == 0)
                {
                    Square_8.Content = "X";
                    plyTrn++;
                }
                else if (plyTrn == 1)
                {
                    Square_8.Content = "O";
                    plyTrn--;
                }

                Square_8.IsEnabled = false;

                result();
            }
            if (ply1Score == maxScore || ply2Score == maxScore)
            {
                Square_8.Content = "";
                Square_8.IsEnabled = true;
            }
        }

        private void Click9(object sender, RoutedEventArgs e)
        {
            if (ply1Score < maxScore || ply2Score < maxScore)
            {
                if (plyTrn == 0)
                {
                    Square_9.Content = "X";
                    plyTrn++;
                }
                else if (plyTrn == 1)
                {
                    Square_9.Content = "O";
                    plyTrn--;
                }

                Square_9.IsEnabled = false;

                result();
            }
            if (ply1Score == maxScore || ply2Score == maxScore)
            {
                Square_9.Content = "";
                Square_9.IsEnabled = true;
            }
        }

        // How Player goes to next turn
        private void nextRound(object sender, RoutedEventArgs e)
        {
            Square_1.Content = "";
            Square_1.IsEnabled = true;
            Square_2.Content = "";
            Square_2.IsEnabled = true;
            Square_3.Content = "";
            Square_3.IsEnabled = true;
            Square_4.Content = "";
            Square_4.IsEnabled = true;
            Square_5.Content = "";
            Square_5.IsEnabled = true;
            Square_6.Content = "";
            Square_6.IsEnabled = true;
            Square_7.Content = "";
            Square_7.IsEnabled = true;
            Square_8.Content = "";
            Square_8.IsEnabled = true;
            Square_9.Content = "";
            Square_9.IsEnabled = true;
            resultText.Text = "";

            plyTrn = 0;
        }

        // Result is called on all Click statement to check if someone is the Winner

        public void result()
        {
            if(ply1Score < maxScore)
            {
                // If statement to check if Player 1 has won
                if (Square_1.Content == "X" && Square_4.Content == "X" && Square_7.Content == "X"
               || Square_2.Content == "X" && Square_5.Content == "X" && Square_8.Content == "X"
               || Square_3.Content == "X" && Square_6.Content == "X" && Square_9.Content == "X"
               || Square_1.Content == "X" && Square_2.Content == "X" && Square_3.Content == "X"
               || Square_4.Content == "X" && Square_5.Content == "X" && Square_6.Content == "X"
               || Square_7.Content == "X" && Square_8.Content == "X" && Square_9.Content == "X"
               || Square_1.Content == "X" && Square_5.Content == "X" && Square_9.Content == "X"
               || Square_3.Content == "X" && Square_5.Content == "X" && Square_7.Content == "X")
                {
                    if (ply1Score == 0)
                    {
                        Score_1.Text = "1";
                    }
                    if (ply1Score == 1)
                    {
                        Score_1.Text = "2";
                    }
                    if (ply1Score == 2)
                    {
                        Score_1.Text = "3";
                    }
                    if (ply1Score == 3)
                    {
                        Score_1.Text = "4";
                    }
                    if (ply1Score == 4)
                    {
                        Score_1.Text = "5";
                    }

                    resultText.Text = "Player 1 has won this Game";

                    Square_1.IsEnabled = false;
                    ply1Score++;
                    plyTrn--;

                }
            }

            if (ply1Score == maxScore)
            {
                resultText.Text = "Congratulations Player 1 has won the game";
            }

            // If statement to check if Player 2 has won

            if ((ply1Score < maxScore))
            {
                if (Square_1.Content == "O" && Square_4.Content == "O" && Square_7.Content == "O"
                   || Square_2.Content == "O" && Square_5.Content == "O" && Square_8.Content == "O"
                   || Square_3.Content == "O" && Square_6.Content == "O" && Square_9.Content == "O"
                   || Square_1.Content == "O" && Square_2.Content == "O" && Square_3.Content == "O"
                   || Square_4.Content == "O" && Square_5.Content == "O" && Square_6.Content == "O"
                   || Square_7.Content == "O" && Square_8.Content == "O" && Square_9.Content == "O"
                   || Square_1.Content == "O" && Square_5.Content == "O" && Square_9.Content == "O"
                   || Square_3.Content == "O" && Square_5.Content == "O" && Square_7.Content == "O")
                {
                    if (ply2Score == 0)
                    {
                        Score_2.Text = "1";
                    }
                    if (ply2Score == 1)
                    {
                        Score_2.Text = "2";
                    }
                    if (ply2Score == 2)
                    {
                        Score_2.Text = "3";
                    }
                    if (ply2Score == 3)
                    {
                        Score_2.Text = "4";
                    }
                    if (ply2Score == 4)
                    {
                        Score_2.Text = "5";
                    }

                    resultText.Text = "Player 2 has won this Game";

                    Square_1.IsEnabled = false;
                    ply2Score++;

                    if (ply2Score == maxScore)
                    {
                        resultText.Text = "Congratulations Player 2 has won the game";
                    }
                }
            }

            if (ply2Score == maxScore)
            {
                resultText.Text = "Congratulations Player 2 has won the game";
            }
        }

        // How Player starts a new game
        private void newGame(object sender, RoutedEventArgs e)
        {
            Square_1.Content = "";
            Square_1.IsEnabled = true;
            Square_2.Content = "";
            Square_2.IsEnabled = true;
            Square_3.Content = "";
            Square_3.IsEnabled = true;
            Square_4.Content = "";
            Square_4.IsEnabled = true;
            Square_5.Content = "";
            Square_5.IsEnabled = true;
            Square_6.Content = "";
            Square_6.IsEnabled = true;
            Square_7.Content = "";
            Square_7.IsEnabled = true;
            Square_8.Content = "";
            Square_8.IsEnabled = true;
            Square_9.Content = "";
            Square_9.IsEnabled = true;
            resultText.Text = "";

            ply1Score = 0;
            Score_1.Text = "";
            ply2Score = 0;
            Score_2.Text = "";

            plyTrn = 0;
        }
    }
}
