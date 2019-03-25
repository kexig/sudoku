using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SudokuHelp
{
    public class SudokuTile
    {
        public bool Fix;
        public readonly int Row;
        public readonly int Column;
        public readonly int MaxValue;
        private int _value;

        public SudokuTile(int Row, int Column, int MaxValue)
        {
            this.Row = Row;
            this.Column = Column;
            this.MaxValue = MaxValue;
        }

        public int Value
        {
            get { return _value; }
            set
            {
                if (Fix)
                {
                    throw new InvalidOperationException("Can't change value of a fixed SudokuTile");
                }
                if (value > MaxValue || value < 0)
                { 
                    throw new ArgumentOutOfRangeException("SudokuTile.Value is out of range");
                }
                _value = value;
            }
        }
    }
}
