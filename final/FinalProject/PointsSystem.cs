namespace ADHDToDoListApp
{
    public class PointsSystem
    {
        private int totalPoints;
        private const int badgeThreshold = 1000;
        public event Action<string> OnBadgeEarned;

        public PointsSystem()
        {
            totalPoints = 0;
        }

        public void AddPoints(int points)
        {
            totalPoints += points;
            Console.WriteLine($"Points added! Total: {totalPoints}");
            CheckForBadge();
        }

        public void RemovePoints(int points)
        {
            totalPoints -= points;
            if (totalPoints < 0)
            {
                totalPoints = 0;
            }
            Console.WriteLine($"Points removed! Total: {totalPoints}");
        }

        public string CheckForBadge()
        {
            if (totalPoints >= badgeThreshold)
            {
                totalPoints -= badgeThreshold;
                OnBadgeEarned?.Invoke("Congratulations! You earned a new badge!");
                return "Congratulations! You earned a new badge!";
            }
            return "Keep going! You're close to earning a new badge.";
        }
    }
}
