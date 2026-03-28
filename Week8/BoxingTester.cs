namespace Week8;

public static class BoxingTester
{
    public static void Test()
    {
 
        int a = 10;
        Console.WriteLine($"a (int, stack)= {a}");
 
        object b = a;                       
        Console.WriteLine($"b (object, heap) = {b} boxed copy of a");
 
        int c = (int)b;                     
        Console.WriteLine($" c (int, stack)= {c}unboxed from b");
 
        a = 99;
        Console.WriteLine($"After a = 99:");
        Console.WriteLine($"a = {a}(changed)");
        Console.WriteLine($"b = {b}  (still 10)");
        Console.WriteLine($"c = {c}  (still 10 like b)");
    }
}
