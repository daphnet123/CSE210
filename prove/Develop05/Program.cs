using System;

class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();
        ProgressTracker progressTracker = new ProgressTracker();
        UserInterface ui = new UserInterface();
        FileHandler fileHandler = new FileHandler();

        // Load saved data if available
        (goalManager, progressTracker) = fileHandler.LoadData();

        bool isRunning = true;
        while (isRunning)
        {
            ui.DisplayMainMenu();
            int choice = ui.GetUserChoice();

            switch (choice)
            {
                case 1: // Create Goal
                    ui.DisplayGoalCreationOptions();
                    int goalType = int.Parse(Console.ReadLine());
                    Goal newGoal = null;

                    switch (goalType)
                    {
                        case 1: // Simple Goal
                            Console.Write("Enter Goal Name: ");
                            string simpleName = Console.ReadLine();
                            Console.Write("Enter Goal Description: ");
                            string simpleDescription = Console.ReadLine();
                            Console.Write("Enter Goal Points: ");
                            int simplePoints = int.Parse(Console.ReadLine());
                            newGoal = new SimpleGoal(simpleName, simpleDescription, simplePoints);
                            break;
                        case 2: // Eternal Goal
                            Console.Write("Enter Goal Name: ");
                            string eternalName = Console.ReadLine();
                            Console.Write("Enter Goal Description: ");
                            string eternalDescription = Console.ReadLine();
                            Console.Write("Enter Goal Points: ");
                            int eternalPoints = int.Parse(Console.ReadLine());
                            newGoal = new EternalGoal(eternalName, eternalDescription, eternalPoints);
                            break;
                        case 3: // Checklist Goal
                            Console.Write("Enter Goal Name: ");
                            string checklistName = Console.ReadLine();
                            Console.Write("Enter Goal Description: ");
                            string checklistDescription = Console.ReadLine();
                            Console.Write("Enter Goal Points: ");
                            int checklistPoints = int.Parse(Console.ReadLine());
                            Console.Write("Enter Target Count: ");
                            int targetCount = int.Parse(Console.ReadLine());
                            Console.Write("Enter Bonus Points: ");
                            int bonusPoints = int.Parse(Console.ReadLine());
                            newGoal = new ChecklistGoal(checklistName, checklistDescription, checklistPoints, targetCount, bonusPoints);
                            break;
                    }
                    if (newGoal != null)
                    {
                        goalManager.AddGoal(newGoal);
                    }
                    break;
                case 2: // Display Goals
                    goalManager.DisplayGoals();
                    break;
                case 3: // Track Goal
                    Console.Write("Enter goal name to track: ");
                    string goalToTrack = Console.ReadLine();
                    var goal = goalManager.GetGoals().Find(g => g.Name.Equals(goalToTrack, StringComparison.OrdinalIgnoreCase));
                    if (goal != null)
                    {
                        progressTracker.AddPoints(goal.RecordEvent());
                    }
                    break;
                case 4: // Save and Exit
                    fileHandler.SaveData(goalManager, progressTracker);
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
