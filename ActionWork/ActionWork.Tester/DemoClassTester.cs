using Xunit;

namespace ActionWork.Tester;

public class DemoClassTester
{
    [Fact]
    public void AddFunctionSuccess()
    {
        var demoClass = new DemoClass();

        Assert.Equal(3, demoClass.Add(1, 2));
    }

    [Fact]
    public void AddFunctionFailed()
    {
        var demoClass = new DemoClass();

        Assert.Equal(1, demoClass.Add(1, 2));
    }
}

