public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Goal '{_name}' completed! You earned {_points} points.");
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString() =>
        $"[{(_isComplete ? "X" : " ")}] {_name} - {_description}";
}
