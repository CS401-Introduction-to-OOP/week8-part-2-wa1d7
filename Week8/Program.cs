namespace Week8;
class Program
{
    public static void Main()
    {
        var file = new FileResource("report.txt");
        var network = new NetworkResource("api.company.local");
        var manager = new ResourceManager<Resource>();
        
        manager.Add(file);
        manager.Add(network);
        
        manager.OpenAll();
        
        Console.WriteLine("using block: temporary connection");
        using (var temporatyconnect = new NetworkResource("temporary"))
        {
            temporatyconnect.Open();
            Console.WriteLine($"IsOpen = {temporatyconnect.IsOpen}");
        }  
        Console.WriteLine("  outside block connection cleaned");
        
        manager.CloseAll();
 
        Console.WriteLine("done.");
    }
    
}