public class Lecture : Events
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    } 

    public void FullDetails()
    {
        StandardDetails();
        Console.Write("\n- Speaker Name: " + _speaker);
        Console.Write("\n- Capacity: " + _capacity);
    }
}