﻿using Sudoku.Shared;

namespace Sudoku.or_tools;
    public class ORTOOLSEmptySolver : ISudokuSolver
{
     
         public SudokuGrid Solve(SudokuGrid s)
    {
        return s.CloneSudoku();
    }

}



