using MicLess3.Figures;

namespace MicLess3;

public class SecondMode
{
    Rook rook = new Rook();
    Queen queen = new Queen();
    King king = new King();

    /// <summary>
    /// Enter the coordinates for four figures and add it to board.
    /// </summary>
    /// <param name="board"></param>
    public void SecondGameMode(string[,] board)
    {
        PrintEmptyBoard(board);

        Console.WriteLine("Enter the coordinates for the black king");
        Coordinate blackKingCoordinates = Coordinate.ParseCoordinate(Console.ReadLine());
        AddFigures(board, blackKingCoordinates, "K");
        PrintChessboard(board);

        Console.WriteLine("Enter the coordinates for the black Queen");
        Coordinate blackQueenCoordinates = Coordinate.ParseCoordinate(Console.ReadLine());
        AddFigures(board, blackQueenCoordinates, "Q");
        PrintChessboard(board);

        Console.WriteLine("Enter the coordinates for the first black rook");
        Coordinate firstBlackRookCoordinates = Coordinate.ParseCoordinate(Console.ReadLine());
        AddFigures(board, firstBlackRookCoordinates, "R");
        PrintChessboard(board);

        Console.WriteLine("Enter the coordinates for the second black rook");
        Coordinate secondBlackRookCoordinates = Coordinate.ParseCoordinate(Console.ReadLine());
        AddFigures(board, secondBlackRookCoordinates, "R");
        PrintChessboard(board);

        Console.WriteLine("Enter the coordinates for the white king");
        Coordinate whiteKingCoordinates = Coordinate.ParseCoordinate(Console.ReadLine());
        AddFigures(board, whiteKingCoordinates, "k");
        PrintChessboard(board);

        Console.WriteLine("Chessboard printed. Press Enter to continue.");
        while (Console.ReadKey().Key != ConsoleKey.Enter) ;
    }

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

    public void AddFigures(string[,] board, Coordinate coordinate, string figure)
    {
        while (true)
        {
            int col = coordinate.column - 'A';
            int row = coordinate.row - 1;

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

            coordinate = Coordinate.ParseCoordinate(Console.ReadLine());
        }
    }

    public void PrintChessboard(string[,] board)
    {
        Board chessBoard = new Board();
        chessBoard.PrintBoardNew(board);
    }
}