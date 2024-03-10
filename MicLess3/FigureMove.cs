using System;
using System.Collections.Generic;
using MicLess3;
using MicLess3.Figures;
using System.Drawing;

namespace MicLess3
{
    internal class FigureMove
    {
        private King bKing = new King(Color.Black);
        private Queen queen = new Queen(Color.Black);
        private Rook rook1 = new Rook(Color.Black);
        private Board chessBoard = new Board();
        private ValidationSecMode validator = new ValidationSecMode();

        public bool MoveFigure(Board chessBoard, Coordinate currentCoordinate, Coordinate newCoordinate)
        {
            string figure = chessBoard.board[currentCoordinate.row - 1, currentCoordinate.column - 'A'];

            if (string.IsNullOrWhiteSpace(figure))
            {
                Console.WriteLine("No figure found at the specified coordinates.");
                return false;
            }

            Figure currentFigure = GetFigureFromSymbol(figure);

            if (!currentFigure.CheckMove(currentCoordinate, newCoordinate))
            {
                Console.WriteLine("Invalid move for the figure.");
                return false;
            }

            chessBoard.board[currentCoordinate.row - 1, currentCoordinate.column - 'A'] = null;
            chessBoard.board[newCoordinate.row - 1, newCoordinate.column - 'A'] = currentFigure.Name;

            return true;
        }

        public bool IsCheckmate(Board chessBoard, List<Coordinate> allFiguresCoordinates, string kingSymbol)
        {
            Coordinate kingCoordinates = validator.FindKingCoordinate(chessBoard, kingSymbol);

            if (validator.IsUnderAttack(chessBoard, allFiguresCoordinates, kingCoordinates))
            {
                if (!validator.HasLegalMoves(chessBoard, kingCoordinates))
                {
                    Console.WriteLine("****CHECKMATE****");
                    return true;
                }
            }

            return false;
        }

        private Figure GetFigureFromSymbol(string symbol)
        {
            switch (symbol.ToUpper())
            {
                case "K":
                    return new King(Color.White);
                case "Q":
                    return new Queen(Color.Black);
                case "R":
                    return new Rook(Color.Black);
                default:
                    throw new ArgumentException("Invalid figure symbol.");
            }
        }

        public void PlayGame(Board chessBoard)
        {
            Console.WriteLine("Enter the coordinates for the white king");
            Coordinate whiteKingCoordinates = Coordinate.ParseCoordinate(Console.ReadLine());

            if (!MoveFigure(chessBoard, whiteKingCoordinates, whiteKingCoordinates))
            {
                Console.WriteLine("Invalid coordinate for the white king.");
                return;
            }

            Console.WriteLine("White King moved to: " + whiteKingCoordinates.column + whiteKingCoordinates.row);
            PrintChessboard(chessBoard);

            while (true)
            {
                Coordinate blackFigureCoordinate = GetRandomCoordinate();
                Coordinate newBlackFigureCoordinate = GetRandomCoordinate();

                if (!MoveFigure(chessBoard, blackFigureCoordinate, newBlackFigureCoordinate))
                {
                    Console.WriteLine("Invalid move for black figure.");
                    return;
                }

                Console.WriteLine($"Black figure moved from " + blackFigureCoordinate.column + blackFigureCoordinate.row +
                                    " to " + newBlackFigureCoordinate.column + newBlackFigureCoordinate.row);
                PrintChessboard(chessBoard);

                if (validator.IsUnderAttack(chessBoard, null, "K"))
                {
                    Console.WriteLine("White King is in check!");
                }

                if (IsCheckmate(chessBoard, null, "K"))
                {
                    Console.WriteLine("White King is checkmated!");
                    return;
                }
            }
        }

        private Coordinate GetRandomCoordinate()
        {
            Random rand = new Random();
            char column = (char)('A' + rand.Next(8));
            int row = rand.Next(1, 9);
            return new Coordinate(column, row);
        }

        private void PrintChessboard(Board chessBoard)
        {
            chessBoard.PrintBoardNew();
        }
    }
}
