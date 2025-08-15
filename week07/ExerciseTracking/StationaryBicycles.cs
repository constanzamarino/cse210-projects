using System;

public class StationaryBicycles : Activity
{
    private int _cyclingLaps;
    public StationaryBicycles(string date, string activityName, int timeInMinutes, int cyclingLaps)
    : base(date, activityName, timeInMinutes)
    {
        _cyclingLaps = cyclingLaps;
    }

    public override float CalculateSpeed()
    {
        return 60 / CalculatePace();
    }

    public override float CalculatePace()
    {

        return 60 / CalculateSpeed();
    }

    public override float CalculateDistance()
    {
        throw new NotImplementedException();
    }
}