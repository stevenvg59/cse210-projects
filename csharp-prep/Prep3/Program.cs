using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // THIS IS ONLY FOR CORE REQUIREMENTS 1 & 2
        // Console.Write("What is the magic number? ");
        // string input = Console.ReadLine();
        // int number = int.Parse(input);

        string response = "";
        do 
        {
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1, 101);
   
            int guessNumber = -1;

            //For Stretch Challenge #1
            int count = 0;
 
            while (magic != guessNumber)
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);

                if (magic > guessNumber)
                {
                    Console.WriteLine("Higher");
                } 
                else if (magic < guessNumber)
                {
                    Console.WriteLine("Lower");
                } 
                count++;
            }
        
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You had {count} guesses.");

            //Stretch Challenge #2
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();

        } while (response == "yes");
        
    }
}