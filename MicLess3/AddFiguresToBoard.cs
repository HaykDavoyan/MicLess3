namespace MicLess3;

class AddFiguresToBoard
{
    /// <summary>
    /// Add the figures on the board.
    /// </summary>
    /// <param name="chessBoard">The chessboard.</param>
    /// <param name="coordinate">The coordinate where the figure will be added.</param>
    /// <param name="figure">The figure to be added.</param>
    public void AddFigureToBoard(Board chessBoard, Coordinate coordinate, string figure)
    {
        int row = coordinate.row - 1;
        int column = coordinate.column - 'A';

        chessBoard.board[row, column] = figure;
    }
}
