




class SumOfEvenNumbers
{
    static void Main(string[] args)
    {

        int[] array = new int[] { 4, 3, 7, 3, 2, 8 };
        var result = array.Where(i => i % 2 == 0).Sum();
        Console.WriteLine(result);


    }
}
















