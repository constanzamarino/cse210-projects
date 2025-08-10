using System;
using System.Threading;

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
        Console.WriteLine($"{_name}\n{_description}\n");
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"{_name}\n{_description}\n");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done!\nYou have completed it in {_timeDuration} seconds!");
    }

    public int AskDuration()
    {
        Console.WriteLine("\nIn how long do you want to spend in this session? (in seconds)");
        if (int.TryParse(Console.ReadLine(), out int secs) && secs > 0)
        {
            _timeDuration = secs;
            return secs;
        }
         Console.WriteLine("Invalid input. Using default 30 seconds.");
        _timeDuration = 30;
        return 30;
    }
    public void ShowCountDown(int timeInSeconds)
    {

        for (int i = timeInSeconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();

    }

    public void ShowTheSpinner(int timeInSeconds)
    {
        List<string> _animationSpinner = new List<string>()
        {
            "|", "/", "-", "\\"
        };

        DateTime endTime = DateTime.Now.AddSeconds(timeInSeconds);
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(_animationSpinner[index]);
            Thread.Sleep(600);
            Console.Write("\b");
            index = (index + 1) % _animationSpinner.Count;
        }
        Console.Write(" ");
        Console.Write("\b");    
    }

    public void DisplayActivityDate()
    {
        Console.WriteLine(DateTime.Now.ToString("\nyyyy-MM-dd - HH:mm\n"));
    }

        
    
}