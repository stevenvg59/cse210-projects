public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public void SetCompleted(int amount)
    {
        _amountCompleted = amount;
    }

    public override int GetPoints()
    {
        if(IsComplete())
        {
            _points += _bonus;
        }
        return _points;
    }
    
    public override void RecordEvent()
    {
        if(_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        return false;
    }

    public override string GetDetailsString()
    {
        string details = _shortName + " (" + _description + ") -- Currently completed: " + _amountCompleted + "/" + _target; 
        return details;
    }
    public override string GetStringRepresentation()
    {
        string rep = GetType() + ":" + _shortName + "," + _description + "," + _points + "," + _bonus + "," + _amountCompleted + "," + _target; 
        return rep;
    }
}
