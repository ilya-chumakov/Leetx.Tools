namespace Leetx.Tools.BinaryTrees;

public static class TreeBuilder
{
    /// <summary>
    ///https://support.leetcode.com/hc/en-us/articles/360011883654-What-does-1-null-2-3-mean-in-binary-tree-representation-
    /// 
    /// algorithm based on https://www.datastructurex.com/ (input format is different)
    /// Leetcode-based visualiser https://eniac00.github.io/btv/
    /// </summary>
    public static TreeNode CreateBinaryTree(int?[] values)
    {
        int n = values.Length;
        if (n == 0) return null;

        var nodes = new TreeNode[n];

        for (int i = 0; i < n; i++)
        {
            if (values[i] != null)
            {
                nodes[i] = new TreeNode(values[i]!.Value);
            }
        }

        int preNull = 0;
        for (int i = 0; i < n; i++)
        {
            if (nodes[i] == null)
            {
                preNull++;
            }
            else
            {
                int leftIdx = 2 * i + 1 - preNull * 2;
                if (leftIdx >= n)
                {
                    break;
                }
                nodes[i].left = nodes[leftIdx];

                int rightIdx = 2 * i + 2 - preNull * 2;
                if (rightIdx >= n)
                {
                    break;
                }

                nodes[i].right = nodes[rightIdx];
            }
        }
        return nodes[0];
    }
}