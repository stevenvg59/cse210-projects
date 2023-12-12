public class Events 
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Events
    (string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void StandardDetails()
    {
        Console.Write("\n- Title: " + _title);
        Console.Write("\n- Description: " + _description);
        Console.Write("\n- Date: " + _date);
        Console.Write("\n- Time: " + _time);
        Console.Write("\n- Address: " + _address.GetString());

    }

    public void ShortDescription()
    {
        Console.Write("\n- Type of Event: " + GetType());
        Console.Write("\n- Title: " + _title);
        Console.Write("\n- Date: " + _date + "\n");
    }
}