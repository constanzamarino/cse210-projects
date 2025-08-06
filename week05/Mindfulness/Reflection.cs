using System;

public class Reflection : Activity
{
    private List<string> _questions;

    private List<string> _randomPrompts;

    public Reflection(string name, string description, int timeDuration) : base(name, description, timeDuration)
    {
        _questions = new List<string>();
        _randomPrompts = new List<string>();

    }

    public void RunReflectionActivity()
    {

    }

    public string GetQuestions()
    {
        Random aRandomQuestion = new Random();
        int index = aRandomQuestion.Next(_questions.Count);
        return _questions[index];
    }

    public string GetRandomPrompt()
    {
        Random aRandomPrompt = new Random();
        int index2 = aRandomPrompt.Next(_randomPrompts.Count);
        return _randomPrompts[index2];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine();
    }

    public void DisplayQuestions()
    {
        Console.WriteLine();
    }


}