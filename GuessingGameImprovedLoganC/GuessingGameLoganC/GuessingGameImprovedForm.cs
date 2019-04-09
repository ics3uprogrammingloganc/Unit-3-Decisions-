/*
* Created by: Logan C  
* Created on: April 9, 2019
* Created for: ICS3U Programming
* Daily Assignment – Day #17 - Number guessing game
* This program lets people guess a random number. It lets you know if you got it correct or not.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GuessingGameLoganC
{
    public partial class frmGuessingGame : Form
    {
        public int SECRET_NUM;
        Random randomIntergerGenerator = new Random();


        public frmGuessingGame()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Convert text in text box to interger
            int userGuess = Convert.ToInt32(tbxGuess.Text);

            // Is user's guess correct?
            if (userGuess == SECRET_NUM)
            {
                // User wins
                lblResult.Text = "You guessed correctly!";        
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer("correct.mp3");
                //player.Play();
                UserWin();
            }
            else
            {
                //user Loses
                lblResult.Text = "You guessed incorrectly.";
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer("incorrect.mp3");
                //player.Play();
            }
        }

        //User wins. Disable all controls except the play button
        private void UserWin()
        {
            foreach (Control control in this.Controls)
            {
                if (control.Name != "btnPlay")
                {
                    control.Enabled = false;
                }

            }
            btnPlay.Enabled = true;
        }

        // Play button was clicked. enable all controls, disable play button, and generate a new secret number
        private void btnPlay_Click(object sender, EventArgs e)
        {
            SECRET_NUM = randomIntergerGenerator.Next(1, 11);
            foreach (Control control in this.Controls)
            {
                if (control.Name != "btnPlay")
                {
                    control.Enabled = true;
                }

            }
            btnPlay.Enabled = false;
        }
    }
}
