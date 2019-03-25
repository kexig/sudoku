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
    public partial class Grid9x9 : UserControl
    {
        private int Rows;
        private int Columns;

        public Grid9x9()
        {
            InitializeComponent();
            Rows = LayoutPanel.RowCount;
            Columns = LayoutPanel.ColumnCount;
        }

        public int[,] Value
        {
            get
            {
                int[,] Result = new int[Rows, Columns];
                for (int Row = 0; Row < Rows; Row++)
                {
                    for (int Column = 0; Column < Columns; Column++)
                    {
                        Tile tile = (Tile)LayoutPanel.GetControlFromPosition(Column, Row);
                        Result[Row, Column] = tile.Value;
                    }
                }
                return Result;
            }
        }

        public void Populate(int[,] Value)
        {
            for (int Row = 0; Row < Value.GetLength(0); Row++)
            {
                for (int Column = 0; Column < Value.GetLength(1); Column++)
                {
                    Tile Tile = (Tile)LayoutPanel.GetControlFromPosition(Column, Row);
                    Tile.Row = Row;
                    Tile.Column = Column;
                    Tile.Maximum = 9;
                    Tile.Value = Value[Row, Column];
                    Tile.Fix = Value[Row, Column] == 0 ? false : true;
                }
            }
        }
    }
}
