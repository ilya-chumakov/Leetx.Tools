using Leetx.Tools.LinkedLists;

namespace Leetx.Tools.ListsOfLists;

public class LolSortedComparer :
    ListComparer,
    IEqualityComparer<IList<int>>
{
    public bool Equals(IList<int>? x, IList<int>? y)
    {
        var xcopy = x.OrderBy(e => e).ToArray();
        var ycopy = y.OrderBy(e => e).ToArray();

        return Compare(xcopy, ycopy) == 0;
    }

    public int GetHashCode(IList<int> obj)
    {
        //it's unused, so this method is a pure formality
        throw new NotImplementedException();
    }
}