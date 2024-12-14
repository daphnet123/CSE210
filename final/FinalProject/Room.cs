using System.Collections.Generic;

namespace ADHDToDoListApp
{
    public class Room
    {
        private string name;
        private List<Task> tasks;

        public Room(string name)
        {
            this.name = name;
            tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
            Console.WriteLine($"Task '{task.GetStatus()}' added to {name}.");
        }

        public List<Task> GetTasks()
        {
            return tasks;
        }
    }
}
