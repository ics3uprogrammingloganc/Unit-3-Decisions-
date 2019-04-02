/*
 * Created by: Logan Cantin
 * Created on: March 31, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #23 - Sum of Numbers
 * This program sums up all the numbers from 0 to a number the user enters
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

namespace SumofNumbers
{
    public partial class frmSumofNumbers : Form
    {
        public frmSumofNumbers()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Clear the list box
            lstList.Items.Clear();

            // get user num and create a sum
            int userNum = Convert.ToInt32(tbxInput.Text);
            int sum = 0;

            // Add all numbers from 1 to user number to list box and sum
            for (int counter = 1; counter <= userNum; counter++)
            {
                lstList.Items.Add(counter);
                sum += counter;
            }

            //Output answer
            lblSum.Text = "The sum is: " + Convert.ToString(sum);
        }
    }
}
