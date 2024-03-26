using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task._01.Shape.Domain
{
    public class Circle : Shape
    {

        public int Radius { get; set; }

        public override void GetPerimeter()
        {
            double perimeter = Math.PI * 2 * Radius;
            Console.WriteLine($"Name: {Name} - Colour: {Colour} - Perimeter: {perimeter}");
        }

        public override void GetArea()
        {
            double area = Math.PI * Radius * Radius;
            Console.WriteLine($"Name: {Name} - Colour: {Colour} - Area: {area}");
        }

        public void PrintInfo()
        {
            Console.WriteLine
                ("Name: "+Name+
                "\nColour: "+ Colour+
                "\nRadius. " + Radius);
        }
        public Circle() { }
    }
}
