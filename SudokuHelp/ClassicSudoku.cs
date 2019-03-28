using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SudokuHelp
{
    public class ClassicSudoku
    {
        private List<SudokuTile> Tiles = new List<SudokuTile>();
        private int Columns;
        private int Rows;
        private List<IGrouping<int, SudokuTile>> GroupByColumn;
        private List<IGrouping<int, SudokuTile>> GroupByRow;
        private List<IEnumerable<SudokuTile>> GroupBy3x3 = new List<IEnumerable<SudokuTile>>();


        private void CreateTiles(int[,] Template)
        {
            for (int Row = 0; Row < Template.GetLength(0); Row++)
            {
                for (int Column = 0; Column < Template.GetLength(1); Column++)
                {
                    SudokuTile Tile = new SudokuTile(Row, Column, 9);
                    Tile.Value = Template[Row, Column];
                    Tile.Fix = Template[Row, Column] == 0 ? false : true;
                    Tiles.Add(Tile);
                }
            }

            GroupByColumn = Tiles.GroupBy(tile => tile.Column).ToList();
            GroupByRow = Tiles.GroupBy(tile => tile.Row).ToList();
            Columns = GroupByColumn.Count();
            Rows = GroupByRow.Count();
            //Rows = Tiles.Max(tile => tile.Row) + 1;

            int MiniSquareSize = 3;
            GroupBy3x3.Clear();
            for (int Row = 0; Row < (Rows / MiniSquareSize); Row++)
            {
                for (int Column = 0; Column < (Columns / MiniSquareSize); Column++)
                {
                    var TilesInRange = Tiles.Where(tile => (tile.Row < (Row * MiniSquareSize)) && (tile.Row >= (Row * MiniSquareSize - MiniSquareSize)))
                        .Where(tile => (tile.Column < (Column * MiniSquareSize)) && (tile.Column >= (Column * MiniSquareSize - MiniSquareSize)));
                    GroupBy3x3.Add(TilesInRange);
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
            CreateTiles(Template);
        }

        public void Populate(int[,] Template)
        {
            CreateTiles(Template);
        }

        public void Populate()
        {

        }

        public void Solve()
        {

        }

        public bool Verify()
        {
            foreach (var Column in GroupByColumn)
            {
                bool AllUnique = Column.GroupBy(x => x.Value).All(g => g.Count() == 1);
                switch (AllUnique)
                {
                    case true:
                        break;
                    case false:
                        return false;
                }
            }

            foreach (var Row in GroupByRow)
            {
                bool AllUnique = Row.GroupBy(x => x.Value).All(g => g.Count() == 1);
                switch (AllUnique)
                {
                    case true:
                        break;
                    case false:
                        return false;
                }
            }

            foreach (var Square in GroupBy3x3)
            {
                bool AllUnique = Square.GroupBy(x => x.Value).All(g => g.Count() == 1);
                switch (AllUnique)
                {
                    case true:
                        break;
                    case false:
                        return false;
                }
            }

            return true;
        }
    }
}
