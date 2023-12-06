using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 5);
        Console.WriteLine("The color is: " + square.GetColor());
        Console.WriteLine("The area is: " + square.GetArea());

        Rectangle rectangle = new Rectangle("Blue", 5, 4);
        Console.WriteLine("The color is: " + rectangle.GetColor());
        Console.WriteLine("The area is: " + rectangle.GetArea());

        Circle circle = new Circle("Yellow", 10);
        Console.WriteLine("The color is: " + circle.GetColor());
        Console.WriteLine("The area is: " + Math.Round(circle.GetArea(), 2));
    }
}