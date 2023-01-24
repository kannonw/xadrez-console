using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez_console.table;
using Xadrez_console.table.enums;

namespace Xadrez_console.chess
{
    internal class Knight : Piece
    {
        public Knight(Color color, Table table) : base(color, table)
        {
        }

        public override string ToString()
        {
            return "N";
        }
    }
}
