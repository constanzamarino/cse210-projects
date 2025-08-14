using System;

public class CheckListGoal : Goal
{
    protected int _amountGoalsCompleted;
    protected int _target;

    protected int _extraBonus;
    public CheckListGoal(string goalName, string goalDescription, int points, int target, int extraBonus)
    : base(goalName, goalDescription, points)
    {
        _amountGoalsCompleted = 0;
        _target = target;
        _extraBonus = extraBonus;
    }
    public override void RecordEvent()
    {
        _amountGoalsCompleted++;
    }

    public override bool IsGoalCompleted()
    {
        return _amountGoalsCompleted >= _target;
    }
    public override string GetDetails()
    {
        string _checkingMark = IsGoalCompleted() ? "[X]" : "[ ]";

        return $"{_checkingMark} {_goalName} ( {_goalDescription} ) --> Currently Completed {_amountGoalsCompleted}/{_target}";



    }
    public override string GetRepresentation()
    {
        return $"CheckList Goal, {_goalName}, {_goalDescription}, {_points}, {_target}, {_extraBonus}, {_amountGoalsCompleted}";
    }

    public int GetBouns()
    {
        return _extraBonus;
    }

}