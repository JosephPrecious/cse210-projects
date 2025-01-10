using System;
using System.Diagnostics;
using System.IO.Compression;
using System.Threading.Tasks.Dataflow;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade? %");
        string gradeAnswer = Console.ReadLine();
        int grade = int.Parse(gradeAnswer);

        string gradeletter = "";

        if (grade >= 90)
        {
            gradeletter = "A";
        }

        else if (grade >= 80)
        {
              gradeletter = "B";
        }

        else if (grade >= 70)
        {
             gradeletter = "C";
        }

        else if (grade >= 60)
        {
              gradeletter = "D";
        }

        else 
        {
             gradeletter = "F";
        }

        Console.WriteLine($"ypur grade is {gradeletter}");

        if (grade >= 70)
        {
            Console.WriteLine("your passed your class");

        }

        else
        {
            Console.WriteLine("you faaid the course try again nest sementer");
        }
    }
}