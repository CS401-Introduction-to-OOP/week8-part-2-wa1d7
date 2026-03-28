namespace Week8;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
    
    public void Print(string label)
    {
        Console.WriteLine($" [{label}] point (struct) ->  X = {X} ; Y = {Y}");
    }
}