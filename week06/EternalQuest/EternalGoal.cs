using System;

public class EternalGoal : Goal
{
    private bool _goalIsCompleted;
    public EternalGoal(string goalName, string goalDescription, int points) : base(goalName, goalDescription, points)
    {
        _goalName = "";
        _goalDescription = "";
        _points = 0;

    }
    public override void RecordEvent()
    {
        
    }

    public override bool IsGoalCompleted()
    {
        return _goalIsCompleted;
    }

    public override string GetRepresentation()
    {
        return $"Eternal Goal: {_goalName} {_goalDescription} {_points}";
    }

    public override string GetDetails()
    {
        if (_goalIsCompleted)
        {
            return $"[X]" + _goalName + "(" + _goalDescription + ")";
        }

        else
        {
            return $"[ ]" + _goalName + "(" + _goalDescription + ")";
        }
        
        
      
    }
}