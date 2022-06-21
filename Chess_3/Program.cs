//Safiullin Rinat, 220P, Chess_4, 21.06.22
using System;
using ChessCore;

namespace Chess3
{
    class Program
    {
        static void Main(string[] args)
        {
            string chessName = Console.ReadLine();
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                Piece piece = PieceFab.Make(chessName, x1, y1);
                Console.WriteLine(piece.Move(x2, y2) ? "YES" : "NO");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}