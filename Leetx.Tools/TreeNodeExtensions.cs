namespace Leetx.Tools;

public static class TreeNodeExtensions
{
    public static TreeNode? FindByValue(this TreeNode? root, int val)
    {
        if (root == null || root.val == val)
        {
            return root;
        }

        return FindByValue(root.left, val) ?? FindByValue(root.right, val);
    }

    public static int?[] SelectValuesToArray(this TreeNode? head)
    {
        return TreeReader.SelectValuesToArray(head);
    }
}