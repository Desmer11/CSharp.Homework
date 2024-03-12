using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClass05.CreateDog
{
    public class Dog
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Dog(string? inputName)
        {
        }
        public Dog(string name, string type)
        {
            Name = name;    
            Type = type;

        }

        public Dog()
        {
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Dog Name: {Name} Type of Dog: {Type}");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} is Eating");
        }
        public void Play()
        {
            Console.WriteLine($"{Name} dog is Playing");
        }
        public void Chase()
        {
            Console.WriteLine($"{Name} dog is Chasing its Tail");
        }
    }


}
