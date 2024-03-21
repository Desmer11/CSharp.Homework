


using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string yesNO = "";
        do
        {
            string continueAdding = "Continue adding Numbers to the string (y/n)?: ";
            Console.Write(continueAdding);
            yesNO = Console.ReadLine();
            yesNO = yesNO.ToLower();
            Numbers();

        } while (yesNO == "y");

        static void Numbers()
        {
            Console.WriteLine("Enter your Number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Number is: " + inputNumber);



            Queue<int> integerQueue = new Queue<int>(inputNumber);
            Console.WriteLine("Your Queue is: " + integerQueue);


            foreach (int integer in integerQueue)
            {
                Console.WriteLine(integer);
            }
            Console.WriteLine("Count of Numbers:  " + integerQueue.Count);
            Console.WriteLine($"Num of members in the queue: {integerQueue.Count}");



        }

    }
}