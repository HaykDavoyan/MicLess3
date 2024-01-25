using System;

namespace MicLess3;
class Program
{
    /// <summary>
    /// Creating the Matric 8*8 for chess board.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        GameModeTypes gameMode = new GameModeTypes();
        string comment;
        string[,] board = new string[8, 8];
        Console.WriteLine(gameMode.EnterGameMode(out comment, board));
        Board chessBoard = new Board();
        chessBoard.PrintBoard(board);
        CheckFiguresMove figuresMove = new CheckFiguresMove();
        figuresMove.CheckFigureMove(board);
    }
}
