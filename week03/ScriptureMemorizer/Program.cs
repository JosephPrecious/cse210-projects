using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // Created a scripture library for scripture to be selected randomly
          ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();

        // Program loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Good job!");
                break;
            }

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine()?.ToLower();

            if (input == "quit")
                break;

            scripture.HideWords(3);
        }
    }
}

    
