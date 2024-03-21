using Shape1.Class;


namespace Program1

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Art Of Shapes");
            Shape[] arrayOfShapes = new Shape[3];

            arrayOfShapes[0] = new Point(10, 20);
            arrayOfShapes[1] = new Circle(15);
            arrayOfShapes[2] = new Cylinder(25,20);


            foreach (var item in arrayOfShapes) 
            {
                Console.WriteLine($"{item}");
              

            }
        }
    }
}