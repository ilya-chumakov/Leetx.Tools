using Xunit.Abstractions;

namespace Leetx.Tools;

public class BaseTest
{
    private readonly ITestOutputHelper _output;

    public BaseTest(ITestOutputHelper output)
    {
        _output = output;
    }

    public void WriteLine(string str)
    {
        _output.WriteLine(str);
    }

    public void WriteLine(object obj)
    {
        _output.WriteLine(obj.ToString());
    }

    public void WriteLine(LinkedList<int> list)
    {
        foreach (var item in list) WriteLine(item.ToString());
    }
}