using System;

public abstract class Activity
{
    protected string _date;

    protected string _activityName;
    protected int _timeInMinutes;
    protected float _speed;

    protected float _pace;

    protected float _distanceInKm;


    public Activity(string date, string activityName, int timeInMinutes, float speed, float pace, float distanceInKm)
    {
        _date = date;
        _activityName = activityName;
        _timeInMinutes = timeInMinutes;
        _speed = speed;
        _pace = pace;
        _distanceInKm = distanceInKm;

    }

    public abstract float CalculateDistance();

    public abstract float CalculateSpeed();

    public abstract float CalculatePace();


    public string GetDate()
    {
        DateTime _date = DateTime.Now;
        string _dateOnly = _date.ToString("dd MM yyyy");
        return _dateOnly;
    }
    public string GetSummary()
    {
        return $"{_dateOnly} {_activityName}{_timeInMinutes} - Distance: {_distanceInKm} km, Speed: {_speed} kph, Pace: {_pace} min per km";
    }

}