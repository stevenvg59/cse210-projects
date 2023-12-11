public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public void SetCompleted()
    {
        _isComplete = true;
    }

    public override void RecordEvent()
    {
        SetCompleted();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string rep = GetType() + ":" + _shortName + "," + _description + "," + _points + "," + IsComplete(); 
        return rep;
    }
}