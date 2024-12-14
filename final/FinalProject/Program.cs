using System;
using System.Collections.Generic;

namespace ADHDToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ADHD To-Do List App!");

            User user = new User();

            // Room and Tasks
            Room kitchen = new Room("Kitchen");
            kitchen.AddTask(new Task("Wash dishes"));
            kitchen.AddTask(new Task("Wipe counters"));

            // Event and Alerts
            Event friendsgiving = new Event("Friendsgiving", DateTime.Now.AddMinutes(60));
            friendsgiving.AddRoom(kitchen);
            friendsgiving.AddReminder(new Alert("Reminder", DateTime.Now.AddMinutes(30), "Chime"));

            // Marking task as completed and earning points
            kitchen.GetTasks()[0].MarkComplete();
            user.AddPoints(friendsgiving.CalculatePoints());

            // Trigger alerts
            friendsgiving.CheckReminders();

            // Display user progress
            Console.WriteLine(user.CheckProgress());

            Console.WriteLine("Visit the project repository for more details: https://github.com/daphnet123/CSE210.git");
            // Project repository: https://github.com/daphnet123/CSE210.git //

        }
    }
}
