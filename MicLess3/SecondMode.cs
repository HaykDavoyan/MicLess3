namespace MicLess3;

public class SecondMode
{
    /// <summary>
    /// Add the five figures to the board for this game mode.
    /// </summary>
    /// <param name="board"></param>

    Coordinate coord = new Coordinate();

    public void SecondGameMode(string[,] board)
    {
        PrintEmptyBoard(board);

        Console.WriteLine("Enter the coordinates for the black king");
        AddFigures(board, Console.ReadLine().ToLower(), "K");
        PrintChessboard(board);

        Console.WriteLine("Enter the coordinates for the first black rook");
        AddFigures(board, Console.ReadLine().ToLower(), "R");
        PrintChessboard(board);

        Console.WriteLine("Enter the coordinates for the black Queen");
        AddFigures(board, Console.ReadLine().ToLower(), "Q");
        PrintChessboard(board);

        Console.WriteLine("Enter the coordinates for the second black rook");
        AddFigures(board, Console.ReadLine().ToLower(), "R");
        PrintChessboard(board);

        Console.WriteLine("Enter the coordinates for the white king");
        AddFigures(board, Console.ReadLine().ToLower(), "k");
        PrintChessboard(board);

        Console.WriteLine("Chessboard printed. Press Enter to continue.");
        while (Console.ReadKey().Key != ConsoleKey.Enter) ;

    }
    /// <summary>
    /// Print the empty board for second game mode.
    /// </summary>
    /// <param name="board"></param>
    public void PrintEmptyBoard(string[,] board)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                board[i, j] = " ";
            }
        }
    }
    /// <summary>
    /// Add the figures to the board for second game mode and check empty coordinates for figurs.
    /// </summary>
    /// <param name="board"></param>
    /// <param name="coordinates"></param>
    /// <param name="figure"></param>
    public void AddFigures(string[,] board, string coordinates, string figure)
    {
        while (true)
        {
            if (coordinates.Length == 2 && char.IsLetter(coordinates[0]) && char.IsDigit(coordinates[1]))
            {
                int col = coordinates[0] - 'a';
                int row = (coordinates[1] - '1');

                if (row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(1))
                {
                    if (board[row, col] == " ")
                    {
                        board[row, col] = figure;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates. The square is not empty. Try again:");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates. Try again:");
                }
            }
            else
            {
                Console.WriteLine("Invalid coordinates. Try again:");
            }

            coordinates = Console.ReadLine().ToLower();
        }
    }

    /// <summary>
    /// Print the chess board with all figures.
    /// </summary>
    /// <param name="board"></param>
    public void PrintChessboard(string[,] board)
    {
        Board chessBoard = new Board();
        chessBoard.PrintBoardNew(board);
    }
}