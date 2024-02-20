using MicLess3.Figures;
using System.Drawing;

namespace MicLess3;

internal class ValidationSecMode
{
    private List<Coordinate> allFiguresCoordinates = new List<Coordinate>();
    King king = new King(Color.White);
    King bKing = new King(Color.Black);
    Queen queen = new Queen(Color.Black);
    Rook rook1 = new Rook(Color.Black);
    Rook rook2 = new Rook(Color.Black);

    public bool IsCheckmate(string[,] board, string kingSymbol)
    {
        Coordinate kingCoordinates = FindKingCoordinate(board, kingSymbol);

        if (IsUnderAttack(board, allFiguresCoordinates, kingCoordinates))
        {
            if (!HasLegalMoves(board, kingCoordinates))
            {
                Console.WriteLine("****CHECKMATE****");
                return true;
            }
        }

        return false;
    }

    public bool IsStalemate(string[,] board, string kingSymbol)
    {
        Coordinate kingCoordinates = FindKingCoordinate(board, kingSymbol);

        if (!IsUnderAttack(board, allFiguresCoordinates, kingCoordinates))
        {
            if (!HasAnyLegalMoves(board, kingSymbol))
            {
                Console.WriteLine("****STALEMATE****");
                return true;
            }
        }

        return false;
    }
    private bool HasAnyLegalMoves(string[,] board, string playerSymbol)
    {
        for (int row = 0; row < board.GetLength(0); row++)
        {
            for (int col = 0; col < board.GetLength(1); col++)
            {
                string figureSymbol = board[row, col];

                if (figureSymbol.ToUpper() == playerSymbol.ToUpper())
                {
                    Coordinate figureCoordinate = new Coordinate((char)('A' + col), row + 1);

                    if (HasLegalMoves(board, figureCoordinate))
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }

    public bool IsUnderAttack(string[,] board, List<Coordinate> allFiguresCoordinates, Coordinate coordinate)
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

    public bool HasLegalMoves(string[,] board, Coordinate coordinate)
    {
        string figure = board[coordinate.row - 1, coordinate.column - 'A'];

        switch (figure.ToUpper())
        {
            case "K":
                return bKing.CheckMove(coordinate, new Coordinate('A', 1));
            case "k":
                return king.CheckMove(coordinate, new Coordinate('A', 1));
            case "Q":
                return queen.CheckMove(coordinate, new Coordinate('A', 1));
            case "R":
                return rook1.CheckMove(coordinate, new Coordinate('A', 1));
        }
        return false;
    }

    private Coordinate FindKingCoordinate(string[,] board, string kingSymbol)
    {
        for (int row = 0; row < board.GetLength(0); row++)
        {
            for (int col = 0; col < board.GetLength(1); col++)
            {
                if (board[row, col].ToUpper() == kingSymbol.ToUpper())
                {
                    return new Coordinate((char)('A' + col), row + 1);
                }
            }
        }

        return new Coordinate(' ', -1);
    }
}
