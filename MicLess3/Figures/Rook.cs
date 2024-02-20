using System.Drawing;

namespace MicLess3.Figures;

public class Rook : Figure
{
    public Rook(Color color) : base("R", color) { }

    public bool CheckMove(Coordinate firstCoord, Coordinate secondCoord)
    {
        int rowDifference = Math.Abs(secondCoord.row - firstCoord.row);
        int columnDifference = Math.Abs(secondCoord.column - firstCoord.column);
        return rowDifference == 0 || columnDifference == 0;
    }
}
