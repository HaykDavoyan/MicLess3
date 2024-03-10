using System;

namespace MicLess3;

class Program
{
    static void Main(string[] args)
    {
        GameModeTypes gameMode = new GameModeTypes();
        string comment;
        Board chessBoard = new Board(); 
        string userInput = gameMode.EnterGameMode(out comment, chessBoard); 
        if (userInput == "1")
        {
            return;
        }
        CheckFiguresMove figuresMove = new CheckFiguresMove();
        figuresMove.CheckFigureMove(chessBoard); 
    }
}
