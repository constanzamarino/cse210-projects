using System;

public class Reflection : Activity
{
    private List<string> _questions;

    private List<string> _randomPrompts;

    public Reflection(string name, string description, int timeDuration, List<string> questions, List<string> randomPrompts) : base(name, description, timeDuration)
    {
        _questions = questions;
        _randomPrompts = randomPrompts;

    }

    public void RunReflectionActivity()
    {

    }

    public string GetRandomPrompt()
    {
        Random aRandomPrompt = new Random();
        int index = aRandomPrompt.Next(_randomPrompts.Count);
        return _randomPrompts[index];
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {

    }


}