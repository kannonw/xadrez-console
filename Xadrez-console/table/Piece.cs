using System;
using Xadrez_console.table.enums;

namespace Xadrez_console.table
{
    internal class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int QtdMoviment { get; protected set; }
        public Table Table { get; protected set; }

        public Piece(Color color, Table table)
        {
            Color = color;
            Table = table;
        }
    }
}
