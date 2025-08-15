using System;

public class Running : Activity
{
    private int _runningLaps;
    public Running(string date, string activityName, int timeInMinutes, int runningLaps)
    : base(date, activityName, timeInMinutes)
    {
        _runningLaps = runningLaps;

    }

    public override float CalculateDistance()
    {
        
        return _runningLaps * 50 / 1000f;
    }

    public override float CalculateSpeed()
    {
         
        return CalculateDistance() / GetTime() * 60f; 
    }

    public override float CalculatePace()
    {
         
        return GetTime() / CalculateDistance();
    }

}