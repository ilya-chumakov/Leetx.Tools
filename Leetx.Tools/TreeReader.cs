namespace Leetx.Tools;

public static class TreeReader
{
    /// <summary>
    /// based on Problem 102:
    /// https://leetcode.com/problems/binary-tree-level-order-traversal/
    /// </summary>
    public static int?[] SelectValuesToArray(TreeNode? root)
    {
        if (root == null) return new int?[] { };

        var levels = new List<List<int?>>();
        var children = new Queue<(TreeNode root, int level)>();

        children.Enqueue((root, 0));

        while (children.Count > 0)
        {
            (var node, int nodeLevel) = children.Dequeue();

            //handle 
            if (levels.Count == nodeLevel)
            {
                levels.Add(new List<int?>());
            }
            levels[nodeLevel].Add(node?.val);

            //enqueue children
            if (node?.left != null || node?.right != null)
            {
                children.Enqueue((node?.left, nodeLevel + 1));
                children.Enqueue((node?.right, nodeLevel + 1));
            }
        }

        //trim nulls
        var last = levels.Last();
        while (last.LastIndexOf(null) == last.Count - 1)
        {
            last.RemoveAt(last.Count - 1);
        }

        return levels.SelectMany(x => x).ToArray();
    }
}