using System;
using Xadrez_console.chess;
using Xadrez_console.table;
using Xadrez_console.table.enums;

namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table(8,8);

            table.InsertPiece(new Rook(Color.White, table), new Position(0, 0));
            table.InsertPiece(new Rook(Color.White, table), new Position(1, 1));

            Screen.PrintTable(table);
        }
    }
}