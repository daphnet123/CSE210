using System.IO;
using Newtonsoft.Json;

public class FileHandler
{
    private const string GoalFilePath = "goals.json";
    private const string ProgressFilePath = "progress.json";

    private static readonly JsonSerializerSettings JsonSettings = new JsonSerializerSettings
    {
        TypeNameHandling = TypeNameHandling.Auto,
        Formatting = Formatting.Indented
    };

    public void SaveData(GoalManager goalManager, ProgressTracker progressTracker)
    {
        File.WriteAllText(GoalFilePath, JsonConvert.SerializeObject(goalManager.GetGoals(), JsonSettings));
        File.WriteAllText(ProgressFilePath, JsonConvert.SerializeObject(progressTracker, JsonSettings));
    }

    public (GoalManager, ProgressTracker) LoadData()
    {
        if (File.Exists(GoalFilePath) && File.Exists(ProgressFilePath))
        {
            var goals = JsonConvert.DeserializeObject<List<Goal>>(File.ReadAllText(GoalFilePath), JsonSettings);
            var progress = JsonConvert.DeserializeObject<ProgressTracker>(File.ReadAllText(ProgressFilePath), JsonSettings);

            GoalManager goalManager = new GoalManager();
            foreach (var goal in goals)
                goalManager.AddGoal(goal);

            return (goalManager, progress);
        }

        return (new GoalManager(), new ProgressTracker());
    }
}
