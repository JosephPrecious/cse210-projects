using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        //the first part of the project 
        /*Console.Write("what is the magic number? ");
        int number1 = int.Parse(Console.ReadLine());*/

        Random randomGenerator = new Random();
        int number1 = randomGenerator.Next(1, 100);//this will genarate a ramdom number number that i don't know 

        int guess1 = 0;

        while (number1 != guess1)
        {
            Console.Write("what is your guess? ");
            int guess2 = int.Parse(Console.ReadLine());


            if (guess2 < number1)
            {
                Console.WriteLine("Higher");
            }

            else if (guess2 > number1)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("you guessed it Right!");
            }

        }
    }
}