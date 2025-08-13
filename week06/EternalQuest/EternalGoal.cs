using System;

public class EternalGoal : Goal
{
    
    public EternalGoal(string goalName, string goalDescription, int points) : base(goalName, goalDescription, points)
    {
        _goalName = "";
        _goalDescription = "";
        _points = 0;

    }
    public override void RecordEvent()
    {
        //Add code
    }

    public override bool IsGoalCompleted()
    {
        return false;
    }

    public override string GetRepresentation()
    {
        return $"Eternal Goal: {_goalName} {_goalDescription} {_points}";
    }

    public override string GetDetails()
    {
        return $"[ ]" + _goalName + "(" + _goalDescription + ")"; 
      
    }
}