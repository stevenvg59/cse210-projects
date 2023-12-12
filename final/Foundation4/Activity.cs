public class Activity{
    private string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    
    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }

    public virtual double GetPace()
    {
        return 60 / GetSpeed();
    }

    public void GetSummary()
    {
        Console.WriteLine($" * {_date} {GetType()} ({_length} min) - Distance: {GetDistance()} km, Speed: {Math.Round(GetSpeed(),2)} kph, Pace: {Math.Round(GetPace(),2)} min per km.");
    }
}