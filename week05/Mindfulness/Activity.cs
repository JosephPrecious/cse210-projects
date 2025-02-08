class Activity
{
    protected string Name;
    protected string Description;
    protected int _duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"{Name} Activity\n");
        Console.WriteLine(Description);
        Console.Write("Enter duration (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Pause(3);
    }

    public void End()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"Activity: {Name}, Duration: {_duration} seconds");
        Pause(3);
    }

    protected void Pause(int seconds)
    {
        Thread.Sleep(seconds * 1000);
    }

    protected void DisplayAnimation(string message, int seconds)
    {
        Console.Write(message);
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Pause(1);
        }
        Console.WriteLine();
    }

    public virtual void Run()
    {
        Start();
        ExecuteActivity();
        End();
    }

    protected virtual void ExecuteActivity() {}
}
