using System;

using System.Linq;



List<int> listNumbers = new List<int>
{ 10,20,30,40,50,60,70,80,90,100};

var numbers = listNumbers.Select
    (n => new
{ Square = Math.Pow(n, 2) });



foreach(int number in listNumbers)
{
    Console.WriteLine("Numbers In List: "+number);
}
foreach (var number in numbers)

{

    Console.WriteLine($"Square: {number.Square}");

}




