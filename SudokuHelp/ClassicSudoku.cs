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
        private int MiniSquareSize = 3;


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

        public void Solve()
        {
            List<SudokuTile> TilesBackup = Tiles;
            int NrOfTiles = Tiles.Count();
            int i = 0;
            while (!Verify())
            {
                if (Tiles[i].Fix)
                {
                    if(i >= Tiles.Count())
                    {
                        Back(ref i);
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    if(!Increment(ref i))
                    {
                        Back(ref i);
                    }
                }
            }
        }

        private bool Increment(ref int i)
        {
            List<int> Moves = PossibleMoves(Tiles[i]);
            if (Moves.Count() > 0)
            {
                Tiles[i].Value = Moves[0];
                i++;
                return true;
            }
            return false;
        }

        private void Back (ref int i)
        {
            if (!Tiles[i].Fix) { Tiles[i].Value = 0; }
            i--;
            if (Tiles[i].Fix)
            {
                Back(ref i);
            }
            else
            {
                List<int> Moves = PossibleMoves(Tiles[i]);
                if (Moves.Count() > 0)
                {
                    Tiles[i].Value = Moves[0];
                    i++;
                }
                else
                {
                    Back(ref i);
                }
            }
        }

        private List<int> PossibleMoves(SudokuTile Tile)
        {
            int Row = Tile.Row;
            int Column = Tile.Column;
            List<int> Used = new List<int>();
            List<int> UnUsed = new List<int>();
            foreach (SudokuTile tile in GroupByColumn[Column])
            {
                Used.Add(tile.Value);
            }
            
            foreach (SudokuTile tile in GroupByRow[Row])
            {
                Used.Add(Tile.Value);
            }

            foreach (var Box in GroupBy3x3)
            {
                if(Box.Any(tile => tile == Tile)){
                    foreach(SudokuTile tile in Box)
                    {
                        Used.Add(tile.Value);
                    }
                    break;
                }
            }

            for (int i=1; i <= Tile.MaxValue; i++)
            {
                if (!Used.Contains(i) && i > Tile.Value)
                {
                    UnUsed.Add(i);
                }
            }

            return UnUsed;
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
