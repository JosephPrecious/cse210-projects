using System;

class Program
{
    static void Main(string[] args)
    {
       GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\n--- Eternal Quest Program ---");
            Console.WriteLine("1. Create a Simple Goal");
            Console.WriteLine("2. Create an Eternal Goal");
            Console.WriteLine("3. Create a Checklist Goal");
            Console.WriteLine("4. Record an Event");
            Console.WriteLine("5. Show Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter goal name: ");
                    string simpleName = Console.ReadLine();
                    Console.Write("Enter description: ");
                    string simpleDesc = Console.ReadLine();
                    Console.Write("Enter points: ");
                    int simplePoints = int.Parse(Console.ReadLine());

                    goalManager.AddGoal(new SimpleGoal(simpleName, simpleDesc, simplePoints));
                    break;

                case "2":
                    Console.Write("Enter goal name: ");
                    string eternalName = Console.ReadLine();
                    Console.Write("Enter description: ");
                    string eternalDesc = Console.ReadLine();
                    Console.Write("Enter points: ");
                    int eternalPoints = int.Parse(Console.ReadLine());

                    goalManager.AddGoal(new EternalGoal(eternalName, eternalDesc, eternalPoints));
                    break;

                case "3":
                    Console.Write("Enter goal name: ");
                    string checklistName = Console.ReadLine();
                    Console.Write("Enter description: ");
                    string checklistDesc = Console.ReadLine();
                    Console.Write("Enter points: ");
                    int checklistPoints = int.Parse(Console.ReadLine());
                    Console.Write("Enter target count: ");
                    int targetCount = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points: ");
                    int bonusPoints = int.Parse(Console.ReadLine());

                    goalManager.AddGoal(new ChecklistGoal(checklistName, checklistDesc, checklistPoints, targetCount, bonusPoints));
                    break;

                case "4":
                    Console.Write("Enter the name of the goal you completed: ");
                    string recordName = Console.ReadLine();
                    goalManager.RecordEvent(recordName);
                    break;

                case "5":
                    goalManager.ShowGoals();
                    break;

                case "6":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
