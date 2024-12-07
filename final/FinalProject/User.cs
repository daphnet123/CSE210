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

        public void AddPoints(int points)
        {
            this.points += points;
            Console.WriteLine($"Points added! Current points: {this.points}");
        }

        public string CheckProgress()
        {
            return $"Points: {points}, Badges: {badges}";
        }
    }
}
