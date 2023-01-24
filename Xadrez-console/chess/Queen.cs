using System;
using Xadrez_console.table;
using Xadrez_console.table.enums;

namespace Xadrez_console.chess
{
    internal class Queen : Piece
    {
        public Queen(Color color, Table table) : base(color, table)
        {
        }

        public override string ToString()
        {
            return "Q";
        }
    }
}
