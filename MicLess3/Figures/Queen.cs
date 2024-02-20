using System.Drawing;

namespace MicLess3.Figures;
public class Queen : Figure
{
    public Queen(Color color) : base("Q", color) { }

    public bool CheckMove(Coordinate firstCoord, Coordinate secondCoord)
    {
        int rowDifference = Math.Abs(secondCoord.row - firstCoord.row);
        int columnDifference = Math.Abs(secondCoord.column - firstCoord.column);

        return rowDifference == 0 ||
               columnDifference == 0 ||
               rowDifference == columnDifference;
    }
}
