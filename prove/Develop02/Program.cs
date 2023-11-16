using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Creating a new instance of Journal
        Journal theJournal = new Journal();

        //User's input
        int answer = 0;
        
        //Welcome 
        Console.WriteLine("Welcome to the Journal Program!");
        
        while (answer != 5)
        {
            //Displaying instructions
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            //Getting user's input
            answer = int.Parse(Console.ReadLine());

            //Option 1: Write...
            if (answer == 1) //1. Write entries for the Journal
            {
                //New instances for Entry and Prompt
                Entry entry = new Entry();
                PromptGenerator prompt = new PromptGenerator();

                //Getting the date time
                DateTime theCurrentTime = DateTime.Now;
                entry._date = theCurrentTime.ToShortDateString();
                
                //Calling prompts generator
                entry._promptText = prompt.GetRandomPrompt();

                //Reading user's entry
                Console.WriteLine(entry._promptText);
                entry._entryText = Console.ReadLine();

                //Adding everything to the Journal
                theJournal.AddEntry(entry);
                
            }
            if (answer == 2) //2. Display everything
            {
                //Journal display
                theJournal.DisplayAll();
            }

            if (answer == 3) //3. Load from file
            {
                //User's filename
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                //Calling Load from File function
                theJournal.LoadFromFile(filename);

            }

            if (answer == 4) //4. Save to file
            {
                //User's filename
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                //Calling Save to File function
                theJournal.SaveToFile(filename);
            }
        }
    }
}