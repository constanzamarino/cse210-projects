using System;

public class SwimmingPool : Activity
{
    private int _swimmingLaps;


    public SwimmingPool(string date, string activityName, int timeInMinutes, int swimmingLaps, float distanceInKm, float speed, float pace)
    : base(date, activityName, timeInMinutes, distanceInKm, speed, pace)
    {
        _swimmingLaps = swimmingLaps;
        
    }
    public override float CalculateDistance()
    {
        _distanceInKm = _swimmingLaps * 50 / 1000;
        return _distanceInKm;
    }

    public override float CalculateSpeed()
    {
        _speed = _distanceInKm / _timeInMinutes * 60;
        return _speed;
    }

    public override float CalculatePace()
    {
        _pace = _timeInMinutes / _distanceInKm;
        return _pace;
    }
}