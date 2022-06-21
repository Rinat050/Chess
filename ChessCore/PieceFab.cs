//Safiullin Rinat, 220P, Chess_4, 21.06.22
using System;
using System.Collections.Generic;

namespace ChessCore
{
    static public class PieceFab
    {
        private static Dictionary<char, int> convertationToInt =
            new Dictionary<char, int>()
            {
                {'A',1},
                {'B',2},
                {'C',3},
                {'D',4},
                {'E',5},
                {'F',6},
                {'G',7},
                {'H',8}
            };

        public static Piece Make(string Name, int x, int y)
        {
            Piece piece = null;

            switch (Name)
            {
                case "Bishop":
                case "B":
                    piece = new Bishop(Name, x, y);
                    break;
                case "King":
                case "K":
                    piece = new King(Name, x, y);
                    break;
                case "Knight":
                case "N":
                    piece = new Knight(Name, x, y);
                    break;
                case "Queen":
                case "Q":
                    piece = new Queen(Name, x, y);
                    break;
                case "Rook":
                case "R":
                    piece = new Rook(Name, x, y);
                    break;
                case "Pawn":
                case "P":
                    piece = new Pawn(Name, x, y);
                    break;
                default: throw new Exception("Unknown piece Name");
            }

            return piece;
        }

        public static Piece Make(string Name, string coordinates)
        {
            int x = convertationToInt[coordinates[0]];
            int y = Convert.ToInt32(coordinates[1].ToString());
            return Make(Name, x, y);
        }
    }
}