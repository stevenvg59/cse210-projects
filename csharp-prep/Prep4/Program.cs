using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int number = -1;
        int sum = 0;
        int max = -1;

        //New list for storing only positive numbers (Stretch challenge)
        List<int> positiveNumbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);

                if (number > max)
                {
                    max = number;
                }

                //Stretch Challenge
                if (number > 0)
                {
                    positiveNumbers.Add(number);
                }
            }
        }

        foreach (int item in numbers)
        {
            sum += item;
        }

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        Console.WriteLine($"The smallest positive number is: {positiveNumbers.AsQueryable().Min()}");

        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }


    }
}