using System;
using System.Threading.Channels;
using System.IO;

public class Reflection : Activity
{
    private List<string> _questions;

    private List<string> _randomPrompts;

    public Reflection(string name, string description, int timeDuration) : base(name, description, timeDuration)
    {
        _randomPrompts = new List<string>()
        {
        "Think of a time when you helped someone out of selflessness.",
        "Think of a time when you achieved something difficult you have been trying to achieve for a while.",
        "Think of a time when you faced a challenge or a difficult situation despite being broken.",
        "Think of a time when you had to make a hard decision.",
        "Think of a time when you stepped out of your comfort zone (new experiences, new abilities, etc)."
        };

         _questions = new List<string>()
        {
            "What motivated you to take action, even when it was difficult or uncomfortable?",
            "What obstacles did you face, and how did you overcome them?",
            "How did the experience change the way you see yourself or the world?",
            "What lesson did you learn that still stays with you today?",
            "How did that moment shape your future choices, attitude, or path?"
        };
        

    }

    public void RunReflectionActivity()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        GetQuestions();
        DisplayEndingMessage();
        
    }

    public string GetRandomPrompt()
    {
        Random aRandomPrompt = new Random();
        int index2 = aRandomPrompt.Next(_randomPrompts.Count);
        return _randomPrompts[index2];
    }

    public string GetQuestions()
    {
        Random aRandomQuestion = new Random();
        int index = aRandomQuestion.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(_randomPrompts);
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(_questions);
    }

    public void SaveReflectionActivity()
    {
        Console.WriteLine("Enter the name of your file to save the Reflection Activity: ");
        string userFilename = Console.ReadLine();

        using (StreamWriter userFile = new StreamWriter(userFilename))
        {
            DateTime activityDate = new DateTime();
            userFile.WriteLine("Date: " + activityDate.ToString("yyyy-MM-dd HH:mm"));
            userFile.WriteLine("Questions:");
            foreach (string questions in _questions)
            {
                userFile.Write(questions);
            }

            userFile.WriteLine("Prompts:");
            foreach (string aRandomPrompt in _randomPrompts)
            {
                userFile.Write(aRandomPrompt);
            }
     
            
        }
    }


}