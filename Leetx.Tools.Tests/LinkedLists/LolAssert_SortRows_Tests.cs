using Leetx.Tools.LinkedLists;
using Xunit.Sdk;

namespace Leetx.Tools.Tests.LinkedLists;

public class LolAssert_SortRows_Tests
{
    public static void TryEqual(bool isEqual, int[][] expected, int[][] actual)
    {
        try
        {
            LolAssert.Equal(expected, actual, keepRowOrder: false);
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
            new[] { 7, 7, 8 },
            new[] { 1, 2, a },
            new[] { 3, 4, 5 }
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
            new[] { 0, 1, 2, a },
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
            new[] { a },
            new[] { 1 },
        };

        TryEqual(isEqual, expected, actual);
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(3, false)]
    public void Equal_Single_OK(int a3, bool isEqual)
    {
        var expected = new[]
        {
            new[] { 2 }
        };
        var actual = new[]
        {
            new[] { a3 }
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