using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Sudoku
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Grid.Populate(
                new int[9, 9]
                {
                    { 9, 0, 0, 0, 6, 0, 0, 0, 0 },
                    { 0, 3, 0, 8, 0, 1, 0, 4, 0 },
                    { 0, 0, 8, 0, 5, 4, 0, 0, 0 },
                    { 0, 0, 3, 0, 9, 0, 8, 0, 0 },
                    { 4, 7, 0, 0, 0, 0, 3, 9, 0 },
                    { 0, 0, 0, 0, 0, 7, 0, 1, 4 },
                    { 0, 1, 6, 7, 4, 0, 0, 0, 0 },
                    { 0, 0, 0, 5, 0, 0, 0, 0, 0 },
                    { 0, 9, 0, 3, 1, 0, 0, 0, 0 }
                }
            );
        }

        private void Solve_Click(object sender, EventArgs e)
        {

        }
    }
}
