﻿namespace ChessCore
{
    class Rook : Piece
    {
        public Rook(string name, string sell) : base(name, sell) { }
        public Rook(string name, int x, int y) : base(name, x, y) { }

        protected override bool isRightMove(int x1, int y1)
        {
            return x == x1 || y == y1;
        }
    }
}