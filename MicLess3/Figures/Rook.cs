using System.Drawing;

namespace MicLess3.Figures;

public class Rook : Figure
{
    public Rook(Color color) : base("R", color) { }

    public override bool CheckMove(Coordinate currentCoordinate, Coordinate newCoordinate)
    {
        int rowDifference = Math.Abs(newCoordinate.row - currentCoordinate.row);
        int columnDifference = Math.Abs(newCoordinate.column - currentCoordinate.column);
        return rowDifference == 0 || columnDifference == 0;
    }
}
