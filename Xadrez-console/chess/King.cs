using System;
using Xadrez_console.table;
using Xadrez_console.table.enums;

namespace Xadrez_console.chess
{
    internal class King : Piece
    {
        public King(Color color, Table table) : base(color, table)
        {
        }

        public override string ToString()
        {
            return "K";
        }
    }
}
