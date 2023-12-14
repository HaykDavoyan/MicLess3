namespace MicLess3;

class AddFiguresToBoard
{
    /// <summary>
    /// Add letters matching figure to the board.
    /// </summary>
    /// <param name="board"></param>
    /// <param name="coordOfKnight"></param>
    public void AddFigureToBoard(string[,] Board, string coord, string figure)
    {
        char column = coord[0];
        int row = int.Parse(coord.Substring(1)) - 1;

        Board[row, column - 'A'] = figure;
    }
}
