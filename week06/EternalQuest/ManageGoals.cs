using System;

public class ManageGoals : Goal
{
    private List<Goal> _goals;
    private int _score;
    public ManageGoals(string goalName, string goalDescription, int points, int score) : base(goalName, goalDescription, points)
    {
       
        _goals = new List<Goal>()
        {

        };
        _score = score;
    }

    //Add more methods
}