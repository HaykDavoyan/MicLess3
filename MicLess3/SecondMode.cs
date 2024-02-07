using MicLess3.Figures;

namespace MicLess3
{
    public class SecondMode
    {
        /// <summary>
        /// Enter the coordinate for 5 figures.
        /// </summary>
        /// <param name="board"></param>
        public void SecondGameMode(string[,] board)
        {
            King king = new King();
            King kingB = new King();
            Queen queen = new Queen();
            Rook rook1 = new Rook();
            Rook rook2 = new Rook();
            PrintEmptyBoard(board);

            Console.WriteLine("Enter the coordinates for the black king");
            Coordinate blackKingCoordinates = Coordinate.ParseCoordinate(Console.ReadLine());
            AddFigure(board, blackKingCoordinates, "K");
            PrintChessboard(board);

            Console.WriteLine("Enter the coordinates for the black Queen");
            Coordinate blackQueenCoordinates = Coordinate.ParseCoordinate(Console.ReadLine());
            AddFigure(board, blackQueenCoordinates, "Q");
            PrintChessboard(board);

            Console.WriteLine("Enter the coordinates for the first black rook");
            Coordinate firstBlackRookCoordinates = Coordinate.ParseCoordinate(Console.ReadLine());
            AddFigure(board, firstBlackRookCoordinates, "R");
            PrintChessboard(board);

            Console.WriteLine("Enter the coordinates for the second black rook");
            Coordinate secondBlackRookCoordinates = Coordinate.ParseCoordinate(Console.ReadLine());
            AddFigure(board, secondBlackRookCoordinates, "R");
            PrintChessboard(board);

            Console.WriteLine("Enter the coordinates for the white king");
            Coordinate whiteKingCoordinates = Coordinate.ParseCoordinate(Console.ReadLine());
            AddFigure(board, whiteKingCoordinates, "k");
            PrintChessboard(board);

            Console.WriteLine("Chessboard printed. Press Enter to continue.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
        /// <summary>
        /// Adding the empty board.
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
        /// Put the figures on the board.
        /// </summary>
        /// <param name="board"></param>
        /// <param name="coordinate"></param>
        /// <param name="figure"></param>
        public void AddFigure(string[,] board, Coordinate coordinate, string figure)
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
        /// <summary>
        /// Printing the ready board.
        /// </summary>
        /// <param name="board"></param>
        public void PrintChessboard(string[,] board)
        {
            Board chessBoard = new Board();
            chessBoard.PrintBoardNew(board);
        }
    }
}
