using MicLess3.Figures;

namespace MicLess3;

class CheckFiguresMove
{
    /// <summary>
    /// Creating the Constructors for Figures.
    /// </summary>
    Knight knight = new Knight();
    Bishop bishop = new Bishop();
    Rook rook = new Rook();
    Queen queen = new Queen();
    King king = new King();
    AddFiguresToBoard figures = new AddFiguresToBoard();
    Board board = new Board();
    Coordinate coordinate = new Coordinate();

    /// <summary>
    /// Checking figure moves and putting the letter on the board.
    /// </summary>
    /// <param name="Board"></param>
    public void CheckFigureMove(string[,] Board)
    {
        Console.Write("Enter the figure (N for Knight, B for Bishop, R for rook, Q for Queen, K for King): ");
        
        char figure = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();
        
        Console.Write("Enter the first Coordinate: ");
        Coordinate firstCoord = Coordinate.ParseCoordinate(Console.ReadLine());

        Console.Write("Enter the second Coordinate: ");
        Coordinate secondCoord = Coordinate.ParseCoordinate(Console.ReadLine());

        bool isValidMove = false;

        if (figure == 'N')
        {
            isValidMove = knight.CheckMove(firstCoord, secondCoord);
        }
        else if (figure == 'B')
        {
            isValidMove = bishop.CheckMove(firstCoord, secondCoord);
        }
        else if (figure == 'R')
        {
            isValidMove = rook.CheckMove(firstCoord, secondCoord);
        }
        else if (figure == 'Q')
        {
            isValidMove = queen.CheckMove(firstCoord, secondCoord);
        }
        else if (figure == 'K')
        {
            isValidMove = king.CheckMove(firstCoord, secondCoord);
        }

        if (isValidMove)
        {
            Console.WriteLine($"Valid {figure} move!");
            figures.AddFigureToBoard(Board, firstCoord, figure.ToString());
            figures.AddFigureToBoard(Board, secondCoord, figure.ToString());
            board.PrintBoardNew(Board);

        }
        else
        {
            Console.WriteLine($"Invalid {figure} move!");
        }
    }
}
