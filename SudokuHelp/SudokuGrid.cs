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
    public partial class SudokuGrid : UserControl
    {
        public readonly SudokuTile[,] SudokuTiles;

        public SudokuGrid()
        {
            InitializeComponent();
        }

        public void SetSudoku(int[,] Sudoku)
        {
            for (int Row = 0; Row < Sudoku.GetLength(0); Row++)
            {
                for (int Column = 0; Column < Sudoku.GetLength(1); Column++)
                {
                    SudokuTile Tile = (SudokuTile)SudokuTableLayoutPanel.GetControlFromPosition(Column, Row);
                    Tile.Row = Row;
                    Tile.Column = Column;
                    Tile.Maximum = 9;
                    Tile.Value = Sudoku[Row, Column];
                    Tile.Fix = Sudoku[Row, Column] == 0 ? false : true;
                }
            }
        }
    }
}
