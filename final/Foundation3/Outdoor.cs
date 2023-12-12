public class Outdoor : Events
{
    private string _forecast;

    public Outdoor(string title, string description, string date, string time, Address address, string forecast): base(title, description, date, time, address)
    {
        _forecast = forecast;
    }

    public void FullDetails()
    {
        StandardDetails();
        Console.Write("\n- Weather Forecast: " + _forecast);
    }
}