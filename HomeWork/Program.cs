
    class SumOfEvenNumbers
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter From Number:");
            int FromNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter To Number:");
            int ToNumber = Convert.ToInt32(Console.ReadLine());
            if (FromNumber < ToNumber)
            {
                sum = FindSumOfEvenNumbers(sum, FromNumber, ToNumber);
                Console.Write($"Sum of even numbers from {FromNumber} to {ToNumber} is : {sum}");
            }
            else
            {
                Console.Write("Invalid From and To Numbers");
            }
            Console.ReadLine();
        }
        private static int FindSumOfEvenNumbers(int sum, int FromNumber, int ToNumber)
        {
            for (int i = FromNumber; i <= ToNumber; i++)
            {
                if (i % 2 == 0)
                    sum += i;
            }
            return sum;
        }
    }













