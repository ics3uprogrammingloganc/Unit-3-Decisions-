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
        public const int SECRET_NUM = 7;

        public frmGuessingGame()
        {
            InitializeComponent();
            pbxImage.Hide();
        }

        private void tbxGuess_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int userGuess = Convert.ToInt32(tbxGuess.Text);

            if (userGuess == SECRET_NUM)
            {
                lblResult.Text = "You guessed correctly!";
                pbxImage.Image = Properties.Resources.checkmark;
                pbxImage.Show();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("correct.mp3");
                player.Play();
            }
            else
            {
                lblResult.Text = "You guessed incorrectly.";
                pbxImage.Image = Properties.Resources.red_x;
                pbxImage.Show();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("incorrect.mp3");
                player.Play();
            }
        }
    }
}
