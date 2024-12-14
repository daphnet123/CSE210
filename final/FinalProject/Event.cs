using System;
using System.Collections.Generic;

namespace ADHDToDoListApp
{
    public class Event : Activity
    {
        private List<Room> rooms;
        private List<Alert> reminders;

        public Event(string name, DateTime scheduledTime)
            : base(name, scheduledTime)
        {
            rooms = new List<Room>();
            reminders = new List<Alert>();
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
            Console.WriteLine($"Room '{room}' added to event '{Name}'.");
        }

        public void AddReminder(Alert alert)
        {
            reminders.Add(alert);
            Console.WriteLine($"Reminder added to event '{Name}'.");
        }

        public override int CalculatePoints()
        {
            return rooms.Count * 100; // Example scoring system
        }

        public void CheckReminders()
        {
            foreach (var reminder in reminders)
            {
                reminder.TriggerAlert(ScheduledTime);
            }
        }
    }
}
