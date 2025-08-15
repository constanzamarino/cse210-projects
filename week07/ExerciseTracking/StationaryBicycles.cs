using System;

public class StationaryBicycles : Activity
{
    private int _cyclingLaps;
    public StationaryBicycles(string date, string activityName, int timeInMinutes, int cyclingLaps, float distanceInKm, float speed, float pace)
    : base(date, activityName, timeInMinutes, distanceInKm, speed, pace)
    {
        _cyclingLaps = cyclingLaps;
    }

    public override float CalculateSpeed()
    {
        _speed = 60 / _pace;
        return _speed;
    }

    public override float CalculatePace()
    {
        _pace = 60 / _speed;
        return _pace;
    }

    public override float CalculateDistance()
    {
        throw new NotImplementedException();
    }
}