using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is Foundation 4 Program!");

        //Creating 3 activities (one for each type)
        Running running = new Running("03 Nov 2022", 30, 8); //Date , minutes, distance
        Cycling cycling = new Cycling("04 Nov 2022", 60, 14); //Date , minutes, distance
        Swimming swimming = new Swimming("05 Nov 2022", 30, 58); //Date , minutes, # of laps

        //Creating a list of activities to add all of them
        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        //Displaying results
        Console.WriteLine("\nExercises: ");
        foreach(Activity activity in activities)
        {
            activity.GetSummary();
        }
        
    }
}