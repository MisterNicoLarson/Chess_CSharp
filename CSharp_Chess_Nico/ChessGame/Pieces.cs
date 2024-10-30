public abstract class Piece
{
    public string Color { get; set; }  
    public (int x, int y) Position { get; set; }  

    public Piece(string color, (int x, int y) position)
    {
        Color = color;
        Position = position;
    }

    public abstract bool IsValidMove((int x, int y) newPosition, Board board);

    public void SetPiece(Piece piece, int row, int column, Board board)
    {
        if (row >= 0 && row < 8 && column >= 0 && column < 8)
        {
            board.squares[row][column] = piece;
            piece.Position = new (column, row);
        }
        else
        {
            Console.WriteLine("Invalid case indexes.");
        }
    }
   
    public bool Move((int x, int y) newPosition, Board board)
    {
        if (IsValidMove(newPosition, board))
        {
            Position = newPosition;
            return true;
        }
        return false;
    }
}
