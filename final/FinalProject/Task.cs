namespace ADHDToDoListApp
{
    public class Task
    {
        private string name;
        private string room;
        private bool isCompleted;
        private bool isTried;

        public Task(string name, string room)
        {
            this.name = name;
            this.room = room;
            isCompleted = false;
            isTried = false;
        }

        public void MarkComplete()
        {
            isCompleted = true;
            Console.WriteLine($"Task '{name}' completed in {room}!");
        }

        public void MarkTried()
        {
            isTried = true;
            Console.WriteLine($"Task '{name}' was attempted in {room}!");
        }

        public string GetStatus()
        {
            return isCompleted ? "Completed" : (isTried ? "Tried" : "Not Started");
        }
    }
}
