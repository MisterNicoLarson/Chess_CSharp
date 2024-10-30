public class Bishop : Piece
{
    public Bishop(string color, (int x, int y) position) : base(color, position) { }

    public override bool IsValidMove((int x, int y) newPosition, Board board)
    {
        int deltaX = Math.Abs(newPosition.x - Position.x);
        int deltaY = Math.Abs(newPosition.y - Position.y);

        // Vérification que le mouvement est en diagonale
        if (deltaX == deltaY)
        {
            // Vérifie que le chemin est libre
            return board.IsPathClear(Position, newPosition) && (board.GetPieceAt(newPosition.x,newPosition.y) == null || board.GetPieceAt(newPosition.x,newPosition.y).Color != this.Color);
        }

        return false;
    }
}
