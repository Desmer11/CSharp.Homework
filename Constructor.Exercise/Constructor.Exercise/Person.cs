
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.Exercise
{
    internal class Person
    {
        //Fields
        public string name;
        public int yearOfBirth;
        public double height;
        public bool isAlive = true;
        int currentYear = DateTime.Now.Year;
        // Constructor
        public Person(string name, int yearOfBirth, double height) 
        {
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.height = height;

           

            if (this.yearOfBirth > currentYear) 
            {
                this.isAlive = false;
            }
            else
            {
                this.isAlive = true;
            }
        }
        public int Age()
        {
            int age = currentYear - yearOfBirth;
            return age;

        }
    }
}
