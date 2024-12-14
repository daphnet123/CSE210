using System;

namespace ADHDToDoListApp
{
    public class Alert
    {
        private string type;
        private DateTime triggerTime;
        private string soundPreference;

        public Alert(string type, DateTime triggerTime, string soundPreference)
        {
            this.type = type;
            this.triggerTime = triggerTime;
            this.soundPreference = soundPreference;
        }

        public void TriggerAlert(DateTime eventTime)
        {
            if (DateTime.Now >= triggerTime && DateTime.Now <= eventTime)
            {
                Console.WriteLine($"[ALERT]: {type} alert! Time: {triggerTime}. Sound: {soundPreference}.");
            }
        }
    }
}
