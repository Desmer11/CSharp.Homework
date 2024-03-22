using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassAnimal.Enums;

namespace ClassAnimal.Models
{
    public class Animals
    {
       
        public string Name { get; set; }

        public string Color { get; set; }
        public int Age { get; set; }
        public Gender gender { get; set; }


        public Animals() { }
        public Animals(string name,int age, string color, Gender gender)
        {
            Name = name;
            Age = age;
            Color = color;
            this.gender = gender;
        }  
        public void PrintInfo()
        {
            Console.WriteLine("Animal: "+Name+" - Age: "+Age+" - Color: "+Color+" - Gender: "+gender );
        }
    }
}
