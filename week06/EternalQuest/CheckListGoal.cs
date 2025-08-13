using System;

public class CheckListGoal : Goal
{
    protected int _amountGoalsCompleted;
    protected int _target;

    protected int _extraBonus;
    public CheckListGoal(string goalName, string goalDescription, int points, int target, int extraBonus) : base(goalName, goalDescription, points)
    {
        _goalName = "";
        _goalDescription = "";
        _points = 0;
        _target = target;
        _extraBonus = extraBonus;
    }
    public override void RecordEvent()
    {

    }

    public override bool IsGoalCompleted()
    {
        return true;
    }
    public override string GetDetails()
    {
        
    }
    public override string GetRepresentation()
    {
        return $"CheckList Goal: {_goalName} {_goalDescription} {_points}";
    }


}