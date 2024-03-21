using HomeWorkClass05.CreateDog;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Dog dog = new Dog();

        dog.Name = "Caesar";
        dog.Type = "Danish Spitz";

        Dog aura = new Dog("Aura", "Collie´Dor");

        Console.WriteLine(dog.Name);
        dog.PrintInfo();
        aura.PrintInfo();

        aura.Eat();

        //Console.WriteLine("Enter Your Dog Name:");
        //string userDog = Console.ReadLine();
        //Console.WriteLine("userDog is: " + userDog);


        Console.WriteLine("Input Dog: ");
        var inputName = Console.ReadLine();
        Console.WriteLine("Input Type: ");
        var inputType = Console.ReadLine();

        Console.WriteLine("What is it doing 1, 2, 3: ");
        var doing = Console.ReadLine();

        var inputDog = new Dog(inputName, inputType);
        inputDog.PrintInfo();
        Console.WriteLine($"{ inputName} { inputType}");
    }
}