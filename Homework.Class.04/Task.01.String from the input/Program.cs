


using System;

string string1 = "782 675 S826F";
string greeting = "Welcome to " + string1;
Console.WriteLine(greeting);

string result1 = string1.Substring(string1.Length - 5);
Console.WriteLine(result1);

string result2 = string1.Substring(Math.Max(0, string1.Length - 5));
Console.WriteLine(result2);








