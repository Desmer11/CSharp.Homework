// Excercise 03
Console.WriteLine("\n\nExcercise 03\n");
string SubString()
{
    return "Hello from SEDC CodeAcademy 2024";

}

string methodMessage = SubString();

Console.WriteLine("Write a number");
string numInput = Console.ReadLine();
int num;
bool numparsed = int.TryParse(numInput, out num);

if (numparsed)
{
    if (num > methodMessage.Length)
    {
        Console.WriteLine("Number Yes");
    }
    Console.WriteLine(methodMessage.Substring(0, num));

}
else
{
    Console.WriteLine("Invalid");
}