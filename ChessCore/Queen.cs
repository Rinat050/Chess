using System;

namespace ChessCore
{
    internal class Queen : Piece
    {
        public Queen(string name, string sell) : base(name, sell) { }
        public Queen(string name, int x, int y) : base(name, x, y) { }

        protected override bool isRightMove(int x1, int y1)
        {
            return (Math.Abs(x - x1) == Math.Abs(y - y1)) ||
                   (x == x1 || y == y1);
        }
    }
}