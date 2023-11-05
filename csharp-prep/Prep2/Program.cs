using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        string grade = "";
        string sign = "";

        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else if (percentage < 60)
        {
            grade = "F";
        }

        //Stretch Challenges
        if (grade != "F" && percentage % 10 < 3)
        {
            sign = "-";
        }
        else if (grade != "A" && grade != "F" && percentage % 10 >= 7)
        {
            sign = "+";
        }


        Console.WriteLine($"Your grade is {grade}{sign}.");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else {
            Console.WriteLine("Oh no, you didn't pass the course. Better luck next time.");
        }
    }
}