public class Rook : Piece
{
    public Rook(string color, (int x, int y) position) : base(color, position) { }

    public override bool IsValidMove((int x, int y) newPosition, Board board)
    {
        // Vérifie que le mouvement est en ligne droite
        if (newPosition.x == Position.x || newPosition.y == Position.y)
        {
            // Vérifie que le chemin est libre
            return board.IsPathClear(Position, newPosition) && (board.GetPieceAt(newPosition.x,newPosition.y) == null || board.GetPieceAt(newPosition.x,newPosition.y).Color != this.Color);
        }

        return false;
    }
}
