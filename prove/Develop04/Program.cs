public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing Exercise");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().RunBreathingExercise();
                    break;
                case "2":
                    new ReflectingActivity().RunReflection();
                    break;
                case "3":
                    new ListingActivity().RunListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
