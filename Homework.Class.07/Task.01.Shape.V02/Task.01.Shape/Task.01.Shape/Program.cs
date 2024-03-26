using Task._01.Shape.Domain;

Rectangle rectangle = new Rectangle()
{
    Name = "Rectangle",
    Colour = "Green",
    Position = new int[] { 5, 10 },
    SideA = 4,
    SideB = 8,

};
Console.WriteLine("\nRectangle: ");
rectangle.PrintInfo();
rectangle.GetPerimeter();
rectangle.GetArea();
rectangle.Move(rectangle);
rectangle.Move(rectangle);


Circle circle = new Circle()
{
    Name = "Circle",
    Colour = "Blue",
    Position = new int[] { 10, 20 },
    Radius = 4,
};
Console.WriteLine("\nCircle: ");
circle.PrintInfo();
circle.GetPerimeter();
circle.GetArea();
rectangle.Move(circle);









