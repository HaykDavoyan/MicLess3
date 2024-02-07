using System.Drawing;

namespace MicLess3.Figures;

class King
{
    //King wKing = new King();    
    //King bKing = new King();
    //public Color color;
    /// <summary>
    /// Check where the move for King is valid.
    /// </summary>
    /// <param name="firstCoord"></param>
    /// <param name="secondCoord"></param>
    /// <returns></returns>
    public bool CheckMove(Coordinate firstCoord, Coordinate secondCoord)
    {
        //wKing.color = Color.White;
        //bKing.color = Color.Black;
        int rowDifference = Math.Abs(secondCoord.row - firstCoord.row);
        int columnDifference = Math.Abs(secondCoord.column - firstCoord.column);

        return (rowDifference == 0 && columnDifference == 1 || rowDifference == 1 && columnDifference == 0 || rowDifference == 1 && columnDifference == 1);

    }
}
