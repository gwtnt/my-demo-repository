namespace MyDemoApp;

public class MyDemoClass
{
    private readonly string? _forceResult;

    public MyDemoClass(string? forceResult)
    {
        _forceResult = forceResult;
    }
    
    public string ReturnMe(string value)
    {
        return _forceResult ?? value;
    }
}