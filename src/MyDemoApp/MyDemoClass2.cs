namespace MyDemoApp;

public class MyDemoClass2
{
    private readonly string? _forceResult;

    public MyDemoClass2(string? forceResult)
    {
        _forceResult = forceResult;
    }
    
    public string ReturnMe(string value)
    {
        return _forceResult ?? value;
    }
}