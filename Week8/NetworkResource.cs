namespace Week8;

public class NetworkResource : Resource, IDisposable
{
    private bool _disposed = false;
 
    public NetworkResource(string name) : base(name) { }
 
    public override void Open()
    {
        if (IsOpen)
        {
            Console.WriteLine($"[Network] '{Name}'alredy connected");
            return;
        }
        IsOpen = true;
        Console.WriteLine($"[Network] connected to '{Name}'");
    }
 
    public override void Close()
    {
        if (!IsOpen)
        {
            Console.WriteLine($"[Network] '{Name}' already disconnected");
            return;
        }
        IsOpen = false;
        Console.WriteLine($"[Network] disconnected from '{Name}'");
    }
 
    public void Dispose()
    {
        if (_disposed) return;
 
        if (IsOpen)
            Close();
 
        _disposed = true;
        Console.WriteLine($"[Network] '{Name}' disposed");
        GC.SuppressFinalize(this);
    }
}