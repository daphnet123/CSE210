public class ChecklistGoal : Goal
{
    private int _completedCount;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _completedCount = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        _completedCount++;
        if (_completedCount >= _targetCount)
        {
            _isCompleted = true;
            return _points + _bonusPoints;
        }
        return _points;
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }
}
