using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(10, "yellow");

        // System.Console.WriteLine(square.GetArea());
        // System.Console.WriteLine(square.GetColor());

        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);

        Rectangle rectangle = new Rectangle(10, 10, "Blue");

        Circle circle = new Circle(3, "Pink");

        shapes.Add(circle);

        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            int area = shape.GetArea();
            string color = shape.color;
            System.Console.WriteLine(area);
            System.Console.WriteLine(color);
        }

    }
}