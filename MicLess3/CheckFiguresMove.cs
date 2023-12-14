using MicLess3.Figures;

namespace MicLess3;

class CheckFiguresMove
{
    Knight knight = new Knight();
    Bishop bishop = new Bishop();
    Rook rook =  new Rook();
    Queen queen = new Queen();
    King king = new King();
    //CheckFiguresMove figuresMove = new CheckFiguresMove();
    AddFiguresToBoard figures = new AddFiguresToBoard();
    Board board = new Board();


    public void CheckFigureMove(string[,] Board)
    {
        
        Console.Write("Enter the figure (N for Knight, B for Bishop, R for rook, Q for Queen, K for King): ");
        char figure = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        Console.Write("Enter the first Coordinat: ");
        string firstCoord = Console.ReadLine().ToUpper();
        Console.Write("Enter the second Coordinat: ");
        string secondCoord = Console.ReadLine().ToUpper();

        bool isValidMove = false;

        if (figure == 'N')
        {
            isValidMove = knight.CheckKnightMove(firstCoord, secondCoord);
        }
        else if (figure == 'B')
        {
            isValidMove = bishop.CheckBishopMove(firstCoord, secondCoord);
        }
        else if (figure == 'R')
        {
            isValidMove = rook.CheckRookMove(firstCoord, secondCoord);
        }
        else if (figure == 'Q')
        {
            isValidMove = queen.CheckQueenMove(firstCoord, secondCoord);
        }
        else if (figure == 'K')
        {
            isValidMove = king.CheckKingMove(firstCoord, secondCoord);
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
