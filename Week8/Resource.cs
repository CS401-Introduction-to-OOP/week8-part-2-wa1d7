namespace Week8;

public abstract class Resource
{
    public string Name { get; }
    public bool IsOpen { get; protected set; }
 
    protected Resource(string name)
    {
        Name = name;
        IsOpen = false;
    }
 
    public abstract void Open();
    public abstract void Close();
}
