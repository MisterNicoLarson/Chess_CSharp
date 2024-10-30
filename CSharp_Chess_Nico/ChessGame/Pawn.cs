public class Pawn : Piece
{
    public Pawn(string color, (int x, int y) position) : base(color, position) { }

    public override bool IsValidMove((int x, int y) newPosition, Board board)
    {
        int direction = Color == "White" ? 1 : -1; 
        int distance = Math.Abs(newPosition.y - Position.y);

        // First move: two squares forward
        if (Position.y == (Color == "White" ? 1 : 6) && distance == 2 && newPosition.x == Position.x)
        {
            return board.IsSquareEmpty(newPosition.x,newPosition.y) && board.IsSquareEmpty(newPosition.x, newPosition.y - direction);
        }

        // Single square forward
        if (distance == 1 && newPosition.x == Position.x)
        {
            return board.IsSquareEmpty(newPosition.x,newPosition.y);
        }

        // Diagonal capture
        if (distance == 1 && Math.Abs(newPosition.x - Position.x) == 1)
        {
            return !board.IsSquareEmpty(newPosition.x,newPosition.y) && board.GetPieceAt(newPosition.x,newPosition.y).Color != Color;
        }

        // Pawn promotion
        if ((newPosition.y == 0 && Color == "White") || (newPosition.y == 7 && Color == "Black"))
        {
            // Additional logic for promotion
            return true;
        }

        return false;
    }
}
