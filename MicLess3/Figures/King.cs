using System;
using System.Collections.Generic;
namespace MicLess3.Figures;

class King
{
    /// <summary>
    /// Check where the move for King is valid.
    /// </summary>
    /// <param name="firstCoord"></param>
    /// <param name="secondCoord"></param>
    /// <returns></returns>
    public bool CheckKingMove(string firstCoord, string secondCoord)
    {
        char column1 = firstCoord[0];
        int row1 = int.Parse(firstCoord.Substring(1));
        char column2 = secondCoord[0];
        int row2 = int.Parse(secondCoord.Substring(1));

        int rowDifference = Math.Abs(row2 - row1);
        int columnDifference = Math.Abs(column2 - column1);

        return (rowDifference == 0 && columnDifference == 1 || rowDifference == 1 && columnDifference == 0 || rowDifference == 1 && columnDifference == 1);

    }
}
