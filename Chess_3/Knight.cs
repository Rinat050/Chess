//Safiullin Rinat, 220P, 15.04.2022, Шахматные фигуры - 3
using System;

namespace Chess3
{
    class Knight : Piece
    {
        public Knight(string sell) : base(sell) { }
        public Knight(int x, int y) : base(x, y) { }

        protected override bool isRightMove(int x1, int y1)
        {
            return (Math.Abs(x - x1) == 2 && Math.Abs(y - y1) == 1) || 
                   (Math.Abs(x - x1) == 1 && Math.Abs(y - y1) == 2);
        }
    }
}