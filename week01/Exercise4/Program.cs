using System;
using System.Collections.Generic;

class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        int numberFromUSer = -1;
        while (numberFromUSer != 0)
        {
            Console.Write("Enter a list of numbers, (type 0 when finished): ");// get input from the user
            
            string userAnswer = Console.ReadLine();
            numberFromUSer = int.Parse(userAnswer);

            if (numberFromUSer != 0)
            {
                numbers.Add(numberFromUSer);
            }
        }
         int sumTotal = 0;
        foreach (int number in numbers)
        {
            sumTotal += number;
        }

        Console.WriteLine($"The sum is: {sumTotal}");

        double average = ((double)sumTotal) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        
        int maxNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        Console.WriteLine($"The max is: {maxNumber}");
    }
}