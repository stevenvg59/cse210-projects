using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 5);
        Console.WriteLine("The color is: " + square.GetColor());
        Console.WriteLine("The area is: " + square.GetArea());
    }
}