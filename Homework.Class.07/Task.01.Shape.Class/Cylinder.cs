using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape1.Class
{
    class Cylinder : Circle
    {
        int height;
        public Cylinder(int radius, int height) : base(radius) {

            Height = height;
            Volume = Math.PI * Math.Pow(Radius, 2) * Height;
            Area =
                (2 * Math.PI * Radius * Height) +
                (2 * Math.PI * Math.Pow(Radius, 2));
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        
        public readonly double Volume;
        new public readonly double Area;

        public override string ToString()
        {
            return string.Format("" +
                "\nThis is Cylinder Class:\n" +
                "Height = {0}\n" +
                "Radius = {1}\n" +
                "Volume = {2}\n" +
                "Area = {3}",
                Height,Radius,Volume,Area);
        }

    }
}


