public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration = 300) 
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"\nStarting {_name}: {_description}");
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"\nEnding {_name}. Hope you feel refreshed!\n");
    }

    public void PauseWithSpinner(int seconds)
    {
        Console.Write("Pausing");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }

    public void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rCountdown: {i} seconds remaining...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
