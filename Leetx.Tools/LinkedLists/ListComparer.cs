namespace Leetx.Tools.LinkedLists;

public class ListComparer : IComparer<IList<int>>
{
    public int Compare(IList<int> x, IList<int> y)
    {
        if (x.Count != y.Count)
        {
            return x.Count - y.Count;
        }

        for (int i = 0; i < x.Count; i++)
        {
            if (x[i] != y[i])
            {
                return x[i].CompareTo(y[i]);
            }
        }
        return 0;
    }
}