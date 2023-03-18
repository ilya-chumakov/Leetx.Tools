namespace Leetx.Tools;

public static class LinkedListReaderExtensions
{
    public static int[] SelectValuesToArray(this ListNode? head)
    {
        return LinkedListReader.GetValues(head);
    }
}