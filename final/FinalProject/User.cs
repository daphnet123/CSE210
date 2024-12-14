namespace ADHDToDoListApp
{
    public class User
    {
        private int points;
        private int badges;

        public User()
        {
            points = 0;
            badges = 0;
        }

        public void AddPoints(int earnedPoints)
        {
            points += earnedPoints;

            // Award badges for milestones
            if (points >= 500 && badges < 1) badges = 1;
            if (points >= 1000 && badges < 2) badges = 2;

            Console.WriteLine($"Points added! Current points: {points}");
        }

        public string CheckProgress()
        {
            return $"Points: {points}, Badges: {badges}";
        }
    }
}
