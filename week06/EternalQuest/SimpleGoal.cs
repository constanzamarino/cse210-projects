using System;

public class SimpleGoal : Goal
{
    private bool goalIsCompleted;
    public SimpleGoal(string goalName, string goalDescription, int points) : base(goalName, goalDescription, points)
    {
        _goalName = "";
       _goalDescription = "";
        _points = 0;
    }

    public void RecordEvent()
    {

    }

    public bool IsGoalCompleted()
    {

    }

    public string GetRepresentationString()
    {
       
    }



}