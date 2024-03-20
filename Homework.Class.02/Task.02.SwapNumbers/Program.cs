class SwapNumbers
{
    static void Main()
    {
        int a = 5;
        int b = 8;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        (a, b) = (b, a);
        Console.WriteLine("Now a = " + a);
        Console.WriteLine("Now b = " + b);
    }
}
