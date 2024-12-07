using System;

namespace ADHDToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ADHD To-Do List App!");

            User user = new User();

            Room kitchen = new Room("Kitchen");
            Task task1 = new Task("Wash dishes", "Kitchen");
            Task task2 = new Task("Wipe counters", "Kitchen");

            kitchen.AddTask(task1);
            kitchen.AddTask(task2);

            Event event1 = new Event("Friendsgiving", 60);
            event1.AddRoom(kitchen);

            Alert alert1 = new Alert("Reminder", 30, "Chime");
            event1.AddReminder(alert1);

            task1.MarkComplete();
            user.AddPoints(event1.CalculatePoints());

            Console.WriteLine(user.CheckProgress());
        }
    }
}
