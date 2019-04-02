/*
 * Created by: Logan Cantin 
 * Created on: April 2, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
 * This program changes the background color of all non-button objects in the form
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

namespace ForeachControlLoganC
{
    public partial class frmForeach : Form
    {
        public frmForeach()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            // Turning all objects except labels red
            foreach (Control aControlObject in this.Controls)
            {
                //Checking if its a label
                if (aControlObject.GetType() == typeof(Button))
                    continue;
                //not a label, so change color
                aControlObject.BackColor = Color.Red;
            }
        }

        // Same structure as above
        private void btnGreen_Click(object sender, EventArgs e)
        {
            foreach (Control aControlObject in this.Controls)
            {
                if (aControlObject.GetType() == typeof(Button))
                    continue;
                aControlObject.BackColor = Color.Green;
            }
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            foreach (Control aControlObject in this.Controls)
            {
                if (aControlObject.GetType() == typeof(Button))
                    continue;
                aControlObject.BackColor = Color.Blue;
            }
        }
    }
}
