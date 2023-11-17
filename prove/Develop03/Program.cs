using System;

class Program
{
    static void Main(string[] args)
    {
        bool cont = true;
        string input = "";

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall directly thy paths.";
        Scripture scripture = new Scripture(reference, text);

        while (input != "quit" || cont == false)
        {
            // This will clear the console
            Console.Clear();

            scripture.GetDisplayText();

            scripture.HideRandomWords(3);

            Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();

            if (scripture.IsCompletelyHidden())
            {
                cont = false;
            }
        }
    }
}