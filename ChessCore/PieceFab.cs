//Safiullin Rinat, 220P, Chess_4, 21.06.22
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
                    piece = new Bishop(pieceData.Name, pieceData.Coordinates);
                    break;
                case "King":
                    piece = new King(pieceData.Name, pieceData.Coordinates);
                    break;
                case "Knight":
                    piece = new Knight(pieceData.Name, pieceData.Coordinates);
                    break;
                case "Queen":
                    piece = new Queen(pieceData.Name, pieceData.Coordinates);
                    break;
                case "Rook":
                    piece = new Rook(pieceData.Name, pieceData.Coordinates);
                    break;
                case "Pawn":
                    piece = new Pawn(pieceData.Name, pieceData.Coordinates);
                    break;
            }

            return piece;
        }
    }
}