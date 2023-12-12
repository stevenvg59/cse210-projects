using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is Foundation 3 Program!");
        Console.WriteLine("This program will create 3 events: Lecture, Reception, and an Outdoor Gathering.");

        //-----Creating the Lecture Event-----
        Address address1 = new Address("Main Street", "Salt Lake", "Utah", "USA");
        Lecture lecture = new Lecture("Pray Always", "Such an amazing spiritual event", "Thursday, November 24th", "4PM", address1, "Steven Valencia", 100);

        //-----Creating the Reception Event-----
        Address address2 = new Address("5th Avenue", "San Diego", "California", "USA");
        Reception reception = new Reception("Homecoming", "Best Party ever!", "Saturday, December 10th", "6PM", address2, "steven@gmail.com");

        //-----Creating the Outdoor Gathering Event-----
        Address address3 = new Address("Diagonal", "Miraflores", "Lima", "Peru");
        Outdoor outdoor = new Outdoor("BirthdayLab", "Celebrating birthdays for December", "Friday, December 9th", "3PM", address3, "Weather is just fine :)");

        //-----DISPLAYING RESULTS-----
        Console.WriteLine("\nEVENT #1");
        Console.Write("\nStandard Details:");
        lecture.StandardDetails();
        Console.Write("\n\nFull Details:");
        lecture.FullDetails();
        Console.Write("\n\nShort Description:");
        lecture.ShortDescription();

        Console.WriteLine("\nEVENT #2");
        Console.Write("\nStandard Details:");
        reception.StandardDetails();
        Console.Write("\n\nFull Details:");
        reception.FullDetails();
        Console.Write("\n\nShort Description:");
        reception.ShortDescription();

        Console.WriteLine("\nEVENT #3");
        Console.Write("\nStandard Details:");
        outdoor.StandardDetails();
        Console.Write("\n\nFull Details:");
        outdoor.FullDetails();
        Console.Write("\n\nShort Description:");
        outdoor.ShortDescription();
        
        
    }
}