using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SudokuHelp
{
    public partial class SudokuTile : UserControl
    {
        public int Row;
        public int Column;

        public SudokuTile()
        {
            InitializeComponent();
            Control.Maximum = 9;
        }

        public int Maximum
        {
            set { Control.Maximum = value; }
            get { return (int)Control.Maximum; }
        }

        public bool Fix
        {
            set { Control.Enabled = !value; }
            get { return !Control.Enabled; }
        }

        public int Value
        {
            get { return (int)Control.Value; }
            set
            {
                if (Fix)
                {
                    throw new InvalidOperationException("Can't change value of a fixed SudokuTile");
                }
                Control.Value = value;
            }
        }
    }
}
