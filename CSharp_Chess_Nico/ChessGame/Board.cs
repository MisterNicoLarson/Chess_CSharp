public class Board
{
    public Piece[][] squares;

    public Board()
    {
        squares = new Piece[8][];
        for (int i = 0; i < 8; i++)
        {
            squares[i] = new Piece[8];
        }
    }

    public Piece GetPieceAt(int x, int y)
    {
        if (IsValidPosition(x, y))
        {
            return squares[x][y];
        }
        return null;
    }

    public void SetPieceAt(int x, int y, Piece piece)
    {
        if (IsValidPosition(x, y))
        {
            squares[x][y] = piece;
        }
    }

    public bool IsSquareEmpty(int x, int y)
    {
        return GetPieceAt(x, y) == null;
    }

    private bool IsValidPosition(int x, int y)
    {
        return x >= 0 && x < 8 && y >= 0 && y < 8;
    }

        public bool IsPathClear((int x, int y) start, (int x, int y) end)
    {
        int deltaX = Math.Sign(end.x - start.x);
        int deltaY = Math.Sign(end.y - start.y);

        int currentX = start.x + deltaX;
        int currentY = start.y + deltaY;

        while (currentX != end.x || currentY != end.y)
        {
            if (GetPieceAt(currentX, currentY) != null)
                return false;

            currentX += deltaX;
            currentY += deltaY;
        }

        return true;
    }
}
