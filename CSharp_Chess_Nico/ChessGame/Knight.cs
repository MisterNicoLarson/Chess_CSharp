public class Knight : Piece
{
    public Knight(string color, (int x, int y) position) : base(color, position) { }

    public override bool IsValidMove((int x, int y) newPosition, Board board)
    {
        int deltaX = Math.Abs(newPosition.x - Position.x);
        int deltaY = Math.Abs(newPosition.y - Position.y);

        // Le mouvement doit être en forme de "L"
        bool isLShape = (deltaX == 2 && deltaY == 1) || (deltaX == 1 && deltaY == 2);

        // Vérifie que la case cible est soit vide, soit occupée par une pièce de l'adversaire
        return isLShape && (board.GetPieceAt(newPosition.x,newPosition.y) == null || board.GetPieceAt(newPosition.x,newPosition.y).Color != this.Color);
    }
}
