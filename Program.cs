using System;

/// <summary>
/// The main program class.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    myJournal.WriteNewEntry();
                    break;
                case "2":
                    myJournal.DisplayJournal();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string? saveFile = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(saveFile))
                    {
                        myJournal.SaveToFile(saveFile);
                    }
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string? loadFile = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(loadFile))
                    {
                        myJournal.LoadFromFile(loadFile);
                    }
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}