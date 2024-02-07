﻿using System.Drawing;

namespace MicLess3.Figures;
class Queen
{
    //Queen queen = new Queen();
    //public Color color;
    /// <summary>
    /// Check where the move for a queen is valid.
    /// </summary>
    /// <param name="firstCoord"></param>
    /// <param name="secondCoord"></param>
    /// <returns></returns>
    public bool CheckMove(Coordinate firstCoord, Coordinate secondCoord)
    {
        //queen.color = Color.Black;
        int rowDifference = Math.Abs(secondCoord.row - firstCoord.row);
        int columnDifference = Math.Abs(secondCoord.column - firstCoord.column);

        return rowDifference == 0 || columnDifference == 0 || rowDifference == columnDifference;

    }
}
