using System;
using System.Collections.Generic;

public class ProgressTracker
{
    private int _totalPoints;
    private List<string> _badges;

    public ProgressTracker()
    {
        _totalPoints = 0;
        _badges = new List<string>();
    }

    public void AddPoints(int points)
    {
        _totalPoints += points;
    }

    public void AddBadge(string badge)
    {
        _badges.Add(badge);
    }

    public void DisplayProgress()
    {
        Console.WriteLine($"Total Points: {_totalPoints}");
        Console.WriteLine("Badges:");
        foreach (var badge in _badges)
        {
            Console.WriteLine(badge);
        }
    }
}
