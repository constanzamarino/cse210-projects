using System;

using System.Collections.Generic;


public class PromptGenerator
{
    public List<string> _prompts;


    public PromptGenerator()

    {
        _prompts = new List<string>
        {
            "How I have been feeling lately?",
            "What was the most exciting thing that happened to me today?",
            "Did I learn something new today, whether a skill or a topic?",
            "What is a limiting belief I need to let go of?",
            "What song, movie or book has resonated with me recently?"

        };

    }
    public string GetRandomPrompt()
    {
        Random _randomNumberGenerator = new Random();
        int index = _randomNumberGenerator.Next(_prompts.Count);
        return _prompts[index];
    }

}
