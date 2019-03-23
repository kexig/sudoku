using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuHelp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuHelp.Tests
{
    [TestClass()]
    public class SudokuTileTests
    {
        [TestMethod()]
        public void ValueTooLarge()
        {
            SudokuTile Tile = new SudokuTile(1, 1, 9);
            try
            {
                Tile.Value = 10;
            }
            catch(Exception e)
            {
                if (!(e is  ArgumentOutOfRangeException))
                {
                    Assert.Fail("Correct exception not thrown");
                }
            }
        }

        [TestMethod()]
        public void SetValueWhenFixed()
        {
            SudokuTile Tile = new SudokuTile(1, 1, 9)
            {
                Fix = true
            };

            try
            {
                Tile.Value = 2;
            }
            catch (Exception e)
            {
                if (!(e is InvalidOperationException))
                {
                    Assert.Fail("Correct exception not thrown");
                }

            }
        }
    }
}