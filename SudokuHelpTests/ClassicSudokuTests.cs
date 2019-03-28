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
    public class ClassicSudokuTests
    {
        [TestMethod()]
        public void VerifyTest()
        {
            int[,] Solved = new int[9, 9]
                {
                    { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                    { 7, 8, 9, 1, 2, 3, 4, 5, 6 },
                    { 4, 5, 6, 7, 8, 9, 1, 2, 3 },
                    { 3, 1, 2, 8, 4, 5, 9, 6, 7 },
                    { 6, 9, 7, 3, 1, 2, 8, 4, 5 },
                    { 8, 4, 5, 6, 9, 7, 3, 1, 2 },
                    { 2, 3, 1, 5, 7, 4, 6, 9, 8 },
                    { 9, 6, 8, 2, 3, 1, 5, 7, 4 },
                    { 5, 7, 4, 9, 6, 8, 2, 3, 1 }
                };
            ClassicSudoku Sudoko = new ClassicSudoku(Solved);
            
            if (!Sudoko.Verify())
            {
                Assert.Fail("Solved sudoku returning false");
            }


            int[,] Wrong = new int[9, 9]
                {
                    { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                    { 7, 8, 9, 1, 2, 3, 4, 5, 6 },
                    { 4, 5, 6, 7, 8, 9, 1, 2, 3 },
                    { 3, 1, 2, 8, 4, 5, 9, 6, 7 },
                    { 6, 9, 7, 3, 1, 2, 8, 4, 5 },
                    { 8, 4, 5, 6, 9, 7, 3, 1, 2 },
                    { 2, 3, 1, 5, 7, 4, 6, 9, 8 },
                    { 9, 6, 8, 2, 3, 1, 5, 7, 4 },
                    { 5, 7, 4, 9, 6, 8, 2, 3, 3 } // 3 at the end should be 1
                };
            Sudoko = new ClassicSudoku(Wrong);

            if (Sudoko.Verify())
            {
                Assert.Fail();
            }
        }
    }
}