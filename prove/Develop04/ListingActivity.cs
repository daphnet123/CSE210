public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity() : base("Listing Exercise", "List items based on a prompt.")
    {
        _prompts = new List<string> 
        {
            "List things you're grateful for.",
            "List things that make you happy.",
            "List people who have positively influenced your life."
        };
    }

    public void RunListingActivity()
    {
        DisplayStartMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine("\nPlease respond to the following prompt:");
        Console.WriteLine(prompt);

        List<string> userResponses = new List<string>();
        Console.WriteLine("\nYou have 5 minutes to list as many as you can. Start typing...");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(">> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                userResponses.Add(response);
            }
        }

        Console.WriteLine($"\nYou listed {userResponses.Count} items:");
        foreach (var item in userResponses)
        {
            Console.WriteLine("- " + item);
        }

        DisplayEndMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}
