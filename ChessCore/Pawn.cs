namespace ChessCore
{
    class Pawn : Piece
    {
        public Pawn(string name, string sell) : base(name, sell) { }
        public Pawn(string name, int x, int y) : base(name, x, y) { }

        protected override bool isRightMove(int x1, int y1)
        {
            return y < y1 && x == x1 && (y + 1 == y1 || y + 2 == y1);
        }
    }
}