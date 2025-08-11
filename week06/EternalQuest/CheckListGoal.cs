using System;

public class CheckListGoal : Goal
{
    private int _amountGoalsCompleted;
    private int _target;

    private int _extraBonus;
    public CheckListGoal(string goalName, string goalDescription, int points, int amountGoalsCompleted, int target, int extraBonus) : base(goalName, goalDescription, points)
    {
        _goalName = "";
        _goalDescription = "";
        _points = 0;
        _amountGoalsCompleted = amountGoalsCompleted;
        _target = target;
        _extraBonus = extraBonus;
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
    public string GetRepresentationString()
    {

    }


}