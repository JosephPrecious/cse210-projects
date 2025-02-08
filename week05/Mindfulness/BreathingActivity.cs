class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through slow breathing.") {}

    protected override void ExecuteActivity()
    {
        for (int i = 0; i < _duration / 6; i++)
        {
            Console.WriteLine("Breathe in...");
            Pause(3);
            Console.WriteLine("Breathe out...");
            Pause(3);
        }
    }
}