using Constructor.Exercise;
using System;
using System.Net.Cache;

namespace PersonCalls
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Constructor Exercise");

            Person jl = new Person("Caesar", 2011, 2.2);

            int currentYear = DateTime.Now.Year;

            Console.WriteLine("Current Year: " + currentYear);

            Console.WriteLine("Name: "+jl.name);
            Console.WriteLine("Year of Birth: "+jl.yearOfBirth);
            Console.WriteLine("Age: "+ jl.Age());
            Console.WriteLine("Height: "+jl.height);
            Console.WriteLine("Forever Alive: "+jl.isAlive);

        }
    }
}