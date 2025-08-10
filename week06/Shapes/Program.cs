using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();

        Square square = new Square(8, "Purple");
        _shapes.Add(square);


        Rectangle rectangle = new Rectangle(7, 13, "Blue");
        _shapes.Add(rectangle);

        Circle circle = new Circle(3, "Pink");
        _shapes.Add(circle);

        foreach (Shape shape in _shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();

            Console.WriteLine($"{color}, {area}");
            
        }

    } 

}