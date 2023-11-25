using System;

class Program
{
    static void Main(string[] args)
    {
        //For user input
        string input = "";
        //For checking if the program should continue or not
        bool cont;

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall directly thy paths.";
        Scripture scripture = new Scripture(reference, text);

        //The program will continue unless the user types "quit"
        while (input != "quit")
        {
            // This will clear the console
            Console.Clear();

            //Displaying the whole scripture
            scripture.GetDisplayText();

            //Asking user's input
            Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();

            //Checking if the scripture is completely hidden
            cont = scripture.IsCompletelyHidden();

            if (cont)
            {
                //If it is, then the program ends
                break;
            }
            else {
                //If not, then continue hiding random words
                scripture.HideRandomWords(3);
            }
        }
    }
}