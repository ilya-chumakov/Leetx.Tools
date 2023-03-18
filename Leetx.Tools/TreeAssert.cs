namespace Leetx.Tools;

public static class TreeAssert
{
    public static void Equal(TreeNode? expected, TreeNode? actual)
    {
        Xunit.Assert.Equal(expected.SelectValuesToArray(), actual.SelectValuesToArray());
    }

    public static void NotEqual(TreeNode? expected, TreeNode? actual)
    {
        Xunit.Assert.NotEqual(expected.SelectValuesToArray(), actual.SelectValuesToArray());
    }
}