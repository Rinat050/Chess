//Safiullin Rinat, 220P, Chess_4, 21.06.22
namespace ChessCore
{
    public class Rook : Piece
    {
        public Rook(string name, string sell) : base(name, sell) { }
        public Rook(string name, int x, int y) : base(name, x, y) { }

        protected override bool isRightMove(int x1, int y1)
        {
            return x == x1 || y == y1;
        }
    }
}