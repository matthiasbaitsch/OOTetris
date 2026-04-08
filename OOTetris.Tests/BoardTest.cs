namespace OOTetris.Tests;

using OOTetris;

public class BoardTest
{
    [Fact]
    public void TestFit()
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
}
