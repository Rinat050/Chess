using System;

namespace ChessCore
{
    class King : Piece
    {
        public King(string name, string sell) : base(name, sell) { }
        public King(string name, int x, int y) : base(name, x, y) { }

        protected override bool isRightMove(int x1, int y1)
        {
            return Math.Abs(x - x1) <= 1 && Math.Abs(y - y1) <= 1;
        }
    }
}