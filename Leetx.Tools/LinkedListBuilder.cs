namespace Leetx.Tools;

public class LinkedListBuilder
{
    public static ListNode? Create(IList<int> values)
    {
        ListNode? tail = null;
        for (int i = values.Count - 1; i >= 0; i--)
        {
            var node = new ListNode(values[i], tail);
            tail = node;
        }

        return tail;
    }
}