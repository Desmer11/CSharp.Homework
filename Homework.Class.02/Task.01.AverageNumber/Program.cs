//int array = [10, 15,20,25,30];
//double average1 = Queryable.Average(array.AsQueryable());
//Console.WriteLine(average1);



class AverageNumber
{  static void Main()
    {
        int[] arr = new int[] { 10, 15, 20, 30 };
        double avg = Queryable.Average(arr.AsQueryable());
        Console.WriteLine("Average = " + avg);
    }
}











