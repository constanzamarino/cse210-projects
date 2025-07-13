using System;

using System.Collections.Generic;


public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random _randomNumberGenerator = new Random();
        int index = _randomNumberGenerator.Next(_prompts.Count);
        return _prompts[index];
    }
    public void LoadRandomPrompt()

    {
        _prompts.Add("How I have been feeling lately?");
        _prompts.Add("What was the most exciting thing that happened to me today?");
        _prompts.Add("Did I learn something new today, whether a skill or a topic?");
        _prompts.Add("What is a limiting belief I need to let go of?");
        _prompts.Add("What song, movie or book has resonated with me recently?");

    }

}
