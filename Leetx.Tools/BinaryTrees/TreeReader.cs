namespace Leetx.Tools.BinaryTrees;

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
            if (node != null)
            {
                children.Enqueue((node?.left, nodeLevel + 1));
                children.Enqueue((node?.right, nodeLevel + 1));
            }
        }

        //trim nulls
        var flatten = levels.SelectMany(x => x).ToList();

        while (flatten.LastIndexOf(null) == flatten.Count - 1
               && flatten.Count > 0)
        {
            flatten.RemoveAt(flatten.Count - 1);
        }

        return flatten.ToArray();
    }
}