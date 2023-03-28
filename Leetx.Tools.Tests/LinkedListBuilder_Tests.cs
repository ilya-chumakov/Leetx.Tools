namespace Leetx.Tools.Tests;

public class LinkedListBuilder_Tests
{
    [Fact]
    public void Create_Default_OK()
    {
        var actual = LinkedListBuilder.Create(new[] { 3, 2, 1});
        Assert.Equal(3, actual.val);
        Assert.Equal(2, actual.next.val);
        Assert.Equal(1, actual.next.next.val);
        Assert.Null(actual.next.next.next);
    }

    [Fact]
    public void Create_Empty_RN()
    {
        var actual = LinkedListBuilder.Create(new int[] { });
        Assert.Null(actual);
    }

    [Fact]
    public void Create_Null_RN()
    {
        var actual = LinkedListBuilder.Create(null);
        Assert.Null(actual);
    }
}