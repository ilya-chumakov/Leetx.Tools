using Leetx.Tools.ListsOfLists;
using Xunit.Sdk;

namespace Leetx.Tools.Tests.ListsOfLists;

public class LolAssert_NoOrder_Tests
{
    public static void TryEqual(bool areEqual, int[][] expected, int[][] actual)
    {
        try
        {
            LolAssert.Equal(expected, actual,
                keepCellOrder: false,
                keepRowOrder: false);
        }
        catch (EqualException)
        {
            if (areEqual) throw;
        }
    }

    [Theory]
    [InlineData(6, true)]
    public void Equal_3x3_OK(int a, bool areEqual)
    {
        var expected = new[]
        {
            new[] { 1, 1, 6 },
            new[] { 1, 2, 5 },
            new[] { 1, 7 },
            new[] { 2, 6 }
        };
        var actual = new[]
        {
            new[] { a, 1, 1 },
            new[] { 5, 1, 2 },
            new[] { 7, 1 },
            new[] { 6, 2 }
        };

        TryEqual(areEqual, expected, actual);
    }
}