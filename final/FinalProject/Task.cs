namespace ADHDToDoListApp
{
    public class Task
    {
        private string name;
        private bool isCompleted;

        public Task(string name)
        {
            this.name = name;
            isCompleted = false;
        }

        public void MarkComplete()
        {
            if (!isCompleted)
            {
                isCompleted = true;
                Console.WriteLine($"Task '{name}' completed!");
            }
        }

        public string GetStatus()
        {
            return isCompleted ? "Completed" : "Not Started";
        }
    }
}
