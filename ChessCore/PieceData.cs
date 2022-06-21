//Safiullin Rinat, 220P, Chess_4, 21.06.22
namespace ChessCore
{
    public class PieceData
    {
        public string Name;
        public string Coordinates;

        public PieceData (string Name, string Coordinates)
        {
            this.Name = Name;
            this.Coordinates = Coordinates;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}