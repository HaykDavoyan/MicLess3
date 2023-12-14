﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicLess3.Figures;

 class Rook
{
    /// <summary>
    /// Check where the move for a rook is valid.
    /// </summary>
    /// <param name="firstCoord"></param>
    /// <param name="secondCoord"></param>
    /// <returns></returns>
    public bool CheckRookMove(string firstCoord, string secondCoord)
    {
        char column1 = firstCoord[0];
        int row1 = int.Parse(firstCoord.Substring(1));
        char column2 = secondCoord[0];
        int row2 = int.Parse(secondCoord.Substring(1));

        int rowDifference = Math.Abs(row2 - row1);
        int columnDifference = Math.Abs(column2 - column1);

        return rowDifference == 0 || columnDifference == 0;

    }
}
