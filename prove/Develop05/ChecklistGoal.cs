public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _requiredTimes;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int requiredTimes, int bonusPoints)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _requiredTimes = requiredTimes;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _requiredTimes)
        {
            _timesCompleted++;
            if (_timesCompleted == _requiredTimes)
            {
                return _points + _bonusPoints;
            }
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _timesCompleted >= _requiredTimes;

    public override void Display()
    {
        Console.WriteLine($"[{_timesCompleted}/{_requiredTimes}] {_name}: {_description} - {_points} points (+{_bonusPoints} bonus)");
    }
}
