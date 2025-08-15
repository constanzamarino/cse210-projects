using System;

public class SwimmingPool : Activity
{
    private int _swimmingLaps;


    public SwimmingPool(string date, string activityName, int timeInMinutes, int swimmingLaps) 
    : base(date, activityName, timeInMinutes )
    {
        _swimmingLaps = swimmingLaps;
        
    }
    public override float CalculateDistance()
    {
         
        return _swimmingLaps * 50 / 1000;
    }

    public override float CalculateSpeed()
    {
        
        return CalculateDistance() / GetTime() * 60;
    }

    public override float CalculatePace()
    {
        return GetTime() / CalculateDistance();
    }
}