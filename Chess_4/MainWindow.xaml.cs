using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
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
                    var piece = PieceFab.Make(pieceData);

                    var pieceBtn = GetButton(piece.x, piece.y);
                    pieceBtn.Content = piece.Name;
                    pieces.Add(piece);
                }
                catch
                {
                    MessageBox.Show("The piece could not be added.", "Warning");
                }
            }
        }

        private Button GetButton(int col, int row)
        {
            var r = Math.Abs(row - 9);

            foreach(Button btn in Grid.Children)
            {
                if (Grid.GetRow(btn) == r && Grid.GetColumn(btn) == col)
                {
                    return btn;
                }
            }

            return null;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var cellCoordinates = tbCoordinates.Text;

            for (int i = 0; i < pieces.Count; ++i)
            {
                var piece = pieces[i];
                if (piece.GetCoordinates() == cellCoordinates)
                {
                    var pieceBtn = GetButton(piece.x, piece.y);
                    pieceBtn.Content = "";
                    pieces.Remove(piece);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            var row = Math.Abs(Grid.GetRow(btn) - 9);
            var col = Grid.GetColumn(btn);

            if (!piecesNames.Contains(btn.Content.ToString()) && currentPiece != null)
            {
                var oldBtn = GetButton(currentPiece.x, currentPiece.y);

                if (currentPiece.Move(col, row))
                {
                    btn.Content = currentPiece.Name;             
                    oldBtn.Content = "";
                    currentPiece = null;
                }
                return;
            }
            
            if (btn.Content != "")
            {
                currentPiece = GetPiece(col,row);
            }
        }

        private Piece GetPiece(int col, int row)
        {
            foreach (var piece in pieces)
            {
                if (piece.x == col && piece.y == row)
                {
                    return piece;
                }
            }
            return null;
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button currentBtn = (Button)sender;
            int row = ConvertToGridCoordinate(Grid.GetRow(currentBtn));
            int col = Grid.GetColumn(currentBtn);

            if (currentPiece != null && currentBtn.Content == "")
            {
                currentBtn.Content = currentPiece.TryMove(col, row) ? "YES" : "NO";
            }
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button currentBtn = (Button)sender;
            string btnContent = currentBtn.Content.ToString();

            if (btnContent == "YES" || btnContent == "NO")
            {
                currentBtn.Content = "";
            }
        }

        private int ConvertToGridCoordinate(int y)
        {
            return Math.Abs(y - 9);
        }
    }
}