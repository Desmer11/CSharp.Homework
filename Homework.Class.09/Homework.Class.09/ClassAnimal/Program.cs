using System;
using System.Collections.Generic;
using System.Linq;
using ClassAnimal.Models;
using ClassAnimal.Enums;



Animals animals = new Animals();


List<Animals> animalsList = new List<Animals>()
            {
                new Animals(){Name = "Tiger", Age = 33, Color = "Green",gender = Gender.Male},
                new Animals(){Name = "Seal", Age = 29, Color = "White", gender = Gender.Female},
                new Animals(){Name = "Elephant", Age = 10, Color = "Grey", gender = Gender.Male},
                new Animals(){Name = "Hippotamus", Age = 9, Color = "Brown", gender = Gender.Female},
                new Animals(){Name = "Ape", Age = 8, Color = "Brown", gender = Gender.Male},
                new Animals(){Name = "Crocodile", Age = 5, Color = "Brown", gender = Gender.Male},
                new Animals(){Name = "Cat", Age = 2, Color = "Blue", gender = Gender.Female}
            };


Console.WriteLine("All Animals: ");
foreach (Animals animal in animalsList)
{
    animal.PrintInfo();
}


// =======================================Finding Names of Older than Age: 5
List<Animals> animalOlderFive = new List<Animals>();

Console.WriteLine("\nFinding Names of Older than Age: 5 : ");
foreach (Animals animal in animalsList)
{
    if (animal.Age >= 5)
    {
        animalOlderFive.Add(animal);
        Console.WriteLine(animal.Name+" - Age: "+ animal.Age);
    }
}

// =======================================Finding Names of Older than Age: 5 - LINQ Arroe Function
List<Animals> animalOlder5 =
    animalsList.Where(animal => animal.Age >= 5).ToList();

Console.WriteLine("\nFinding Names of Older than Age: 5 : ");
foreach (Animals animal in animalOlder5)
{
    animalOlderFive.Add(animal);
    Console.WriteLine(animal.Name + " - Age: " + animal.Age);
}

//============================================Finding Animals starting with: A

List<Animals> animalStartA =
    animalsList.Where(animal => animal.Name.StartsWith("A") ).ToList();

Console.WriteLine("\nFinding Animals starting with: A ");
foreach (Animals animal in animalStartA)
{
    animalOlderFive.Add(animal);
    Console.WriteLine(animal.Name + " - Age: " + animal.Age);
}
//============================================== Finding With Longer name than 9

Console.WriteLine("\nFinding With Longer name than 9 ");

List<Animals> animalLongerName8 = 
    animalsList.Where(animal => animal.Name.Length >= 9).ToList();

foreach (Animals animal in animalLongerName8)
{
    animalOlderFive.Add(animal);
    Console.WriteLine(animal.Name + " - Age: " + animal.Age);
}

//============================================= Finding All Male Animals

Console.WriteLine("\nFinding All Male Animals ");
List<Animals> animalsMale =
    animalsList.Where(animal => animal.gender == Gender.Male).ToList();

foreach (Animals animal in animalsMale)
{
    Console.WriteLine(animal.Name + " - Age: " + animal.Age + " - Gender: " + animal.gender + " - Color: " + animal.Color);
}

//============================================= Finding All Brown Animals

Console.WriteLine("\nFinding All Brown Animals: ");

List<Animals> animalsBrown =
    animalsList.Where(animal => animal.Color == "Brown").ToList();

foreach (Animals animal in animalsBrown)
{
    Console.WriteLine(animal.Name + " - Age: " + animal.Age + " - Gender: " + animal.gender + " - Color: " + animal.Color);
}


//============================================= Finding All Male Brown Animals

Console.WriteLine("\nFinding All Male Brown Animals ");
List<Animals> animalsMaleBrown =
    animalsList.Where(animal => animal.gender == Gender.Male && animal.Color == "Brown").ToList();

foreach (Animals animal in animalsMaleBrown)
{
    Console.WriteLine(animal.Name + " - Age: " + animal.Age + " - Gender: " + animal.gender + " - Color: " + animal.Color);
}

