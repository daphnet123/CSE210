using System;

public class UserInterface
{
    public void DisplayMainMenu()
    {
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Create Goal");
        Console.WriteLine("2. Display Goals");
        Console.WriteLine("3. Track Goal");
        Console.WriteLine("4. Save and Exit");
    }

    public int GetUserChoice()
    {
        return int.Parse(Console.ReadLine());
    }

    public void DisplayGoalCreationOptions()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
    }

    public void DisplayGoalDetails(Goal goal)
    {
        Console.WriteLine($"Goal Name: {goal.Name}");
        Console.WriteLine($"Description: {goal.Description}");
        Console.WriteLine($"Points: {goal.Points}");
        Console.WriteLine($"Completed: {goal.IsComplete()}");
    }
}
