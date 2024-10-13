using Pugnet.Helpers;

namespace Pugnet.Tests;

[Trait("Category", "Helper")]
public class PathHelperTests
{
    public static IEnumerable<object[]> Paths = new List<object[]>
    {
        new object[] { "/this/is/absolute/path", true },
        new object[] { "~/this/is/absolute/path", true },
        new object[] { "this/is/relative/path", false }
    };

    [Theory]
    [MemberData(nameof(Paths))]
    public void PathHelperIsRelativePath_WithPath_ReturnsCorrectValue(string path, bool expectedResult)
    {
        Assert.Equal(!expectedResult, PathHelper.IsRelativePath(path));
    }

    [Theory]
    [MemberData(nameof(Paths))]
    public void PathHelperIsAbsolutePath_WithPath_ReturnsCorrectValue(string path, bool expectedResult)
    {
        Assert.Equal(expectedResult, PathHelper.IsAbsolutePath(path));
    }
}