namespace Leetx.Tools.BinaryTrees;

public static class TreeAssert
{
    public static void Equal(TreeNode? expected, TreeNode? actual)
    {
        Assert.Equal(expected.SelectValuesToArray(), actual.SelectValuesToArray());
    }

    public static void NotEqual(TreeNode? expected, TreeNode? actual)
    {
        Assert.NotEqual(expected.SelectValuesToArray(), actual.SelectValuesToArray());
    }
}