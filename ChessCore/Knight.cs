using System;

namespace ChessCore
{
    public class Knight : Piece
    {
        public Knight(string name, string sell) : base(name, sell) { }
        public Knight(string name, int x, int y) : base(name, x, y) { }

        protected override bool isRightMove(int x1, int y1)
        {
            return (Math.Abs(x - x1) == 2 && Math.Abs(y - y1) == 1) ||
                   (Math.Abs(x - x1) == 1 && Math.Abs(y - y1) == 2);
        }
    }
}