using System;
using System.Collections.Generic;

namespace ADHDToDoListApp
{
    public class Event
    {
        private string name;
        private List<Room> rooms;
        private int duration; 
        private List<Alert> reminders;

        public Event(string name, int duration)
        {
            this.name = name;
            this.duration = duration;
            rooms = new List<Room>();
            reminders = new List<Alert>();
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
            Console.WriteLine($"Room '{room}' added to event '{name}'!");
        }

        public void AddReminder(Alert alert)
        {
            reminders.Add(alert);
            Console.WriteLine($"Reminder added to event '{name}'!");
        }

        public int CalculatePoints()
        {
            int totalPoints = 0;
            foreach (var room in rooms)
            {
                totalPoints += 100; 
            }
            return totalPoints;
        }
    }
}
