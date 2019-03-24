﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SudokuHelp
{                                   
    public class SudokuFactory
    {
        private List<int[,]> ClassicSodukos = new List<int[,]>
        {
            new int[9, 9]
            {
                { 0, 0, 0, 2, 8, 0, 0, 0, 0 },
                { 0, 0, 3, 0, 1, 6, 8, 0, 0 },
                { 0, 0, 0, 0, 5, 0, 0, 0, 6 },
                { 0, 0, 0, 0, 3, 0, 0, 0, 0 },
                { 0, 0, 6, 8, 0, 0, 0, 0, 5 },
                { 1, 0, 0, 0, 0, 0, 7, 0, 0 },
                { 0, 7, 0, 0, 0, 3, 0, 0, 0 },
                { 0, 2, 1, 0, 0, 0, 6, 0, 0 },
                { 0, 3, 9, 5, 0, 1, 0, 2, 0 }
            },
            new int[9, 9]
            {
                { 0, 0, 5, 6, 0, 8, 0, 0, 0 },
                { 0, 4, 0, 2, 0, 0, 0, 5, 0 },
                { 0, 1, 0, 9, 3, 0, 0, 8, 4 },
                { 0, 0, 0, 0, 0, 4, 0, 9, 0 },
                { 5, 0, 0, 0, 0, 0, 0, 0, 8 },
                { 2, 9, 0, 0, 0, 6, 0, 0, 0 },
                { 1, 0, 8, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 1, 0, 2, 0 },
                { 0, 0, 3, 0, 0, 0, 0, 0, 6 }
            },
            new int[9, 9]
            {
                { 0, 0, 4, 0, 0, 0, 0, 0, 8 },
                { 3, 9, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 2, 0, 0, 0, 0, 0, 1, 3 },
                { 9, 1, 0, 7, 3, 0, 0, 0, 6 },
                { 4, 0, 0, 1, 0, 8, 0, 9, 0 },
                { 0, 0, 3, 4, 0, 6, 0, 0, 0 },
                { 0, 6, 8, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 6, 0, 0, 0, 0, 4 },
                { 1, 0, 9, 8, 0, 0, 0, 0, 2 }
            },
            new int[9, 9]
            {
                { 0, 3, 0, 0, 0, 8, 0, 0, 0 },
                { 7, 0, 0, 0, 0, 0, 0, 0, 9 },
                { 0, 5, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 3, 6, 0, 0, 2, 0, 0 },
                { 0, 0, 2, 0, 8, 0, 0, 0, 0 },
                { 8, 0, 0, 0, 7, 3, 0, 4, 0 },
                { 0, 2, 0, 9, 6, 0, 0, 7, 8 },
                { 0, 0, 0, 0, 0, 4, 0, 6, 0 },
                { 0, 0, 8, 0, 3, 0, 4, 2, 0 }
            },
            new int[9, 9]
            {
                { 0, 0, 0, 0, 0, 0, 7, 8, 0 },
                { 8, 6, 0, 0, 0, 0, 0, 0, 9 },
                { 0, 5, 1, 0, 0, 9, 2, 0, 3 },
                { 0, 7, 2, 0, 0, 3, 0, 9, 0 },
                { 0, 0, 0, 9, 0, 0, 0, 0, 6 },
                { 6, 0, 0, 0, 0, 1, 0, 0, 0 },
                { 0, 3, 0, 0, 0, 0, 0, 0, 2 },
                { 2, 0, 0, 0, 0, 6, 0, 1, 5 },
                { 1, 0, 0, 7, 0, 0, 8, 0, 0 }
            },
            new int[9, 9]
            {
                { 9, 0, 0, 0, 6, 0, 0, 0, 0 },
                { 0, 3, 0, 8, 0, 1, 0, 4, 0 },
                { 0, 0, 8, 0, 5, 4, 0, 0, 0 },
                { 0, 0, 3, 0, 9, 0, 8, 0, 0 },
                { 4, 7, 0, 0, 0, 0, 3, 9, 0 },
                { 0, 0, 0, 0, 0, 7, 0, 1, 4 },
                { 0, 1, 6, 7, 4, 0, 0, 0, 0 },
                { 0, 0, 0, 5, 0, 0, 0, 0, 0 },
                { 0, 9, 0, 3, 1, 0, 0, 0, 0 }
            }
        };

        public ClassicSudoku GenerateClassicSudoku()
        {
            ClassicSudoku Sudoku = new ClassicSudoku();
            Random rnd = new Random();
            int SudokuIndex = rnd.Next(0, ClassicSodukos.Count - 1);
            //ClassicSodukos[SudokuIndex];
            return Sudoku;
        }
    }
}