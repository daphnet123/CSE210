namespace ADHDToDoListApp
{
    public class Alert
    {
        private string type;
        private int time; 
        private string soundPreference;

        public Alert(string type, int time, string soundPreference)
        {
            this.type = type;
            this.time = time;
            this.soundPreference = soundPreference;
        }

        public void TriggerAlert()
        {
            Console.WriteLine($"[ALERT]: {type} alert triggered {time} minutes before event!");
        }
    }
}
