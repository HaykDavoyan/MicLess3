﻿namespace MicLess3;

internal class GameModeTypes
{
    /// <summary>
    /// Creating two game modes Alternative - 1 and classic - 2.
    /// </summary>
    /// <param name="comment"></param>
    /// <param name="board"></param>
    /// <returns></returns>
    public string EnterGameMode(out string comment, string[,] board)
    {
        comment = "Enter the game mode: Alternative - 1 or Classic - 2\n";
        Console.Write(comment);
        string userInput;

        do
        {
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    SecondMode secondMode = new SecondMode();
                    secondMode.SecondGameMode(board);
                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        } while (userInput != "1" && userInput != "2");

        return userInput;
    }
}