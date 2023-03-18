namespace Leetx.Tools;

public static class LinkedListReader
{
    public static int[] GetValues(ListNode? head)
    {
        if (head == null) return new int[0];

        var values = new List<int>();
        while (head != null)
        {
            values.Add(head.val);
            head = head.next;
        }
        return values.ToArray();
    }
}