namespace Week8;

public class ResourceManager<T> where T : Resource
{
    private readonly List<T> _resources = new();
 
    public void Add(T resource)
    {
        _resources.Add(resource);
        Console.WriteLine($"[Manager] added resource: '{resource.Name}'.");
    }
 
    public void OpenAll()
    {
        Console.WriteLine("[Manager] opening all resources");
        foreach (var resource in _resources)
            resource.Open();
    }
 
    public void CloseAll()
    {
        Console.WriteLine("[Manager] closing all resources");
        foreach (var resource in _resources)
            resource.Close();
    }
}