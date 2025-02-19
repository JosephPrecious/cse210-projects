public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) 
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        Console.WriteLine($"Recorded progress on '{_name}'. You earned {_points} points.");

        if (_currentCount == _targetCount)
        {
            Console.WriteLine($"Goal '{_name}' completed! You earned a bonus of {_bonusPoints} points!");
        }
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override string GetDetailsString() =>
        $"[{(_currentCount >= _targetCount ? "X" : " ")}] {_name} - {_description} (Completed {_currentCount}/{_targetCount} times)";
}
