namespace MicLess3;

class AddFiguresToBoard
{
    /// <summary>
    /// Add letters matching figure to the board.
    /// </summary>
    /// <param name="board"></param>
    /// <param name="coordOfKnight"></param>
    public void AddFigureToBoard(string[,] board, Coordinate coord, string figure)
    {
        int row = coord.row - 1;
        int column = coord.column - 'A';

        board[row, column] = figure;
    }
}
