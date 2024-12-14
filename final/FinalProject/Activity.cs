using System;

namespace ADHDToDoListApp
{
    public abstract class Activity
    {
        public string Name { get; private set; }
        public DateTime ScheduledTime { get; private set; }

        protected Activity(string name, DateTime scheduledTime)
        {
            Name = name;
            ScheduledTime = scheduledTime;
        }

        public abstract int CalculatePoints();

        public void DisplayDetails()
        {
            Console.WriteLine($"{Name} scheduled for {ScheduledTime}");
        }
    }
}
