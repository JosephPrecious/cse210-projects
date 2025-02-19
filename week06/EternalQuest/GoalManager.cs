using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.GetName() == goalName)
            {
                goal.RecordEvent();
                _totalPoints += goal.GetPoints();
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    public void ShowGoals()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        Console.WriteLine($"Total Score: {_totalPoints} points");
    }
}
