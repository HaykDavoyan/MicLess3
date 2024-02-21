using System;
using MicLess3.Figures;
using System.Drawing;
using System.Collections.Generic;

namespace MicLess3;

public class SecondMode
{
    private List<Coordinate> allFiguresCoordinates = new List<Coordinate>();

    public void SecondGameMode(string[,] board)
    {
        ValidationSecMode validator = new ValidationSecMode();
        King king = new King(Color.White);
        King bking = new King(Color.Black);
        Queen queen = new Queen(Color.Black);
        Rook rook1 = new Rook(Color.Black);
        Rook rook2 = new Rook(Color.Black);

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

        while (true)
        {
            if (!validator.IsUnderAttack(board, allFiguresCoordinates, whiteKingCoordinates))
            {
                if (!validator.IsCheckmate(board, "k",whiteKingCoordinates) && !validator.IsStalemate(board, "k", whiteKingCoordinates))
                {
                    AddFigure(board, whiteKingCoordinates, "k");
                    PrintChessboard(board);
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

    public void AddFigure(string[,] board, Coordinate coordinate, string figure)
    {
        int col = coordinate.column - 'A';
        int row = coordinate.row - 1;

        if (row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(1))
        {
            if (board[row, col] == " ")
            {
                board[row, col] = figure;
                allFiguresCoordinates.Add(coordinate);
            }
            else
            {
                Console.WriteLine("Invalid coordinates. The square is not empty. Try again:");
                AddFigure(board, Coordinate.ParseCoordinate(Console.ReadLine()), figure);
            }
        }
        else
        {
            Console.WriteLine("Invalid coordinates. Try again:");
            AddFigure(board, Coordinate.ParseCoordinate(Console.ReadLine()), figure);
        }
    }

    public void PrintChessboard(string[,] board)
    {
        Board chessBoard = new Board();
        chessBoard.PrintBoardNew(board);
    }
}
