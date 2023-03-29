namespace Leetx.Tools.LinkedLists;

public static class CopyBuilder
{
    public static IList<IList<int>> CreateOrderedCopy(IList<IList<int>> origin)
    {
        var copy = new List<IList<int>>(origin);
        //OrderRows(copy);
        copy.Sort(new ListComparer());
        return copy;
    }

    private static void OrderRows(IList<IList<int>> rows)
    {
        for (int i = 0; i < rows.Count; i++)
        {
            rows[i] = rows[i].OrderBy(num => num).ToArray();
        }
    }
}