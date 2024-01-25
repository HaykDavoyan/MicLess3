namespace MicLess3.Figures;

 class Bishop
{
    /// <summary>
    /// Check where the move for a bishop is valid.
    /// </summary>
    /// <param name="firstCoord"></param>
    /// <param name="secondCoord"></param>
    /// <returns></returns>

    public  bool CheckMove(Coordinate firstCoord, Coordinate secondCoord)
    {
        int rowDifference = Math.Abs(secondCoord.row - firstCoord.row);
        int columnDifference = Math.Abs(secondCoord.column - firstCoord.column);

        return rowDifference == columnDifference;
    }
}
