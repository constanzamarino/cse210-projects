using System;

public class Running : Activity
{
    private int _runningLaps;
    public Running(string date, string activityName, int timeInMinutes, int runningLaps, float distanceInKm, float speed, float pace)
    : base(date, activityName, timeInMinutes, distanceInKm, speed, pace)
    {
        _runningLaps = runningLaps;

    }

    public override float CalculateDistance()
    {
        _distanceInKm = _runningLaps * 50 / 1000;
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