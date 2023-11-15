using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        fraction1.Display();
        fraction2.Display();
        fraction3.Display();

        fraction1.SetTop(8);
        fraction2.SetBottom(9);
        Console.WriteLine(fraction1.GetTop());
        Console.WriteLine(fraction2.GetBottom());
    }
}