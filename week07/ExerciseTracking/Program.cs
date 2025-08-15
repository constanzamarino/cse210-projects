using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        Running runningActivity = new Running("30 Dec 2024", "Running", 30, 5);
        StationaryBicycles cyclingActivity = new StationaryBicycles("03 Jan 2025", "Stationary Cycling", 20, 4);
        SwimmingPool swimmingActivity = new SwimmingPool("07 Jan 2025", "Swimming", 40, 2);

        _activities.Add(runningActivity);
        _activities.Add(cyclingActivity);
        _activities.Add(swimmingActivity);

        

        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }


    }
}