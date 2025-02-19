public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded progress on '{_name}'. You earned {_points} points.");
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString() =>
        $"[∞] {_name} - {_description}";
}
