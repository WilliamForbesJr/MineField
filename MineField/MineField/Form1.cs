using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineField
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Variables

        // tracks where player clicked
        Label lblLabel;

        // track mine location among squares
        int mineLocation;

        // times clicked on a square
        int clickCounter;

        // how many clicks to win
        int winningClicks;

        // how many wins
        int wins;

        // how many games played
        int gamesPlayed;

        // lower and upper bounds for mine gen (needs to be const, will add later)
        int LOWER_BOUNDS, UPPER_BOUNDS;

        // random number gen
        Random rand = new Random();

        private void MineLabel_Click(object sender, EventArgs e)
        {
            // increase counter
            clickCounter += 1;

            // holder label that was clicked
            lblLabel = (Label)sender;

            if (clickCounter == winningClicks)
            {
                if (lblLabel.TabIndex == mineLocation)
                {
                    BlinkMine();
                    gamesPlayed += 1;
                    lblWins.Text = ($"Wins: {wins} out of {gamesPlayed}");
                    lblWinPercent.Text = HitRateCalculation.HitRate(wins, gamesPlayed);

                    DialogResult ResponseDialogResult = MessageBox.Show("You lost. Play Again?", "Play Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (ResponseDialogResult == DialogResult.Yes)
                    {
                        lblLabel.Text = "";
                        ResetGame();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    lblLabel.BackColor = Color.White;
                    gamesPlayed += 1;
                    wins += 1;
                    lblWins.Text = ($"Wins: {wins} out of {gamesPlayed}");
                    lblWinPercent.Text = HitRateCalculation.HitRate(wins, gamesPlayed);

                    DialogResult ResponseDialogResult = MessageBox.Show("You lost. Play Again?", "Play Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (ResponseDialogResult == DialogResult.Yes)
                    {
                        lblLabel.Text = "";
                        ResetGame();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                if (lblLabel.TabIndex == mineLocation)
                {
                    BlinkMine();
                    gamesPlayed += 1;
                    lblWins.Text = ($"Wins: {wins} out of {gamesPlayed}");
                    lblWinPercent.Text = HitRateCalculation.HitRate(wins, gamesPlayed);

                    DialogResult ResponseDialogResult = MessageBox.Show("You lost. Play Again?", "Play Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (ResponseDialogResult == DialogResult.Yes)
                    {
                        lblLabel.Text = "";
                        ResetGame();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else {
                    {
                        lblLabel.BackColor = Color.White;
                        lblLabel.Enabled = false;
                    } }
            }
        }
    }
}
