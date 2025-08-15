using System;

public class StationaryBicycles : Activity
{
    private int _speed;
    public StationaryBicycles(string date, string activityName, int timeInMinutes, int speed)
    : base(date, activityName, timeInMinutes)
    {
        _speed = speed;
    }

    public override float CalculateDistance()
    {
        return _speed * GetTime() / 60f;
    }
    public override float CalculateSpeed()
    {
        return _speed;
    }

    public override float CalculatePace()
    {

        return GetTime() / CalculateDistance();
    }

    
}