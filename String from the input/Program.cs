


using System;

string string1 = "782 675 S826F";
string greeting = "Welcome to " + string1;
Console.WriteLine(greeting);

string result1 = string1.Substring(string1.Length - 5);
Console.WriteLine(result1);

string result2 = string1.Substring(Math.Max(0, string1.Length - 5));
Console.WriteLine(result2);


class SumOfNumbers
{
    static int getSum(int n)
    {
        var result = 0;
       
        while (n != 0)
        {
            result = result + n % 10;
            n = n / 10;
        }
        return result;
    }

}





Console.WriteLine("Please enter the number");
string input = Console.ReadLine();
Console.WriteLine(input);
Console.Write(getSum(n));

s








