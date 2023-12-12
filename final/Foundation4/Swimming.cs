public class Swimming : Activity
{
    private int _numberOfLaps;
    public Swimming(string date, int length, int numberOfLaps) : base(date, length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return (double)_numberOfLaps * 50 / 1000;
    }
}