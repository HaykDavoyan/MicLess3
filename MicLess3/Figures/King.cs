using System.Drawing;

namespace MicLess3.Figures;

public class King : Figure
{
    public King(Color color) : base("K", color) { }

    public override bool CheckMove(Coordinate currentCoordinate, Coordinate newCoordinate)
    {
        int rowDifference = Math.Abs(newCoordinate.row - currentCoordinate.row);
        int columnDifference = Math.Abs(newCoordinate.column - currentCoordinate.column);

        return (rowDifference == 0 && columnDifference == 1) ||
               (rowDifference == 1 && columnDifference == 0) ||
               (rowDifference == 1 && columnDifference == 1);
    }
}
