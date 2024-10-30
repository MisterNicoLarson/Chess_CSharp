public class King : Piece
{
    public King(string color, (int x, int y) position) : base(color, position) { }

    public override bool IsValidMove((int x, int y) newPosition, Board board)
    {
        int deltaX = Math.Abs(newPosition.x - Position.x);
        int deltaY = Math.Abs(newPosition.y - Position.y);

        if (deltaX <= 1 && deltaY <= 1)
        {
            Piece targetPiece = board.GetPieceAt(newPosition.x,newPosition.y);
            return targetPiece == null || targetPiece.Color != this.Color;
        }

        return false;
    }
}
