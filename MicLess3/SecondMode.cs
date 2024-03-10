using MicLess3;

public class SecondMode
{
    private List<Coordinate> allFiguresCoordinates = new List<Coordinate>();
    private Board chessBoard = new Board();
    private AddFiguresToBoard figureAdder = new AddFiguresToBoard();

    public void SecondGameMode()
    {
        ValidationSecMode validator = new ValidationSecMode();
        PrintEmptyBoard();

        Console.WriteLine("Enter the coordinates for the black king");
        Coordinate blackKingCoordinates = Coordinate.ParseCoordinate(Console.ReadLine());
        AddFigure(blackKingCoordinates, "K");
        PrintChessboard();

        Console.WriteLine("Enter the coordinates for the black Queen");
        Coordinate blackQueenCoordinates = Coordinate.ParseCoordinate(Console.ReadLine());
        AddFigure(blackQueenCoordinates, "Q");
        PrintChessboard();

        Console.WriteLine("Enter the coordinates for the first black rook");
        Coordinate firstBlackRookCoordinates = Coordinate.ParseCoordinate(Console.ReadLine());
        AddFigure(firstBlackRookCoordinates, "R");
        PrintChessboard();

        Console.WriteLine("Enter the coordinates for the second black rook");
        Coordinate secondBlackRookCoordinates = Coordinate.ParseCoordinate(Console.ReadLine());
        AddFigure(secondBlackRookCoordinates, "R");
        PrintChessboard();

        Console.WriteLine("Enter the coordinates for the white king");
        Coordinate whiteKingCoordinates = Coordinate.ParseCoordinate(Console.ReadLine());

        while (true)
        {
            if (!validator.IsUnderAttack(chessBoard, allFiguresCoordinates, whiteKingCoordinates))
            {
                if (!validator.IsCheckmate(chessBoard, "k") || !validator.IsStalemate(chessBoard, "k"))
                {
                    AddFigure(whiteKingCoordinates, "k");
                    PrintChessboard();
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid coordinate for the white king. It is under attack. Try again:");
            }
            whiteKingCoordinates = Coordinate.ParseCoordinate(Console.ReadLine());
        }
    }

    public void AddFigure(Coordinate coordinate, string figure)
    {
        figureAdder.AddFigureToBoard(chessBoard, coordinate, figure);
        allFiguresCoordinates.Add(coordinate);
    }

    public void PrintEmptyBoard()
    {
        chessBoard.ClearBoard();
    }

    public void PrintChessboard()
    {
        chessBoard.PrintBoardNew();
    }
}
