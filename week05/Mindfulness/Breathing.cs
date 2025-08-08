using System;
using System.Threading.Channels;

public class Breathing : Activity
{
    public Breathing(string name, string description, int timeDuration) : base(name, description, timeDuration)
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _timeDuration = 0;
    }

    public void RunBreathingActivity()
    {
        DisplayStartingMessage();
        DisplayEndingMessage();


    }
}