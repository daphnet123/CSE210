public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        _isCompleted = true;
        return _points;
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }
}
