using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class BoardRenderer
    {
        public void Draw(Board board)
        {
            char[,] symbols = new char[3, 3];
            symbols[0, 0] = DisplayTicOrToe(board.ContentsOf(0, 0));
            symbols[0, 1] = DisplayTicOrToe(board.ContentsOf(0, 1));
            symbols[0, 2] = DisplayTicOrToe(board.ContentsOf(0, 2));
            symbols[1, 0] = DisplayTicOrToe(board.ContentsOf(1, 0));
            symbols[1, 1] = DisplayTicOrToe(board.ContentsOf(1, 1));
            symbols[1, 2] = DisplayTicOrToe(board.ContentsOf(1, 2));
            symbols[2, 0] = DisplayTicOrToe(board.ContentsOf(2, 0));
            symbols[2, 1] = DisplayTicOrToe(board.ContentsOf(2, 1));
            symbols[2, 2] = DisplayTicOrToe(board.ContentsOf(2, 2));

            Console.WriteLine($" {symbols[0, 0]} | {symbols[0, 1]} | {symbols[0, 2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {symbols[1, 0]} | {symbols[1, 1]} | {symbols[1, 2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {symbols[2, 0]} | {symbols[2, 1]} | {symbols[2, 2]}");
        }

        private char DisplayTicOrToe(Cell cell) => cell switch { Cell.X => 'X', Cell.O => 'O', Cell.Empty => ' ' };
    }

    public class Square
    {
        public int Row { get; }
        public int Column { get; }

        public Square(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }

    public class Board
    {
        private readonly Cell[,] _cells = new Cell[3, 3];

        public Cell ContentsOf(int row, int column) => _cells[row, column];
        public void FillCell(int row, int column, Cell value) => _cells[row, column] = value;
        public bool IsEmpty(int row, int column) => _cells[row, column] == Cell.Empty;
    }

    public enum Cell { Empty, X, O }
}
