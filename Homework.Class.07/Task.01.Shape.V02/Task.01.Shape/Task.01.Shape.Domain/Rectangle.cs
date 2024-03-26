using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._01.Shape.Domain
{
    public class Rectangle : Shape
    {
        public int SideA ;
        public int SideB;


        public override void GetPerimeter()
        {
            int perimeter = 2 * (SideA + SideB);
            Console.WriteLine($"Name: {Name} - Colour: {Colour} - Perimeter: {perimeter}");
        }

        public override void GetArea()
        {
            int area = SideA + SideB; 
            Console.WriteLine($"Name: {Name} - Colour: {Colour} - Area: {area}");
        }
        public void PrintInfo()
        {
            Console.WriteLine
                ("Name: " + Name +2+
                "\nColour: " + Colour+
                "\nSide A: " + SideA+
                "\nSide B:"+SideB);
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
