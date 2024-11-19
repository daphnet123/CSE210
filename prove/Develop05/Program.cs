using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        ProgressTracker progressTracker = new ProgressTracker();
        FileHandler fileHandler = new FileHandler();

        // Load data
        (goalManager, progressTracker) = fileHandler.LoadData();

        while (true)
        {
            Console.WriteLine("\n=== Goal Tracker ===");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. View Goals");
            Console.WriteLine("3. Record Progress");
            Console.WriteLine("4. Save and Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    break;
                case "3":
                    Console.WriteLine("Enter the goal number to record progress:");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    Goal selectedGoal = goalManager.GetGoal(goalIndex);
                    if (selectedGoal != null)
                    {
                        int points = selectedGoal.RecordEvent();
                        progressTracker.AddPoints(points);
                        Console.WriteLine($"Progress recorded! You earned {points} points.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal number.");
                    }
                    break;
                case "4":
                    fileHandler.SaveData(goalManager, progressTracker);
                    Console.WriteLine("Data saved. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
