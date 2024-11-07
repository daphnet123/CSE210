public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Exercise", "A simple breathing exercise to help you relax.") { }

    public void RunBreathingExercise()
    {
        DisplayStartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Inhale... (hold for 4 seconds)");
            PauseWithCountdown(4);

            Console.WriteLine("Exhale... (hold for 6 seconds)");
            PauseWithCountdown(6);

            if (DateTime.Now >= endTime)
            {
                break;
            }
        }

        DisplayEndMessage();
    }
}
