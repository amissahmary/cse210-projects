using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();

        Square square = new Square(3);
        shapes.Add(square);

        Rectangle rec = new Rectangle(4,5);
        shapes.Add(rec);

        Circle cir = new Circle(2);
        shapes.Add(cir);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}