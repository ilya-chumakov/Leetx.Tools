using System.Diagnostics;

namespace Leetx.Tools.BinaryTrees;

/// <summary>
/// Leetcode data structure
/// </summary>
[DebuggerDisplay("{val}, children: {left?.val}, {right?.val}")]
public class TreeNode
{
    public TreeNode? left;
    public TreeNode? right;
    public int val;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}