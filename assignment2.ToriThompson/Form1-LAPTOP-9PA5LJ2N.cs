using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2.ToriThompson
{
    public partial class Form1 : Form
    {
        Player player1;
        Player player2;
        Game game1;

        public Form1()
        {
            InitializeComponent();
        }
        public string GenerateHidden(int passedLength)
        {

            string guessWord = "";
            for (int ctr = 0; ctr < passedLength; ctr++)
            {
                if (game1.CurrentWord[ctr] == Char.Parse(" "))
                    guessWord += ' ';
                else
                    guessWord += '-';
            }
            return guessWord;
        }
        public void NewPrize()
        {
            Random randPrize = new Random();
            int prizeAmt = randPrize.Next() % game1.PrizeAmts.Length;
            game1.CurrentPrize = game1.PrizeAmts[prizeAmt];
            switch (game1.CurrentPrize)
            {
                case 2022:
                    prizeWheel.Image = assignment2.ToriThompson.Properties.Resources.wof2022;
                    break;
                case 1000000:
                    prizeWheel.Image = assignment2.ToriThompson.Properties.Resources.wof1mil;
                    break;
                case 500:
                    prizeWheel.Image = assignment2.ToriThompson.Properties.Resources.wof500;
                    break;
                case 600:
                    prizeWheel.Image = assignment2.ToriThompson.Properties.Resources.wof600;
                    break;
                default:
                    prizeWheel.Image = assignment2.ToriThompson.Properties.Resources.wof300;
                    break;
            }
        }
        public void NewGame()
        {
            game1.CurrentWord = "";
            game1.randWord();
            player1.PlayerScore = 0;
            player2.PlayerScore = 0;
            player1Score.Text = "";
            player2Score.Text = "";
            targetWordBox.Text = GenerateHidden(game1.CurrentWord.Length);
        }
        private void startGame_Click(object sender, EventArgs e)
        {
            player1 = new Player(player1Name.Text);
            player2 = new Player(player2Name.Text);
            game1 = new Game();
            targetWordBox.Text = GenerateHidden(game1.CurrentWord.Length);
            NewPrize();
        }

        private void letterGuessBox_TextChanged(object sender, EventArgs e)
        {
            if (letterGuessBox.Text != "")
            {
                char[] compareWord = game1.CurrentWord.ToLower().ToCharArray();
                int ctr = 0, letterReplaced = 0;

                for (; ctr < game1.CurrentWord.Length; ctr++)
                {
                    if (Char.Parse(letterGuessBox.Text.ToLower()) == compareWord[ctr])
                    {
                        targetWordBox.Text = targetWordBox.Text.Remove(ctr, 1);
                        targetWordBox.Text = targetWordBox.Text.Insert(ctr, letterGuessBox.Text);
                        letterReplaced++;
                    }
                }
                if (letterReplaced == 0)
                    MessageBox.Show("That letter is not in the word.");
                else
                {
                    if (game1.PlayerTurn == 0)
                    {
                        player1.PlayerScore += game1.CurrentPrize;
                        MessageBox.Show(player1Name.Text + ", your current score is: " + player1.PlayerScore);
                        player1Score.Text = player1.PlayerScore.ToString();
                    }
                    else
                    {
                        player2.PlayerScore += game1.CurrentPrize;
                        MessageBox.Show(player2Name.Text + ", your current score is: " + player2.PlayerScore);
                        player2Score.Text = player2.PlayerScore.ToString();
                    }
                }
                letterGuessBox.Clear();
                NewPrize();
                if (game1.CurrentWord == targetWordBox.Text)
                {
                    DialogResult dialogResult;

                    if (player1.PlayerScore == player2.PlayerScore)
                        dialogResult = MessageBox.Show("You guessed the word, but you tied!." + " Do you want to play again?",
                                                       "Tied Game", MessageBoxButtons.YesNo);
                    else
                    {
                        if (player1.PlayerScore > player2.PlayerScore)
                        {
                            player1.NumWins += 1;
                            player2.NumLoss += 1;
                            dialogResult = MessageBox.Show("You guessed the word! " + player1Name.Text + " won and has a score of " + player1Score.Text + ". Do you want to play again?",
                                                            "Player 1 Won", MessageBoxButtons.YesNo);
                        }
                        else
                        {
                            player2.NumWins += 1;
                            player1.NumLoss += 1;
                            dialogResult = MessageBox.Show("You guessed the word! " + player2Name.Text + " won and has a score of " + player2Score.Text + ". Do you want to play again?",
                                                            "Player 2 Won", MessageBoxButtons.YesNo);
                        }
                    }
                    if (dialogResult == DialogResult.Yes)
                    {
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show(player1Name.Text + ", you had " + player1.NumWins + " wins and " + player1.NumLoss + " losses. " +
                                         player2Name.Text + ", you had " + player2.NumWins + " wins and " + player2.NumLoss + " losses.");
                        Application.Exit();
                    }
                }
                else
                {
                    if (game1.PlayerTurn == 0)
                    {
                        game1.PlayerTurn++;
                        MessageBox.Show(player2Name.Text + ", it is now your turn. Enter letter in the box provided.");
                    }
                    else
                    {
                        game1.PlayerTurn--;
                        MessageBox.Show(player1Name.Text + ", it is now your turn. Enter letter in the box provided.");
                    }
                }

            }
        }
    }
}
