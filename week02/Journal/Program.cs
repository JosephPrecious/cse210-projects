using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Welcome to your Journal");


        Journal journal = new Journal();
        string[] prompts = new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")//else if statement is use for the menu options
                {
                    Random random = new Random();
                    string prompt = prompts[random.Next(prompts.Length)];
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                }

                else if (choice == "2")
                {
                    journal.DisplayEntries();
                }

                else if (choice == "3")
                {
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                }

                else if (choice =="4")
                {
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                }

                else if (choice == "5")
                {
                    Console.WriteLine("Goodbye!");
                }

                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            
        }
    }
}
