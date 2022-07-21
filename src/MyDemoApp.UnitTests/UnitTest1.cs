using FluentAssertions;

namespace MyDemoApp.UnitTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var myDemoClass = new MyDemoClass(null);

        var myTestString = "Hello World";

        var resultString = myDemoClass.ReturnMe(myTestString);

        resultString.Should().Be(myTestString);
    }
    
    [Fact]
    public void Test2()
    {
        var myDemoClass = new MyDemoClass("This will be the result");

        var myTestString = "Hello World";

        var resultString = myDemoClass.ReturnMe(myTestString);

        resultString.Should().NotBe(myTestString);
    }
    
    [Fact]
    public void Test3()
    {
        var myDemoClass = new MyDemoClass("This will be the result");

        var myTestString = "Hello World";

        var resultString = myDemoClass.ReturnMe(myTestString);

        resultString.Should().Be(myTestString);
    }
}