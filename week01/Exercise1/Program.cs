using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Welcome. Can you give us your name ");

        Console.WriteLine("what is your first Name?");
        string first_name = Console.ReadLine();

        Console.WriteLine("what is your last name?");
        string last_name = Console.ReadLine();

        Console.WriteLine(value: $"Your name is {first_name}, {last_name} {first_name}");
    }
}