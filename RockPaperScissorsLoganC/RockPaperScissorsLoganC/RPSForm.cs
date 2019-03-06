using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsLoganC
{
    public partial class frmRPS : Form
    {
        public enum Choice
        {
            ROCK = 1, PAPER, SCISSORS
        }
        public Random randomNumberGenerator;
        public Choice userChoice, compChoice;

        public frmRPS()
        {
            InitializeComponent();
            randomNumberGenerator = new Random();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void grbComputer_Enter(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            // Generate computer's choice and select that radio button
            compChoice = (Choice)randomNumberGenerator.Next(1, 4);
            if (compChoice == Choice.ROCK)
            {
                radCompRock.Select();
            }
            else if (compChoice == Choice.PAPER)
            {
                radCompPaper.Select();
            }
            else
            {
                radCompScissors.Select();
            }

            // Determining who wins
            if (userChoice == compChoice)
            {
                // Tie
                lblWinner.Text = " Tie.";
            }
            // User wins
            else if (userChoice == Choice.ROCK && compChoice == Choice.SCISSORS)
            {
                lblWinner.Text = "You win!";
            }
            else if (userChoice == Choice.SCISSORS && compChoice == Choice.PAPER)
            {
                lblWinner.Text = "You win!";
            }
            else if (userChoice == Choice.PAPER && compChoice == Choice.ROCK)
            {
                lblWinner.Text = "You win!";
            }
            //Computer wins
            else
            {
                lblWinner.Text = " You lose.";
            }

        }

        private void radUserRock_CheckedChanged(object sender, EventArgs e)
        {
            // Change user's choice to ROCK
            userChoice = Choice.ROCK;
        }

        private void radUserPaper_CheckedChanged(object sender, EventArgs e)
        {
            // Change user's choice to PAPER
            userChoice = Choice.PAPER;
        }

        private void radUserScissors_CheckedChanged(object sender, EventArgs e)
        {
            // Change user's choice to SCISSORS
            userChoice = Choice.SCISSORS;
        }
    }
}
