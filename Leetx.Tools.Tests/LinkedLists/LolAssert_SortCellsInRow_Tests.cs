using Leetx.Tools.LinkedLists;
using Xunit.Sdk;

namespace Leetx.Tools.Tests.LinkedLists;

public class LolAssert_SortCellsInRow_Tests
{
    public static void TryEqual(bool isEqual, int[][] expected, int[][] actual)
    {
        try
        {
            LolAssert.Equal(expected, actual, keepCellInRowOrder: false);
        }
        catch (EqualException)
        {
            if (isEqual) throw;
        }
    }

    [Theory]
    [InlineData(2, false)]
    [InlineData(3, true)]
    public void Equal_Complex_OK(int a, bool isEqual)
    {
        var expected = new[]
        {
            new[] { 1, 2, 3 },
            new[] { 3, 4, 5 },
            new[] { 7, 7, 8 },
        };
        var actual = new[]
        {
            new[] { a, 2, 1 },
            new[] { 3, 4, 5 },
            new[] { 7, 8, 7 },
        };

        TryEqual(isEqual, expected, actual);
    }

    [Theory]
    [InlineData(2, false)]
    [InlineData(3, true)]
    public void Equal_Row_OK(int a, bool isEqual)
    {
        var expected = new[]
        {
            new[] { 0, 1, 2, 3 },
        };
        var actual = new[]
        {
            new[] { 0, 2, a,1 },
        };

        TryEqual(isEqual, expected, actual);
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(3, false)]
    public void Equal_Column_OK(int a, bool isEqual)
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
            new[] { a },
        };

        TryEqual(isEqual, expected, actual);
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(3, false)]
    public void Equal_Single_OK(int a, bool isEqual)
    {
        var expected = new[]
        {
            new[] { 2 }
        };
        var actual = new[]
        {
            new[] { a }
        };

        TryEqual(isEqual, expected, actual);
    }

    [Fact]
    public void Equal_DifferentSize_Fail()
    {
        var expected = new[]
        {
            new[] { 2, 3 },
            new[] { 2, 3 },
        };
        var actual = new[]
        {
            new[] { 2, 3 },
            new[] { 2, 3 },
            new[] { 2, 3 },
        };

        TryEqual(false, expected, actual);
    }
}