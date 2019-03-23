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
        public SudokuTile[,] SudokuTiles;
        private IEnumerable<NumericUpDown> NumericUpDowns => SudokuTableLayoutPanel.Controls.OfType<NumericUpDown>();

        public SudokuGrid()
        {
            InitializeComponent();

            var GroupedByRow = NumericUpDowns
                .Select(n => SudokuTableLayoutPanel.GetCellPosition(n))
                .OrderBy(p => p.Row)
                .ThenBy(p => p.Column)
                .GroupBy(p => p.Row);
        }

        public void SetSudoku(int[,] Sudoku)
        {
            for (int Row = 0; Row < Sudoku.GetLength(0); Row++)
            {
                for (int Column = 0; Column < Sudoku.GetLength(1); Column++)
                {
                    SudokuTile Tile = new SudokuTile(Row, Column, 9);
                    Tile.Value = Sudoku[Row, Column];
                    Tile.Fix = Sudoku[Row, Column] == 0 ? false : true;
                    SudokuTiles[Row, Column] = Tile;
                    var Control = (NumericUpDown)SudokuTableLayoutPanel.GetControlFromPosition(Column, Row);
                    Control.DataBindings.Add("Value", Tile, "Value", true, DataSourceUpdateMode.OnValidation);
                }
            }
        }
    }
}
