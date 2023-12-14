using System;
using System.Collections.Generic;
using System.Linq;
namespace MicLess3.Figures;

 class Bishop
{
    /// <summary>
    /// Check where the move for a bishop is valid.
    /// </summary>
    /// <param name="firstCoord"></param>
    /// <param name="secondCoord"></param>
    /// <returns></returns>

    public  bool CheckBishopMove(string firstCoord, string secondCoord)
    {
        char column1 = firstCoord[0];
        int row1 = int.Parse(firstCoord.Substring(1));
        char column2 = secondCoord[0];
        int row2 = int.Parse(secondCoord.Substring(1));

        int rowDifference = Math.Abs(row2 - row1);
        int columnDifference = Math.Abs(column2 - column1);

        return rowDifference == columnDifference;
    }
}
