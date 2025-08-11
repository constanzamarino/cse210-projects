using System;

public class Goal
{
    protected string _goalName;
    protected string _goalDescription;

    protected int _points;

    public Goal(string goalName, string goalDescription, int points)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
    }

    public void RecordEvent()
    {

    }
    public bool IsGoalCompleted()
    {

    }

    public string GetDetails()
    {

    }

    public string GetRepresentationString();

}