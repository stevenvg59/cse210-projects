public class ListingActivity : Activity
{
    private int _count;
    public List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
    
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.Write(" --- ");
        Console.Write(GetRandomPrompt());
        Console.WriteLine(" --- ");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Write("\n");
        GetListFromUser();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        //Getting a random number for all the items of _prompts list
        Random randomNumber = new Random();
        int random = randomNumber.Next(1, _prompts.Count + 1);

        //Getting the random prompt
        string prompt = _prompts[random - 1];

        return prompt;
    }

    public void GetListFromUser()
    {
        List<string> inputs = new List<string>();

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_duration);
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            inputs.Add(Console.ReadLine());
            _count++;
            currentTime = DateTime.Now;
        }

        Console.WriteLine("You listed " + _count + " items!");
    }
}