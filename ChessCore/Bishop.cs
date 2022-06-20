using System;

namespace ChessCore
{
    public class Bishop : Piece
    {
        public Bishop(string name, string sell) : base(name, sell) { }
        public Bishop(string name, int x, int y) : base(name, x, y) { }

        protected override bool isRightMove(int x1, int y1)
        {
            return Math.Abs(x - x1) == Math.Abs(y - y1);
        }
    }
}