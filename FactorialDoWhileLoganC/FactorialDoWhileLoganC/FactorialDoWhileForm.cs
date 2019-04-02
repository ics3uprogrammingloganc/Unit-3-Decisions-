/*
 * Created by: Logan Cantin
 * Created on: March 31, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program calculates the factorial of an entered number and shows
 * all numbers that were multiplied together.
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

namespace FactorialDoWhileLoganC
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Clear items
            lstDisplay.Items.Clear();

            // Final answer variable
            int finalanswer = 1;

            // Getting user's number
            int userNum = Convert.ToInt32(tbxInput.Text);

            do
            {
                //Updating listbox and multiplying final answer by counter. decrement counter
                lstDisplay.Items.Add(userNum);
                finalanswer *= userNum--;
            } while (userNum > 0); // as long as user number is bigger than 0

            // Display final answer
            lblAnswer.Text = "Answer: " + Convert.ToString(finalanswer);
        }
    }
}
