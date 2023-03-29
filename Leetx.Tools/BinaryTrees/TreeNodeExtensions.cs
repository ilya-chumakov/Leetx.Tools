namespace Leetx.Tools.BinaryTrees;

public static class TreeNodeExtensions
{
    public static TreeNode? FindByValue(this TreeNode? root, int val)
    {
        if (root == null || root.val == val)
        {
            return root;
        }

        return root.left.FindByValue(val) ?? root.right.FindByValue(val);
    }

    public static int?[] SelectValuesToArray(this TreeNode? head)
    {
        return TreeReader.SelectValuesToArray(head);
    }
}