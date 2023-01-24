using System;
using Xadrez_console.table;

namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table(8,8);

            Screen.PrintTable(table);
        }
    }
}