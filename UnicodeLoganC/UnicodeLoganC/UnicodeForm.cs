/*
 * Created by: logan Cantin 
 * Created on: March 26th
 * Created for: ICS3U Programming
 * Daily Assignment – Day #24 - Unicode
 * This program outputs all of the uppercase characters and their corresponding unicode values
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

namespace UnicodeLoganC
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Clear all items
            lstList.Items.Clear();

            // Print all characters in this format: <unicode char at counter> -> <counter>
            for (int counter = 65; counter < 91; counter++)
            {
                lstList.Items.Add(Convert.ToString(Char.ConvertFromUtf32(counter)) + " -> " + Convert.ToString(counter));
            }
        }
    }
}
