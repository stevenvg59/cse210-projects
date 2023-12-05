public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("\nConsider the following prompt:\n");
        DisplayPrompt();
        Console.Write("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Write("\nNow ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        ShowCountDown(5);        
        
        Console.Clear();
        DisplayQuestions();

        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        //Getting a random number between 1-4
        Random randomNumber = new Random();
        int random = randomNumber.Next(1, _prompts.Count + 1);

        //Getting the random prompt
        string prompt = _prompts[random - 1];

        return prompt;
    }

    public string GetRandomQuestion()
    {
        //Getting a random number between 1-9
        Random randomNumber = new Random();
        int random = randomNumber.Next(1, _questions.Count + 1);

        //Getting the random question
        string question = _questions[random - 1];

        return question;
    }

    public void DisplayPrompt()
    {
        Console.Write(" --- ");
        Console.Write(GetRandomPrompt());
        Console.WriteLine(" --- ");
    }

    public void DisplayQuestions()
    {
        int count = 0;

        while(count < _duration)
        {
            Console.Write("> " + GetRandomQuestion() + " ");
            ShowSpinner(10);
            Console.Write("\n");
            count += 10;
        }
    }
}