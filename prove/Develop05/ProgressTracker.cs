public class ProgressTracker
{
    private int _totalPoints;

    public void AddPoints(int points)
    {
        _totalPoints += points;
    }

    public int GetTotalPoints() => _totalPoints;

    public override string ToString() => $"Total Points: {_totalPoints}";
}
