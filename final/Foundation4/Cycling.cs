public class Cycling : Activity
{
    private double _distance;

    public Cycling(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
}