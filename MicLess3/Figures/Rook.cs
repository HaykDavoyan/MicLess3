using System.Drawing;

namespace MicLess3.Figures;

class Rook
{
    //Rook rook1 = new Rook();
    //Rook rook2 = new Rook();
    //public Color color;
    /// <summary>
    /// Check where the move for a rook is valid.
    /// </summary>
    /// <param name="firstCoord"></param>
    /// <param name="secondCoord"></param>
    /// <returns></returns>
    public bool CheckMove(Coordinate firstCoord, Coordinate secondCoord)
    {
        //rook1.color = Color.Black;
        //rook2.color = Color.Black;
        int rowDifference = Math.Abs(secondCoord.row - firstCoord.row);
        int columnDifference = Math.Abs(secondCoord.column - firstCoord.column);
        return rowDifference == 0 || columnDifference == 0;

    }
}
