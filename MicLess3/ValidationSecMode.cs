using MicLess3.Figures;
using System;
using System.Collections.Generic;
using System.Drawing; 

namespace MicLess3
{
    internal class ValidationSecMode
    {
        private List<Coordinate> allFiguresCoordinates = new List<Coordinate>();
        private King king = new King(Color.White);
        private King bKing = new King(Color.Black);
        private Queen queen = new Queen(Color.Black);
        private Rook rook1 = new Rook(Color.Black);
        private Rook rook2 = new Rook(Color.Black);

        public bool IsCheckmate(Board chessBoard, string kingSymbol)
        {
            Coordinate kingCoordinates = FindKingCoordinate(chessBoard, kingSymbol);

            if (IsUnderAttack(chessBoard, allFiguresCoordinates, kingCoordinates))
            {
                if (!HasLegalMoves(chessBoard, kingCoordinates))
                {
                    Console.WriteLine("****CHECKMATE****");
                    return true;
                }
            }

            return false;
        }

        public bool IsStalemate(Board chessBoard, string kingSymbol)
        {
            Coordinate kingCoordinates = FindKingCoordinate(chessBoard, kingSymbol);

            if (!IsUnderAttack(chessBoard, allFiguresCoordinates, kingCoordinates))
            {
                if (!HasAnyLegalMoves(chessBoard, kingSymbol))
                {
                    Console.WriteLine("****STALEMATE****");
                    return true;
                }
            }

            return false;
        }

        private bool HasAnyLegalMoves(Board chessBoard, string playerSymbol)
        {
            for (int row = 0; row < chessBoard.board.GetLength(0); row++)
            {
                for (int col = 0; col < chessBoard.board.GetLength(1); col++)
                {
                    string figureSymbol = chessBoard.board[row, col];

                    if (figureSymbol.ToUpper() == playerSymbol.ToUpper())
                    {
                        Coordinate figureCoordinate = new Coordinate((char)('A' + col), row + 1);

                        if (HasLegalMoves(chessBoard, figureCoordinate))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool IsUnderAttack(Board chessBoard, List<Coordinate> allFiguresCoordinates, Coordinate coordinate)
        {
            bool kingCheck = false;

            foreach (Coordinate figureCoordinate in allFiguresCoordinates)
            {
                if (queen.CheckMove(coordinate, figureCoordinate) ||
                    rook1.CheckMove(coordinate, figureCoordinate) ||
                    rook2.CheckMove(coordinate, figureCoordinate))
                {
                    return true;
                }
                else if (bKing.CheckMove(coordinate, figureCoordinate))
                {
                    kingCheck = true;
                }
            }

            return kingCheck;
        }

        public bool HasLegalMoves(Board chessBoard, Coordinate coordinate)
        {
            string figure = chessBoard.board[coordinate.row - 1, coordinate.column - 'A'];

            switch (figure.ToUpper())
            {
                case "K":
                    return bKing.CheckMove(coordinate, new Coordinate('A', 1));
                case "Q":
                    return queen.CheckMove(coordinate, new Coordinate('A', 1));
                case "R":
                    return rook1.CheckMove(coordinate, new Coordinate('A', 1));
            }
            return false;
        }

        public Coordinate FindKingCoordinate(Board chessBoard, string kingSymbol)
        {
            for (int row = 0; row < chessBoard.board.GetLength(0); row++)
            {
                for (int col = 0; col < chessBoard.board.GetLength(1); col++)
                {
                    if (chessBoard.board[row, col].ToUpper() == kingSymbol.ToUpper())
                    {
                        return new Coordinate((char)('A' + col), row + 1);
                    }
                }
            }

            return new Coordinate(' ', -1);
        }
    }
}
