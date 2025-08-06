using System;

using System.Threading.Channels;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _timeDuration;

    public Activity(string name, string description, int timeDuration)
    {
        _name = name;
        _description = description;
        _timeDuration = timeDuration;

    }

    public void Display()
    {
        Console.WriteLine($"{_name}\n{_description}");
    }

    public void DisplayStartingMessage()
    {
        
    }

    public void DisplayEndingMessage()
    {
        
    }

    public void ShowCountDown(int timeInSeconds)
    {
        Console.WriteLine("In how long do you want to spend in this session? (Seconds)");
        string user_time_choice = Console.ReadLine();
        timeInSeconds = int.Parse(user_time_choice);
        
        for (int i = 5; 1 > 0; i--)
        {
            
            Thread.Sleep(timeInSeconds);
        }
     

    }

    public void ShowTheSpinner(int timeInSeconds)
    {
        List<string> _animationSpinner = new List<string>();
        _animationSpinner.Add("||");
        _animationSpinner.Add("//");
        _animationSpinner.Add("━");
        _animationSpinner.Add("||");
        _animationSpinner.Add("//");
        _animationSpinner.Add("━");
        _animationSpinner.Add("\\");

        foreach (string s in _animationSpinner)
        {
            Console.WriteLine(s);
            Thread.Sleep(timeInSeconds);
        }
        
    }
}