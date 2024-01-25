namespace MicLess3.Figures;

/// <summary>
/// Check where the move for a knight is valid.
/// </summary>
/// <param name="firstCoord"></param>
/// <param name="secondCoord"></param>
/// <returns></returns>
class Knight
{
    public bool CheckMove(Coordinate firstCoord, Coordinate secondCoord)
    {
        int rowDifference = Math.Abs(secondCoord.row - firstCoord.row);
        int columnDifference = Math.Abs(secondCoord.column - firstCoord.column);

        return (rowDifference == 2 && columnDifference == 1) || (rowDifference == 1 && columnDifference == 2);
    }
}
