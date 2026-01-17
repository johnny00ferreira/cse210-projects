using System;

// - Used random prompts to reduce user overwhelm.
// - Automatically stored the date for each entry.
// - Used file persistence to allow journaling across multiple days.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Entry entry = new Entry();

                DateTime currentDate = DateTime.Now;
                entry._date = currentDate.ToShortDateString();

                entry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine(entry._promptText);
                Console.Write("> ");
                entry._responseText = Console.ReadLine();

                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
        }
    }
}
