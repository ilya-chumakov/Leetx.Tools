using Leetx.Tools.LinkedLists;

namespace Leetx.Tools.ListsOfLists;

public static class LolAssert
{
    public static void Equal(
        IList<IList<int>> expected,
        IList<IList<int>> actual,
        bool keepRowOrder = true,
        bool keepCellInRowOrder = true)
    {
        Assert.Equal(expected.Count, actual.Count);

        var expectedPrepared = keepRowOrder
            ? expected
            : CopyBuilder.CreateOrderedCopy(expected);

        var actualPrepared = keepRowOrder
            ? actual
            : CopyBuilder.CreateOrderedCopy(actual);

        if (keepCellInRowOrder)
        {
            Assert.Equal(expectedPrepared, actualPrepared);
        }
        else
        {
            Assert.Equal(expectedPrepared, actualPrepared, new LolSortedComparer());
        }
    }
}