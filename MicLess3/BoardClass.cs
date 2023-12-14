namespace MicLess3;

class Board
{
    AddLetters letters = new AddLetters();

    public void PrintBoardNew(string[,] board)
    {
        letters.AddLettersOnTheBoard();

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {

                if ((i + j) % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
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
    /// <summary>
    /// Print the matric 8*8 for Chess board and give tham colors.
    /// </summary>
    /// <param name="board"></param>
    public void PrintBoard(string[,] board)
    {
        letters.AddLettersOnTheBoard();

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                board[i, j] = " ";
                if ((i + j) % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
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
