using Leetx.Tools.ListsOfLists;
using Xunit.Sdk;

namespace Leetx.Tools.Tests.ListsOfLists;

public class LolAssert_FailMessage_Tests
{
    [Fact]
    public void Equal_2x2_ListsAreSerialized()
    {
        var expected = new[]
        {
            new[] { 1, 2 },
            new[] { 3, 4 }
        };
        var actual = new[]
        {
            new[] { 1, 2 },
            new[] { 8, 4 }
        };

        try
        {
            LolAssert.Equal(expected, actual);
        }
        catch (EqualException ex)
        {
            Assert.Equal("[[1, 2], [3, 4]]", ex.Expected);
            Assert.Equal("[[1, 2], [8, 4]]", ex.Actual);
        }
    }

    [Fact]
    public void Equal_DifferentRowSize_ListsAreSerialized()
    {
        var expected = new[]
        {
            new[] { 1, 2, 3 },
            new[] { 3, 4 }
        };
        var actual = new[]
        {
            new[] { 1, 2 },
            new[] { 8, 4 }
        };

        try
        {
            LolAssert.Equal(expected, actual);
        }
        catch (EqualException ex)
        {
            Assert.Equal("[[1, 2, 3], [3, 4]]", ex.Expected);
            Assert.Equal("[[1, 2], [8, 4]]", ex.Actual);
        }
    }

    [Fact]
    public void Equal_DifferentRowCount_ListsAreSerialized()
    {
        var expected = new[]
        {
            new[] { 1, 2 },
            new[] { 3, 4 },
            new[] { 5, 6 }
        };
        var actual = new[]
        {
            new[] { 1, 2 },
            new[] { 8, 4 }
        };

        try
        {
            LolAssert.Equal(expected, actual);
        }
        catch (EqualException ex)
        {
            Assert.Equal("[[1, 2], [3, 4], [5, 6]]", ex.Expected);
            Assert.Equal("[[1, 2], [8, 4]]", ex.Actual);
        }
    }
}