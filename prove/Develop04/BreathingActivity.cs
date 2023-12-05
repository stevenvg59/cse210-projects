using System.ComponentModel;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Write("\n\nBreathe in...");
        ShowCountDown(3);
        Console.Write("\nNow breathe out...");
        ShowCountDown(3);

        int count = 0;

        while(count < _duration)
        {
            Console.Write("\n\nBreathe in...");
            ShowCountDown(4);
            Console.Write("\nNow breathe out...");
            ShowCountDown(6);
            count += 10;
        }

        DisplayEndingMessage();
    }
}