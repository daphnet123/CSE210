public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _isCompleted = false;
    }

    public override int RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _isCompleted;

    public override void Display()
    {
        string status = _isCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_name}: {_description} - {_points} points");
    }
}
