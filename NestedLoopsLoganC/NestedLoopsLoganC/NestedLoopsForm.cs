/*
 * Created by: Logan Cantin
 * Created on: March 2, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Alphabet Nested Loops
 * This program this program prints out all possible combinations of 2 alphabet characters
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

namespace NestedLoopsLoganC
{
    public partial class frmNestedLoops : Form
    {
        public frmNestedLoops()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Clear all characters from the list box
            lstList.Items.Clear();

            // Uppercase character
            for (int i = 65; i < 92; i++)
            {
                //Lowercase character
                for (int j = 97; j < 123; j++)
                {
                    // Putting it together
                    lstList.Items.Add(Convert.ToString((char)i) + " -> " + Convert.ToString((char)j));
                }
            }
        }
    }
}
