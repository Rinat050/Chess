namespace ChessCore
{
    static public class PieceFab
    {
        public static Piece Make(PieceData pieceData)
        {
            Piece piece = null;

            switch (pieceData.Name)
            {
                case "Bishop":
                    piece = new Bishop(pieceData.Name, pieceData.Cell);
                    break;
                case "King":
                    piece = new King(pieceData.Name, pieceData.Cell);
                    break;
                case "Knight":
                    piece = new Knight(pieceData.Name, pieceData.Cell);
                    break;
                case "Queen":
                    piece = new Queen(pieceData.Name, pieceData.Cell);
                    break;
                case "Rook":
                    piece = new Rook(pieceData.Name, pieceData.Cell);
                    break;
                case "Pawn":
                    piece = new Pawn(pieceData.Name, pieceData.Cell);
                    break;
            }

            return piece;
        }
    }
}