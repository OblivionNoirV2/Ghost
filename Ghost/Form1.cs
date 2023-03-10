using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
         
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Calculate the padding size based on 10% of the form size
            int paddingSize = (int)(0.1 * Math.Min(this.ClientSize.Width, this.ClientSize.Height));

            // Set the Margin property of the table layout panel to the calculated padding size
            grid.Padding = new Padding(paddingSize);
        }

        private void grid_Paint(object sender, PaintEventArgs e)
        {

        }
        
        /*  General code to swap buttons
         *  Button buttonTopLeft = tableLayoutPanel1.GetControlFromPosition(0, 0) as Button;
            Button buttonBottomRight = tableLayoutPanel1.GetControlFromPosition(3, 3) as Button;

            // Swap the positions of the buttons in the table layout panel
            tableLayoutPanel1.Controls.Remove(buttonTopLeft);
            tableLayoutPanel1.Controls.Remove(buttonBottomRight);
            tableLayoutPanel1.Controls.Add(buttonBottomRight, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonTopLeft, 3, 3);
        }
         * 
         * 
         */
    }
}
