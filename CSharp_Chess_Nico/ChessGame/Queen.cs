public class Queen : Piece
{
    public Queen(string color, (int x, int y) position) : base(color, position) { }

    public override bool IsValidMove((int x, int y) newPosition, Board board)
    {
        int deltaX = Math.Abs(newPosition.x - Position.x);
        int deltaY = Math.Abs(newPosition.y - Position.y);

        // Vérification de mouvement en ligne droite ou en diagonale
        if (deltaX == deltaY || newPosition.x == Position.x || newPosition.y == Position.y)
        {
            // Vérifie que le chemin est libre pour éviter d'autres pièces
            return board.IsPathClear(Position, newPosition) && (board.GetPieceAt(newPosition.x,newPosition.y) == null || board.GetPieceAt(newPosition.x,newPosition.y).Color != this.Color);
        }

        return false;
    }
}
