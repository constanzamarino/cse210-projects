using System;

public  class SimpleGoal : Goal
{
    private bool _goalIsCompleted;
    public SimpleGoal(string goalName, string goalDescription, int points) 
    : base(goalName, goalDescription, points)
    {
        _goalIsCompleted = false;
    }

    public override void RecordEvent()
    {
        _goalIsCompleted = true;
    }

    public override bool IsGoalCompleted()
    {
        return _goalIsCompleted;  
    }

    public override string GetRepresentation()
    {
        return $"Simple Goal: {_goalName}, {_goalDescription}, {_points}, {_goalIsCompleted}";
    }

    public override string GetDetails()
    {
        if (_goalIsCompleted)
        {
            return $"[X] { _goalName} + ({ _goalDescription})";
        }

        else
        {
            return $"[ ] { _goalName} + ({ _goalDescription})";
        }
        
        
       
    }
}