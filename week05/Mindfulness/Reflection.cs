using System;
using System.Collections.Generic;
using System.IO;

public class Reflection : Activity
{
    private List<string> _questions;

    private List<string> _randomPrompts;

    private List<string> _userAnswers;


    public Reflection(string name, string description, int timeDuration) : base(name, description, timeDuration)
    {
        _name = "\n***Reflection Activity***";
        _description = "\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _randomPrompts = new List<string>()
        {
        "Think of a time when you helped someone out of selflessness",
        "Think of a time when you achieved something difficult you have been trying to achieve for a while",
        "Think of a time when you faced a challenge or a difficult situation despite being broken",
        "Think of a time when you had to make a hard decision",
        "Think of a time when you stepped out of your comfort zone (new experiences, new abilities, etc)"
        };

        _questions = new List<string>()
        {
            "What motivated you to take action, even when it was difficult or uncomfortable?",
            "What obstacles did you face, and how did you overcome them?",
            "How did the experience change the way you see yourself or the world?",
            "What lesson did you learn that still stays with you today?",
            "How did that moment shape your future choices, attitude, or path?"
        };

        _userAnswers = new List<string>();

    }

    public void RunReflectionActivity()
    {

        DisplayStartingMessage();
        int sessionTime2 = AskDuration();

        Console.WriteLine("Get ready...");
        ShowTheSpinner(5);

        int lapse = 0;

        while (lapse < _timeDuration)
        {
            Console.WriteLine("\nConsider this prompt:");
            string aRandomPrompt = GetRandomPrompt();
            Console.WriteLine($"\n--->{aRandomPrompt}<---\n");
            Console.WriteLine("Press 'enter' to continue once you have typed according to the prompt.");
            Console.ReadLine();

            foreach (string question in _questions)
            {
                if (lapse >= _timeDuration) break;

                Console.Write(question);
                string user_answers = Console.ReadLine();
                _userAnswers.Add(user_answers);

                ShowCountDown(5);
                lapse += 5;
            }
        }
        DisplayEndingMessage();
        DisplayActivityDate();
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
        foreach (var prompt in _randomPrompts)
        {
            Console.WriteLine($"{prompt}");
        }

    }

    public void DisplayQuestions()
    {
        foreach (var question in _questions)
        {
            Console.WriteLine(question);
        }
    }

    public void SaveReflectionActivity()
    {
        if (_userAnswers.Count == 0)
        {
            Console.WriteLine("No reflection responses to save.");
            return;
        }
        userFile.WriteLine("Enter the name of your file to save the Reflection Activity: ");
        string filePath = Console.ReadLine();

        using (StreamWriter userFile = new StreamWriter(filePath, append: true))
        {
            Console.WriteLine($"--- Reflection Activity ({DateTime.Now}) ---");

            userFile.WriteLine("Answers:");
            foreach (string answer in _userAnswers)
            {
                userFile.WriteLine(answer);
            }

            userFile.WriteLine();
        }

        Console.WriteLine($"Reflection Activity has been saved in {filePath}");
    }
}