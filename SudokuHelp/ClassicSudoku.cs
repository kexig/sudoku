using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SudokuHelp
{
    public class ClassicSudoku
    {
        private List<SudokuTile> Tiles;

        private void CreateTiles(int[,] Template)
        {
            for (int Row = 0; Row < Template.GetLength(0); Row++)
            {
                for (int Column = 0; Row < Template.GetLength(1); Column++)
                {
                    SudokuTile Tile = new SudokuTile(Row, Column, 9);
                    Tile.Value = Template[Row, Column];
                    Tile.Fix = Template[Row, Column] == 0 ? false : true;
                    Tiles.Add(Tile);
                }
            }
        }

        public int[,] Value
        {
            get
            {
                return null;
            }
        }

        public ClassicSudoku()
        {

        }

        public ClassicSudoku(int[,] Template)
        {

        }

        public void Populate(int[,] Template)
        {

        }

        public void Populate()
        {

        }

        public void Solve()
        {

        }
    }
}
