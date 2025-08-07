using System;
using System.Threading.Channels;
using System.IO;

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