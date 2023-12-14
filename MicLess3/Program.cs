using System;

namespace MicLess3;
class Program
{
    static void Main(string[] args)
    {
        Board chessBoard = new Board();
        string[,] board = new string[8, 8];
        chessBoard.PrintBoard(board);
        CheckFiguresMove figuresMove = new CheckFiguresMove();
        figuresMove.CheckFigureMove(board);
    }
}