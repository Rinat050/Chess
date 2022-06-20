using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using ChessCore;

namespace Chess_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> piecesNames = new List<string>() 
                                {"Bishop", "King", "Knight", "Pawn", "Queen", "Rook"};
        private List<Piece> pieces;
        private Piece currentPiece;

        public MainWindow()
        {
            InitializeComponent();
            cbPiece.ItemsSource = piecesNames;
            pieces = new List<Piece>();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (cbPiece.SelectedItem != null)
            {
                try
                {
                    var pieceName = cbPiece.SelectedItem.ToString();
                    var cellCoordinates = tbCoordinates.Text;
                    var pieceData = new PieceData(pieceName, cellCoordinates);
                    currentPiece = PieceFab.Make(pieceData);

                    var PieceBtn = GetButton(currentPiece.x, Math.Abs(currentPiece.y - 9));
                    PieceBtn.Content = currentPiece.Name;
                }
                catch
                {
                    MessageBox.Show("The piece could not be added.", "Warning");
                }
            }
        }

        private Button GetButton(int col, int row)
        {
            foreach(Button btn in Grid.Children)
            {
                if (Grid.GetRow(btn) == row && Grid.GetColumn(btn) == col)
                {
                    return btn;
                }
            }

            return null;
        }
    }
}