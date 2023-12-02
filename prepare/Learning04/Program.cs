using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Steven Valencia", "Ironman");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Steven Valencia", "Fractions", "8.1.1", "1-10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Steven Valencia", "History", "My Life");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}