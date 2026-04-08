namespace OOTetris.Tests;

using OOTetris;

public class BoardTest
{
    [Fact]
    public void TestCanMovePiece()
    {
        Board b = new Board();
        b.TryPutPiece(Piece.MakePiece(Piece.Type.O));
        b.MovePiece(0, -4);
        Assert.True(b.CanMovePiece(0, 0));
        Assert.True(b.CanMovePiece(18, 8));
        Assert.True(b.CanMovePiece(1, 1));
        Assert.False(b.CanMovePiece(Board.Height - 1, 0));
        Assert.False(b.CanMovePiece(0, Board.Width - 1));
        Assert.False(b.CanMovePiece(-1, 0));
        Assert.False(b.CanMovePiece(0, -1));
    }

    [Fact]
    public void TestClearRowsEmpty()
    {
        Board board = new Board();
        Assert.Equal(0, board.ClearRows());
    }

    [Fact]
    public void TestClearRowsOneRow()
    {
        Board board = new Board();
        board.TryPutPiece(Piece.MakePiece(Piece.Type.I));
        board.MovePiece(19, -4);
        board.Place();
        board.TryPutPiece(Piece.MakePiece(Piece.Type.I));
        board.MovePiece(19, 0);
        board.Place();
        board.TryPutPiece(Piece.MakePiece(Piece.Type.O));
        board.MovePiece(18, 4);
        board.Place();
        Assert.Equal(1, board.ClearRows());
    }

    [Fact]
    public void TestClearRowsTwoRows()
    {
        Board board = new Board();

        for (int col = 0; col < Board.Width; col += 2)
        {
            board.TryPutPiece(Piece.MakePiece(Piece.Type.O));
            board.MovePiece(Board.Height - 2, col - (Board.Width / 2 - 1));
            board.Place();
        }
        Assert.Equal(2, board.ClearRows());
    }
}
