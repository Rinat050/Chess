//Safiullin Rinat, 220P, 15.04.2022, Шахматные фигуры - 3
namespace Chess3
{
    class Program
    {
        static void Main(string[] args)
        {
            King king = new King("A1");
            king.PrintCoordinates();
            king.Move("B2");
            king.PrintCoordinates();

            Bishop bishop = new Bishop(4, 4);
            bishop.PrintCoordinates();
            bishop.Move("E5");
            bishop.PrintCoordinates();

            Knight knight = new Knight("A1");
            knight.PrintCoordinates();
            knight.Move("B3");
            knight.PrintCoordinates();

            Rook rook = new Rook("D4");
            rook.PrintCoordinates();
            rook.Move("D7");
            rook.PrintCoordinates();

            Queen queen = new Queen("A7");
            queen.PrintCoordinates();
            queen.Move("A2");
            queen.PrintCoordinates();
        }
    }
}