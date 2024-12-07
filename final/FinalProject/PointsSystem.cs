namespace ADHDToDoListApp
{
    public class PointsSystem
    {
        private int totalPoints;
        private const int badgeThreshold = 1000;

        public PointsSystem()
        {
            totalPoints = 0;
        }

        public void AddPoints(int points)
        {
            totalPoints += points;
            Console.WriteLine($"Points added! Total: {totalPoints}");
        }

        public string CheckForBadge()
        {
            if (totalPoints >= badgeThreshold)
            {
                totalPoints -= badgeThreshold; 
                return "Congratulations! You earned a badge!";
            }
            return "Keep going! You're close to earning a badge.";
        }
    }
}
