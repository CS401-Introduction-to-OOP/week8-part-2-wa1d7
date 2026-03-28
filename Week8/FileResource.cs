namespace Week8;
    
public class FileResource : Resource, IDisposable
{
    private bool _disposed = false;
 
    public FileResource(string name) : base(name) { }
 
    public override void Open()
    {
        if (IsOpen)
        {
            Console.WriteLine($"[File] '{Name}' already opened");
            return;
        }
        IsOpen = true;
        Console.WriteLine($"[File] opened '{Name}'");
    }
 
    public override void Close()
    {
        if (!IsOpen)
        {
            Console.WriteLine($"[File] '{Name}' already closed");
            return;
        }
        IsOpen = false;
        Console.WriteLine($"[File] closed '{Name}'");
    }
 
    public void Dispose()
    {
        if (_disposed) return;
 
        if (IsOpen)
            Close();
 
        _disposed = true;
        Console.WriteLine($"[File] '{Name}' disposed");
        GC.SuppressFinalize(this);
    }
}