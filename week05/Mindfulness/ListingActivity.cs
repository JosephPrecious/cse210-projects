class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on positive things by listing as many as you can.") {}

    protected override void ExecuteActivity()
    {
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        Pause(3);
        Console.WriteLine("Start listing items:");
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items.");
    }
}
