using System.Diagnostics;

namespace Leetx.Tools.LinkedLists;

/// <summary>
/// Leetcode data structure
/// </summary>
[DebuggerDisplay("{val}, next: {next?.val}")]
public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}