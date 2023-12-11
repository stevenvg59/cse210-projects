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
                ListGoalDetails();
            }
            if (input == 3)
            {
        
            }
            if (input == 4)
            {
        
            }
            if (input == 5)
            {
                RecordEvent();
            }
        }

    }

    public void DisplayPlayerInfo() //Displays the players current score.
    {
        Console.WriteLine("\nYou have " + _score + " points.\n");
    }

    public void ListGoalNames() //Lists the names of each of the goals.
    {
        Console.WriteLine("The goals are:");
        int count = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine( count + ". "+ goal.GetShortName());
            count++;
        }
    }

    public void ListGoalDetails() //Lists the details of each goal (including the checkbox of whether it is complete).
    {
        Console.WriteLine("The goals are:");
        int count = 1;
        
        foreach(Goal goal in _goals)
        {
            string check = " ";
            if(goal.IsComplete())
            {
                check = "X";
            }
            Console.WriteLine( count + ". [" + check + "] "+ goal.GetDetailsString());
            count++;
        }
    }

    public void CreateGoal() //Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int goalNumber = int.Parse(Console.ReadLine());           
        
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if(goalNumber == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal); 
        }
        if(goalNumber == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal); 
        }
        if(goalNumber == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal); 
        }
    }

    public void RecordEvent() //Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplished? ");
        int goalNumber = int.Parse(Console.ReadLine());
        _goals[goalNumber-1].RecordEvent();
        int points = _goals[goalNumber-1].GetPoints();
        Console.WriteLine("Congratulations! You have earned " + points + " points!");
        _score += points;
        Console.WriteLine("You now have " + _score + " points.");
    }

    public void SaveGoals() //Saves the list of goals to a file.
    {

    }

    public void LoadGoals() //Loads the list of goals from a file.
    {
        
    }
}