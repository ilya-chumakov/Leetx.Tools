using Leetx.Tools.LinkedLists;

namespace Leetx.Tools.ListsOfLists;

public static class LolAssert
{
    public static void Equal(
        IList<IList<int>> expected,
        IList<IList<int>> actual,
        SortingPolicy sortingPolicy = SortingPolicy.KeepOriginalOrder)
    {
        if (sortingPolicy == SortingPolicy.KeepOriginalOrder)
        {
            Assert.Equal(expected, actual);
        }
        else
        {
            var expectedPrepared = CopyBuilder.CreateOrderedCopy(expected, sortingPolicy);
            var actualPrepared = CopyBuilder.CreateOrderedCopy(actual, sortingPolicy);

            Assert.Equal(expectedPrepared, actualPrepared);
        }
    }
}