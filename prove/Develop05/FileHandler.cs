using System;
using System.IO;
using Newtonsoft.Json;

public class FileHandler
{
    private const string GoalFilePath = "goals.json";
    private const string ProgressFilePath = "progress.json";

    public void SaveData(GoalManager goalManager, ProgressTracker progressTracker)
    {
        var goalData = JsonConvert.SerializeObject(goalManager.GetGoals());
        var progressData = JsonConvert.SerializeObject(progressTracker);

        File.WriteAllText(GoalFilePath, goalData);
        File.WriteAllText(ProgressFilePath, progressData);
    }

    public (GoalManager, ProgressTracker) LoadData()
    {
        if (File.Exists(GoalFilePath) && File.Exists(ProgressFilePath))
        {
            var goalData = File.ReadAllText(GoalFilePath);
            var progressData = File.ReadAllText(ProgressFilePath);

            var goalList = JsonConvert.DeserializeObject<List<Goal>>(goalData);
            var progressTracker = JsonConvert.DeserializeObject<ProgressTracker>(progressData);

            GoalManager goalManager = new GoalManager();
            foreach (var goal in goalList)
            {
                goalManager.AddGoal(goal);
            }

            return (goalManager, progressTracker);
        }

        return (new GoalManager(), new ProgressTracker());
    }
}
