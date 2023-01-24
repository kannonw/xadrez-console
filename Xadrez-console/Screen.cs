using System;
using Xadrez_console.table;

namespace Xadrez_console
{
    internal class Screen
    {
        public static void PrintTable(Table table)
        {
            for (int r = 0; r < table.Row; r++)
            {
                for (int c = 0; c < table.Column; c++)
                {
                    Piece piece = table.GetPiece(r, c);

                    if (piece != null)
                    {
                        Console.Write(piece.ToString(), " ");
                    } else
                    {
                        Console.Write("· ");
                    }    
                }
                Console.WriteLine();
            }
        }
    }
}
