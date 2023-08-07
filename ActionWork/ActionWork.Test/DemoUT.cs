namespace ActionWork.Test;

public class DemoUT
{
    [Fact]
    public void TestAddSuccess()
    {
        var demoClass = new DemoClass();
        Assert.Equal(3, demoClass.Add(1, 2));
    }
}
