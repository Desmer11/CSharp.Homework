using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape1.Class
{
    class Circle : Shape
    {
        private int radius;

        public Circle(int radius)
        {
            Radius = radius;
            Diameter = Radius * 2;
            Circumference = Math.PI * 2 * Radius;
            Area = Math.PI * Math.Pow(Radius, 2);

        }
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public readonly double Diameter;
        public readonly double Circumference;
        public readonly double Area;

        public override string ToString()
        {
            return string.Format("" +
                "\nThis is Circle Class:" +
                "\nRadius = {0}\nDiameter = {1}" +
                "\nCircumference = {2}" +
                "\nArea = {3}",
                Radius,Diameter,Circumference,Area);
        }
    }
}
