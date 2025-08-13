using System;

public abstract class Goal
{
    protected string _goalName;
    protected string _goalDescription;

    public int _points;

    public Goal(string goalName, string goalDescription, int points)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsGoalCompleted();

    public abstract string GetDetails();

    public  abstract string GetRepresentation();

}