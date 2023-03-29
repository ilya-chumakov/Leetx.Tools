using Leetx.Tools.BinaryTrees;

namespace Leetx.Tools.Tests.BinaryTrees;

public class TreeEquality_Tests
{
    [Fact]
    public void SelectValuesToArray_Equal_OK()
    {
        var expected = TreeBuilder.CreateBinaryTree(new int?[] { 1, null, 2 });
        var actual = TreeBuilder.CreateBinaryTree(new int?[] { 1, null, 2 });
        TreeAssert.Equal(expected, actual);
    }

    [Fact]
    public void SelectValuesToArray_NotEqual_OK()
    {
        var expected = TreeBuilder.CreateBinaryTree(new int?[] { 1, 2 });
        var actual = TreeBuilder.CreateBinaryTree(new int?[] { 1, null, 2 });
        TreeAssert.NotEqual(expected, actual);
    }
}