using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LuckySeven;

namespace MineField
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NewGame();
        }

        // lower and upper bounds for mine gen
        const int MIN = 1;
        const int MAX = 20;

        // Variables

        // tracks where player clicked
        Label boxSelected;

        // track mine location among squares
        int mineLocation;

        // times clicked on a square
        int clickCounter;

        // how many clicks to win
        int winningClicks = 10;

        // how many wins
        int wins;

        // how many games played
        int gamesPlayed;

        // random number gen
        Random randomMine = new Random();

        private void MineLabel_Click(object sender, EventArgs e)
        {
            // increase counter
            clickCounter += 1;

            boxSelected = (Label)sender;

            // flag for if user hit mine
            bool hitMine = boxSelected.TabIndex == mineLocation;

            // user gets winning clicks without hitting mine
            if (clickCounter == winningClicks && hitMine == false)
            {
                boxSelected.BackColor = Color.White;
                UpdateStats("win");
            }

            // user lands on mine
            else if (hitMine)
            {
                Animate.BlinkMine(boxSelected);
                UpdateStats("lose");
            }
            // user doesn't land on mine
            else
            {
                boxSelected.BackColor = Color.White;
                boxSelected.Enabled = false;
            }
        }

        // determines results
        private void UpdateStats(string result)
        {
            gamesPlayed += 1;

            // increment wins if player wins
            if (result == "win") wins += 1;

            // update UI and display game over message
            updateResultsDisplay();
            DisplayGameOver(result);
        }

        private void clearStats()
        {
            // Reset counters and labels
            clickCounter = 0;
            wins = 0;
            gamesPlayed = 0;
            lblWins.Text = "Wins: 0 out of 0";
            lblWinPercent.Text = "0%";
        }

        // handles response dialog messaging
        public void DisplayGameOver(string result)
        {
            DialogResult ResponseDialogResult = MessageBox.Show($"You {result}! Play Again?", "Play Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (ResponseDialogResult == DialogResult.Yes)
            {
                boxSelected.Text = "";
                ResetGame();
            }
            else
            {
                this.Close();
            }
        }

        // updates win and losses on UI
        private void updateResultsDisplay()
        {
            lblWins.Text = ($"Wins: {wins} out of {gamesPlayed}");
            lblWinPercent.Text = HitRate.Calculate(wins, gamesPlayed);
        }

        private void NewGame()
        {
            clearStats();

            Animate.BlinkSquares(tableLayoutPanel1);

            // Generate a random int between 1-20 tand assign to mine variable
            mineLocation = randomMine.Next(MIN, MAX);
        }

        public void ResetGame()
        {
            clickCounter = 0;
            Animate.BlinkSquares(tableLayoutPanel1);

            // Generate a random int between 1-20 tand assign to mine variable
            mineLocation = randomMine.Next(MIN, MAX);
        }

        // menu  difficulty option event handlers
        private void menu_options_easy_Click(object sender, EventArgs e)
        {
            winningClicks = 5;
            menu_options_easy.Checked = true;
            menu_options_medium.Checked = false;
            menu_options_hard.Checked = false;
            NewGame();
        }

        private void menu_options_medium_Click(object sender, EventArgs e)
        {
            winningClicks = 10;
            menu_options_easy.Checked = false;
            menu_options_medium.Checked = true;
            menu_options_hard.Checked = false;
            NewGame();
        }

        private void menu_options_hard_Click(object sender, EventArgs e)
        {
            winningClicks = 15;
            menu_options_easy.Checked = false;
            menu_options_medium.Checked = false;
            menu_options_hard.Checked = true;
            NewGame();
        }

        // show about and how to play
        private void menu_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Minefield \n " +
                "by: William Forbes \n \n" +
                "How to Play: Click the boxes and try not to land on the mine."
            );
        }

        // start new game
        private void menu_file_newGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        // exit app
        private void menu_file_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
