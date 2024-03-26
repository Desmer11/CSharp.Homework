using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._01.Shape.Domain
{
    public class Shape
    {
        public string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                { throw new ArgumentException("Name must be Entered"); }
                else
                {
                    name = value;
                    Console.WriteLine("Name: " + name);
                }
            }
        }
        public string colour;
        public string Colour
        {
            get { return colour; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                { throw new ArgumentException("Colour Must be Entered"); }
                else
                {
                    colour = value;
                    Console.WriteLine("Colour: " + colour);
                }
            }
        }
        public int[] position;
        public int[] Position { get { return position; } set { position = value; } }

        public Shape() { }

        
        public virtual void GetArea()
        {
            Console.WriteLine("No Implementation of Area");
        }
        public virtual void GetPerimeter()
        {
            Console.WriteLine("No Implementation of Perimeter");
        }
        public void Move(Shape shape)
        {
            Console.WriteLine("\nCurrent Position x: " + shape.Position[0] + "\nCurrent Position y: " + shape.Position[1]);
            shape.Position[0] += 5;
            shape.Position[1] += 5;
            Console.WriteLine("\nNew Position x: " + shape.Position[0] + "\nNew Position y: " + shape.Position[1]);

        }
    }
}
