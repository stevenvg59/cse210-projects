public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    
    public string GetRandomPrompt()
    {
        //Getting a random number between 1-6
        Random randomNumber = new Random();
        int random = randomNumber.Next(1, 7);

        //Initializing the prompt
        string prompt = "";

        if (random == 1)
        {
            prompt = "Who was the most interesting person I interacted with today?";
        }
        if (random == 2)
        {
            prompt = "What was the best part of my day?";
        }
        if (random == 3)
        {
            prompt = "How did I see the hand of the Lord in my life today?";
        }
        if (random == 4)
        {
            prompt = "What was the strongest emotion I felt today?";
        }
        if (random == 5)
        {
            prompt = "If I had one thing I could do over today, what would it be?";
        }
        if (random == 6)
        {
            prompt = "What good deed did I do today for my neighbor?";
        }

        return prompt;
    }
}