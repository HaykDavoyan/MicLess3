using System;

namespace MicLess3
{
    class Program
    {
        static void Main(string[] args)
        {
            GameModeTypes gameMode = new GameModeTypes();
            string comment;
            string[,] board = new string[8, 8];
            string userInput = gameMode.EnterGameMode(out comment, board);
            if (userInput == "1")
            {
                return;
            }
            Board chessBoard = new Board();
            chessBoard.PrintBoard(board);
            CheckFiguresMove figuresMove = new CheckFiguresMove();
            figuresMove.CheckFigureMove(board);
        }
    }
}
