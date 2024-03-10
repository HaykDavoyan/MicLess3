using System;

namespace MicLess3;

public class Board
{
    private AddLetters letters = new AddLetters();
    public string[,] board = new string[8, 8];

    public void ClearBoard()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                board[i, j] = " ";
            }
        }
    }
    public void PrintBoard()
    {
        letters.AddLettersOnTheBoard();

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                board[i, j] = " ";
                if ((i + j) % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                Console.Write(" " + board[i, j]);
                Console.BackgroundColor = ConsoleColor.Black;
                if (j == 7)
                {
                    Console.Write("| " + Convert.ToString(i + 1));
                }
            }
            Console.WriteLine();
        }
    }

    public void PrintBoardNew()
    {
        letters.AddLettersOnTheBoard();

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {

                if ((i + j) % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                Console.Write(" " + board[i, j]);
                Console.BackgroundColor = ConsoleColor.Black;
                if (j == 7)
                {
                    Console.Write("| " + Convert.ToString(i + 1));
                }
            }
            Console.WriteLine();
        }

    }
}
