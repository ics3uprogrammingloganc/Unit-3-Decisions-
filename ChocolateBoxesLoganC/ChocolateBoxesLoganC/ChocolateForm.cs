/*
 * Created by: Logan Cantin
 * Created on: March 25, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program tells the user what prize they win based on the number of boxes that they sold
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

namespace ChocolateBoxesLoganC
{
    public partial class frmChocolate : Form
    {
        public frmChocolate()
        {
            InitializeComponent();
        }

        private void btnReward_Click(object sender, EventArgs e)
        {
            // Make sure that there are no errors
            try
            {
                // Get num boxes sold from the textbox
                int boxesSold = Convert.ToInt32(tbxAnswer.Text);

                if (boxesSold > 20)
                {
                    // The user has sold more than 20 boxes; they win a prize
                    lblReward.Text = "You win a prize!";
                }
                else if (boxesSold > 10)
                {
                    // the user has sold between 11 and 20 boxes inclusive; they win a small prize
                    lblReward.Text = "You win a small prize!";
                }
                else if (boxesSold < 0)
                {
                    // Let user know that their number is out of range
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    // The user sold between 0 and 10 boxes inclusive; they get an honorable mention
                    lblReward.Text = "You get an honorable mention.";
                }
            } 

            // Catching any errors and letting the user know about it.
            catch (FormatException)
            {
                lblReward.Text = "Enter only an interger.";
            }
            catch (OverflowException)
            {
                lblReward.Text = "Enter a reasonably sized number";
            }
            catch (ArgumentOutOfRangeException)
            {
                lblReward.Text = "Please enter a positive number";
            }
           
        }
    }
}
