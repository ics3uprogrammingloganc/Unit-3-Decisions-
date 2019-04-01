/*
 * Created by: Logan Cantin
 * Created on: March 31, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22 - Perfect Squares
 * This program shows all perfect squares from 1 to the user's entered number.
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

namespace PerfectSquaresLoganC
{
    public partial class frmPerfectSquares : Form
    {
        public frmPerfectSquares()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Clearing list box
            lstSquares.Items.Clear();

            // Getting user's input value
            int userValue = Convert.ToInt32(nudInput.Value);

            // Setting counter
            int counter = 1;

            // Setting the ending value
            int endingValue = (int)Math.Floor(Math.Sqrt(userValue));

            // Outputting all squares
            while(counter <= endingValue)
            {
                // output the square of the counter, and increment the counter
                lstSquares.Items.Add(Convert.ToString(Math.Pow(counter, 2)) + " is a perfect square.");
                counter++;
            }
        }
    }
}
