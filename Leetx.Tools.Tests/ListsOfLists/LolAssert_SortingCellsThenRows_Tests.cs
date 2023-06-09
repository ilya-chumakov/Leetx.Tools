using Leetx.Tools.ListsOfLists;
using Xunit.Sdk;

namespace Leetx.Tools.Tests.ListsOfLists;

public class LolAssert_SortingCellsThenRows_Tests
{
    public static void TryEqual(bool areEqual, int[][] expected, int[][] actual)
    {
        try
        {
            LolAssert.Equal(expected, actual, SortingPolicy.CellsThenRows);
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
    [InlineData(5, false)]
    [InlineData(6, true)]
    public void Equal_Complex_OK(int a, bool areEqual)
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