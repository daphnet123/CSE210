class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> scriptures = Scriptures.GetRandomScriptures();
        Random random = new Random();

        // Select a random scripture
        int index = random.Next(scriptures.Count);
        KeyValuePair<string, string> randomScripture = scriptures.ElementAt(index);

        string[] referenceParts = randomScripture.Key.Split(' ', ':');
        string book = referenceParts[0] + " " + referenceParts[1];
        int chapter = int.Parse(referenceParts[2].Split('-')[0]); 
        int startVerse = int.Parse(referenceParts[3].Split('-')[0]); 

        Reference reference = new Reference(book, chapter, startVerse);
        Scripture scripture = new Scripture(reference, randomScripture.Value);

        while (true)
        {
            Console.Clear();
            scripture.Display(); 

            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(); 

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }
        }
    }
}
