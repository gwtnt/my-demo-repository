using FluentAssertions;

namespace MyDemoApp.UnitTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var myDemoClass = new MyDemoClass();

        var myTestString = "Hello World";

        var resultString = MyDemoClass.ReturnMe(myTestString);

        resultString.Should().Be(myTestString);
    }
}