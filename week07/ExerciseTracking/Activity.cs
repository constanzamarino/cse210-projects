using System;

public abstract class Activity
{
    protected string _date;

    protected string _activityName;
    protected int _timeInMinutes;
    


    public Activity(string date, string activityName, int timeInMinutes)
    {
        _date = date;
        _activityName = activityName;
        _timeInMinutes = timeInMinutes;
      
    }

    public abstract float CalculateDistance();

    public abstract float CalculateSpeed();

    public abstract float CalculatePace();

    public int GetTime()
    {
        return _timeInMinutes;
    }
    public string GetSummary()
    {
        float _distanceInKm = CalculateDistance();
        float _speed1 = CalculateSpeed();
        float _pace = CalculatePace();
        return $"{_date} {_activityName} ({_timeInMinutes} min) - Distance: {_distanceInKm} km, Speed: {_speed1} kph, Pace: {_pace} min per km";
    }

}