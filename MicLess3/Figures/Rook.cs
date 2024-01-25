using System;
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
    public bool CheckMove(Coordinate firstCoord, Coordinate secondCoord)
    {
        int rowDifference = Math.Abs(secondCoord.row - firstCoord.row);
        int columnDifference = Math.Abs(secondCoord.column - firstCoord.column);

        return rowDifference == 0 || columnDifference == 0;

    }
}
