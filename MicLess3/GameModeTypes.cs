using System;

namespace MicLess3;

internal class GameModeTypes
{
    /// <summary>
    /// Creating two game modes Alternative - 1 and classic - 2.
    /// </summary>
    /// <param name="comment"></param>
    /// <param name="chessBoard"></param>
    /// <returns></returns>
    public string EnterGameMode(out string comment, Board chessBoard)
    {
        comment = "Enter the game mode: Alternative - 1 or Classic - 2\n";
        Console.Write(comment);
        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                SecondMode secondMode = new SecondMode();
                secondMode.SecondGameMode();
                break;
            case "2":
                chessBoard.PrintBoard();
                CheckFiguresMove figuresMove = new CheckFiguresMove();
                figuresMove.CheckFigureMove(chessBoard);
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }

        return userInput;
    }
}
