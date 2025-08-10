using System;


public class Breathing : Activity
{
    public Breathing(string name, string description, int timeDuration) : base(name, description, timeDuration)
    {
        _name = "\n***Breathing activity***";
        _description = "\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void RunBreathingActivity()
    {
        DisplayStartingMessage();
        int sessionTime1 = AskDuration();

        Console.WriteLine("Get ready...");
        ShowTheSpinner(2);

        int lapse = 0;

        while (lapse < _timeDuration)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            lapse += 4;

            if (lapse >= _timeDuration) break;

            Console.Write("Breathe out... ");
            ShowCountDown(4);
            lapse += 4;

        }

        DisplayEndingMessage();
        DisplayActivityDate();

    }
}