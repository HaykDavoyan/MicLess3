using System.Drawing;

namespace MicLess3.Figures;

public class King : Figure
{
    public King(Color color) : base("K", color) { }

    public bool CheckMove(Coordinate firstCoord, Coordinate secondCoord)
    {
        int rowDifference = Math.Abs(secondCoord.row - firstCoord.row);
        int columnDifference = Math.Abs(secondCoord.column - firstCoord.column);

        return (rowDifference == 0 && columnDifference == 1) ||
               (rowDifference == 1 && columnDifference == 0) ||
               (rowDifference == 1 && columnDifference == 1);
    }
}
