using System;
using MicLess3.Figures;
using System.Drawing;

namespace MicLess3
{
    class CheckFiguresMove
    {
        Knight knight = new Knight();
        Bishop bishop = new Bishop();
        Rook rook = new Rook(Color.White);
        Queen queen = new Queen(Color.Black);
        King king = new King(Color.Black);
        AddFiguresToBoard figures = new AddFiguresToBoard();

        public void CheckFigureMove(Board chessBoard)
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
                figures.AddFigureToBoard(chessBoard, firstCoord, figure.ToString());
                figures.AddFigureToBoard(chessBoard, secondCoord, figure.ToString());
                chessBoard.PrintBoardNew();
                chessBoard.ClearBoard();
            }
            else
            {
                Console.WriteLine($"Invalid {figure} move!");
            }
        }
    }
}
