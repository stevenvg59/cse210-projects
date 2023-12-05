using System;

class Program
{
    static void Main(string[] args)
    {
        int input = 0;

        while (input != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            if (input == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            if (input == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
        }
    }
}