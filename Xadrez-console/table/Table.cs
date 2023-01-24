using System;

namespace Xadrez_console.table
{
    internal class Table
    {
        public int Row { get; set; }
        public int Column { get; set; }
        private Piece[,] _piece;

        public Table(int row, int column)
        {
            Row = row;
            Column = column;
            _piece= new Piece[row, column];
        }

        public Piece GetPiece(int row, int column)
        {
            return _piece[row, column];
        }

        public void InsertPiece(Piece piece, Position position)
        {
            _piece[position.Row, position.Column] = piece;
            piece.Position = position;
        }
    }
}
