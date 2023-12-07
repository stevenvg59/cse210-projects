public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start() //This is the "main" function for this class
    {
        int input = 0;

        while (input != 6)
        {
            //Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                CreateGoal();
            }
            if (input == 2)
            {
        
            }
            if (input == 3)
            {
        
            }
            if (input == 4)
            {
        
            }
            if (input == 5)
            {
        
            }
        }

    }

    public void DisplayPlayerInfo() //Displays the players current score.
    {
        Console.WriteLine("\nYou have " + _score + " points.\n");
    }

    public void ListGoalNames() //Lists the names of each of the goals.
    {

    }

    public void ListGoalDetails() //Lists the details of each goal (including the checkbox of whether it is complete).
    {

    }

    public void CreateGoal() //Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    {
        int goalNumber = 0;
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        goalNumber = int.Parse(Console.ReadLine());
    }

    public void RecordEvent() //Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    {

    }

    public void SaveGoals() //Saves the list of goals to a file.
    {

    }

    public void LoadGoals() //Loads the list of goals from a file.
    {
        
    }
}