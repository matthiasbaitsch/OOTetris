namespace OOTetris.Tests;

using OOTetris;

public class PieceTest
{
    [Fact]
    public void TestRotate()
    {
        Piece p = Piece.MakePiece(Piece.Type.L);

        Assert.Equal(0, p.Rotation);
        p.Rotation++;
        Assert.Equal(1, p.Rotation);
        p.Rotation++;
        Assert.Equal(2, p.Rotation);
        p.Rotation++;
        Assert.Equal(3, p.Rotation);
        p.Rotation++;
        Assert.Equal(0, p.Rotation);
        p.Rotation--;
        Assert.Equal(3, p.Rotation);
    }
}
