using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;

    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RemoveGoal(Goal goal)
    {
        _goals.Remove(goal);
    }

    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{goal.Name}: {goal.Description} - Completed: {goal.IsComplete()}");
        }
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }
}
