using System;

public abstract class Activity
{
    protected string _date;
    protected int _timeDuration;

    protected float _distanceInKm;

    protected float _speed;

    protected float _pace;

    public Activity(string date, int timeDuration, float distanceInKm, float speed, float pace)
    {
        _date = date;
        _timeDuration = timeDuration;
        _distanceInKm = distanceInKm;
        _speed = speed;
        _pace = pace;
    }

    public abstract float CalculateDistance();

    public abstract float CalculateSpeed();

    public abstract float CalculatePace();


    public string GetDate()
    {
        // create an object for the date
        return $"";
    }
    public string GetSummary()
    {
        return $"";
    }

}