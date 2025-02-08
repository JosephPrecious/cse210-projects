class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on moments when you showed strength and resilience.") {}

    protected override void ExecuteActivity()
    {
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        Pause(3);
        for (int i = 0; i < _duration / 5; i++)
        {
            Console.WriteLine(_questions[random.Next(_questions.Count)]);
            Pause(5);
        }
    }
}