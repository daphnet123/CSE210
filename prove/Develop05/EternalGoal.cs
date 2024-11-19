public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        return _points; // No completion, points awarded every time
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never completed
    }
}
