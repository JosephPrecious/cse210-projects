using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Welcome. Can you give us your name ");

        Console.WriteLine("what is your first Name?" );
        string firstName = Console.ReadLine();

        Console.WriteLine("what is your last name?" );
        string lastName = Console.ReadLine();

        Console.WriteLine(value: $"Your name is {lastName}, {firstName} {lastName}");
    }
}