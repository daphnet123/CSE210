using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    public void CreateGoal()
    {
        Console.WriteLine("\nChoose a goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Choice: ");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter required times: ");
                int requiredTimes = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, requiredTimes, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].Display();
        }
    }

    public List<Goal> GetGoals() => _goals;

    public Goal GetGoal(int index)
    {
        if (index >= 0 && index < _goals.Count)
            return _goals[index];
        return null;
    }

    public void AddGoal(Goal goal) => _goals.Add(goal);
}
