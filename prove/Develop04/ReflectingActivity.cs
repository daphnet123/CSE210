public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflection", "Reflect on meaningful moments.")
    {
        _prompts = new List<string> 
        {
            "Think of a time when you felt proud of yourself.",
            "Remember a moment of joy in your life.",
            "Think about an instance where you showed kindness."
        };
        
        _questions = new List<string> 
        {
            "How did it make you feel?",
            "What did you learn from it?",
            "How has it impacted your life?"
        };
    }

    public void RunReflection()
    {
        DisplayStartMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine("\nReflect on the following prompt:");
        Console.WriteLine(prompt);

        PauseWithCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration - 10); 

        foreach (string question in _questions)
        {
            if (DateTime.Now >= endTime)
            {
                break;
            }

            Console.WriteLine("\n" + question);
            PauseWithCountdown(10); 
        }

        DisplayEndMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}
