using Leetx.Tools.ListsOfLists;

namespace Leetx.Tools.LinkedLists;

public static class CopyBuilder
{
    public static IList<IList<int>> CreateOrderedCopy(
        IList<IList<int>> origin,
        SortingPolicy policy)
    {
        if (policy == SortingPolicy.KeepOriginalOrder)
            throw new ArgumentException("invalid param value", nameof(policy));

        var copy = new List<IList<int>>(origin);

        if (policy == SortingPolicy.CellsThenRows)
        {
            for (int i = 0; i < copy.Count; i++)
            {
                copy[i] = copy[i].OrderBy(num => num).ToArray();
            }
        }

        copy.Sort(new ListComparer());
        return copy;
    }
}