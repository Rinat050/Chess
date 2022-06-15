//Safiullin Rinat, 220P, 15.04.2022, Шахматные фигуры - 3
namespace Chess3
{
    class Rook : Piece
    {
        public Rook(string sell) : base(sell) { }
        public Rook(int x, int y) : base(x, y) { }

        protected override bool isRightMove(int x1, int y1)
        {
            return x == x1 || y == y1;
        }
    }
}
