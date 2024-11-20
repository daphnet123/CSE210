using System.IO;
using System.Text.Json;

public class FileHandler
{
    private const string GoalFilePath = "goals.json";
    private const string ProgressFilePath = "progress.json";

    private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
    {
        WriteIndented = true, 
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase 
    };

    public void SaveData(GoalManager goalManager, ProgressTracker progressTracker)
    {
        File.WriteAllText(GoalFilePath, JsonSerializer.Serialize(goalManager.GetGoals(), JsonOptions));
        File.WriteAllText(ProgressFilePath, JsonSerializer.Serialize(progressTracker, JsonOptions));
    }

    public (GoalManager, ProgressTracker) LoadData()
    {
        if (File.Exists(GoalFilePath) && File.Exists(ProgressFilePath))
        {
            var goalsJson = File.ReadAllText(GoalFilePath);
            var progressJson = File.ReadAllText(ProgressFilePath);

            var goals = JsonSerializer.Deserialize<List<Goal>>(goalsJson, JsonOptions);
            var progress = JsonSerializer.Deserialize<ProgressTracker>(progressJson, JsonOptions);

            GoalManager goalManager = new GoalManager();
            foreach (var goal in goals)
                goalManager.AddGoal(goal);

            return (goalManager, progress);
        }

        return (new GoalManager(), new ProgressTracker());
    }
}
