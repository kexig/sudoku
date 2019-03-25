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
        private Tile[,] Tiles;

        public Grid9x9()
        {
            InitializeComponent();
        }
        //public int[,] Value
        //{
        //    get
        //    {
        //        int[,] array1 = new int[Tiles.GetLength(0), Tiles.GetLength(1)];
        //        for (int Row = 0; Row < Tiles.GetLength(0); Row++)
        //        {
        //            for (int Column = 0; Column < Tiles.GetLength(1); Column++)
        //            {
        //                Tile Tile = (Tile)SudokuTableLayoutPanel.GetControlFromPosition(Column, Row);
        //                ValueOfTiles.Add(Tile.Value);
        //            }
        //        }
        //        return;
        //    }
        //}

        public void Populate(int[,] Value)
        {
            for (int Row = 0; Row < Value.GetLength(0); Row++)
            {
                for (int Column = 0; Column < Value.GetLength(1); Column++)
                {
                    Tile Tile = (Tile)SudokuTableLayoutPanel.GetControlFromPosition(Column, Row);
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
