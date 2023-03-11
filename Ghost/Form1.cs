using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghost
{
    //will have 2 or 3 right next to each other, like a line
    public partial class MainForm : Form
    {
        //x y coordinates for the 4 boxes
        readonly Dictionary<string, Tuple<int, int>> one_coordinates = new Dictionary<string, Tuple<int, int>>()
        {
            //top middle, move up and down, start by moving downward
            {"1_state_1", new Tuple<int, int>(9, 0)},
            {"1_state_2", new Tuple<int, int>(9, 3)},
            {"1_state_3", new Tuple<int, int>(9, 5)},
            {"1_state_4", new Tuple<int, int>(9, 7)}

        };
        readonly Dictionary<string, Tuple<int, int>> two_coordinates = new Dictionary<string, Tuple<int, int>>()
        {
            //right middle, move left and right, start by moving left
            {"2_state_1", new Tuple<int, int>(19, 9)},
            {"2_state_2", new Tuple<int, int>(17, 9)},
            {"2_state_3", new Tuple<int, int>(15, 9)},
            {"2_state_4", new Tuple<int, int>(13, 9)}

        };
        readonly Dictionary<string, Tuple<int, int>> three_coordinates = new Dictionary<string, Tuple<int, int>>()
        {
            //left middle, move left and right, start by moving right
            {"3_state_1", new Tuple<int, int>(0, 9)},
            {"3_state_2", new Tuple<int, int>(3, 9)},
            {"3_state_3", new Tuple<int, int>(5, 9)},
            {"3_state_4", new Tuple<int, int>(7, 9)}

        };
        readonly Dictionary<string, Tuple<int, int>> four_coordinates = new Dictionary<string, Tuple<int, int>>()
        {
            //bottom middle, move up and down, start by moving up
            {"4_state_1", new Tuple<int, int>(9, 19)},
            {"4_state_2", new Tuple<int, int>(9, 17)},
            {"4_state_3", new Tuple<int, int>(9, 15)},
            {"4_state_4", new Tuple<int, int>(9, 13)}

        };


        public MainForm()
        {
            InitializeComponent();
         
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Calculate the padding size based on 10% of the form size
            int padding_size = (int)(0.1 * Math.Min(this.ClientSize.Width, this.ClientSize.Height));

            // Set the Margin property of the table layout panel to the calculated padding size
            grid.Padding = new Padding(padding_size);
            RotatePositions();
        }
        //return all black and white squares to the original position
        private void ResetPieces()
        {

        }
        //used to shift the blockades every turn 

        private void RotatePositions()
        {
            Tuple<int, int> firstTuple = four_coordinates.Values.ElementAt(0);
            PictureBox test = grid.GetControlFromPosition(0, 0) as PictureBox;
            grid.Controls.Remove(test);
            grid.Controls.Add(test, firstTuple.Item1, firstTuple.Item2);
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
