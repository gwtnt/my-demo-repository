namespace MyDemoApp;

public class MyDemoClassNew
{
    private readonly string? _forceResult;

    public MyDemoClassNew(string? forceResult)
    {
        _forceResult = forceResult;
    }
    
    public string ReturnMe(string value)
    {
        return _forceResult ?? value;
    }
}