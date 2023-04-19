using Leetx.Tools.ListsOfLists;
using Xunit.Sdk;

namespace Leetx.Tools.Tests.ListsOfLists;

public class LolAssert_CellOrder_Tests
{
    public static void TryEqual(bool areEqual, int[][] expected, int[][] actual)
    {
        try
        {
            LolAssert.Equal(expected, actual, keepCellOrder: false);
        }
        catch (EqualException)
        {
            if (areEqual) throw;
        }
    }

    [Theory]
    [InlineData(2, false)]
    [InlineData(3, true)]
    public void Equal_3x3_OK(int a, bool areEqual)
    {
        var expected = new[]
        {
            new[] { 1, 2, 3 },
            new[] { 3, 4, 5 },
            new[] { 7, 7, 8 }
        };
        var actual = new[]
        {
            new[] { a, 2, 1 },
            new[] { 3, 4, 5 },
            new[] { 7, 8, 7 }
        };

        TryEqual(areEqual, expected, actual);
    }

    [Theory]
    [InlineData(2, false)]
    [InlineData(3, true)]
    public void Equal_Row_OK(int a, bool areEqual)
    {
        var expected = new[]
        {
            new[] { 0, 1, 2, 3 }
        };
        var actual = new[]
        {
            new[] { 0, 2, a, 1 }
        };

        TryEqual(areEqual, expected, actual);
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(3, false)]
    public void Equal_Column_OK(int a, bool areEqual)
    {
        var expected = new[]
        {
            new[] { 0 },
            new[] { 1 },
            new[] { 2 }
        };
        var actual = new[]
        {
            new[] { 0 },
            new[] { 1 },
            new[] { a }
        };

        TryEqual(areEqual, expected, actual);
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(3, false)]
    public void Equal_Single_OK(int a, bool areEqual)
    {
        var expected = new[]
        {
            new[] { 2 }
        };
        var actual = new[]
        {
            new[] { a }
        };

        TryEqual(areEqual, expected, actual);
    }

    [Fact]
    public void Equal_DifferentSize_Fail()
    {
        var expected = new[]
        {
            new[] { 2, 3 },
            new[] { 2, 3 }
        };
        var actual = new[]
        {
            new[] { 2, 3 },
            new[] { 2, 3, 4 }
        };

        TryEqual(false, expected, actual);
    }
}