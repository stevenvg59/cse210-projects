public class Comment
{
    public string _name;
    public string _text;

    public void Display()
    {
        Console.WriteLine(_text + " by " + _name);
    }
}