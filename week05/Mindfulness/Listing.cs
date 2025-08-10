using System;
using System.Threading;
using System.IO;

public class Listing : Activity
{
    private List<string> _prompts;

    List<string> _userResponses;

    public Listing(string name, string description, int timeDuration, int count) : base(name, description, timeDuration)
    {
        _name = "\n***Listing Activity***";
        _description = "\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";


        _prompts = new List<string>()
        {
            "What fears have you overcome as you've grown or changed?",
            "What are some things that make you happy?",
            "What are a few places you like or would like to visit?",
            "Who are some people you appreciate in your life?",
            "Which songs you think describe your personality or life?",
            "Which movies or series made you cry?",
            "What do you like to do in your free time?",
            "Which are some jobs you would love to do?"
        };

        _userResponses = new List<string>();
    }

    public void RunListingActivity()
    {
        DisplayStartingMessage();
        int sessionTime3 = AskDuration();

        string prompt = _prompts[new Random().Next(_prompts.Count)];


        DateTime startTime = DateTime.Now;
        Console.Write("\nIt begins in: ");
        ShowCountDown(5);
        Console.WriteLine($"\nType as many responses as you can according to this prompt:\n -- {prompt} --\n");

        while ((DateTime.Now - startTime).TotalSeconds < _timeDuration)
        {
            string response = Console.ReadLine();
            _userResponses.Add(response);

        }
        Console.WriteLine($"\nYou listed {_userResponses.Count} items.\n");
        DisplayEndingMessage();
        DisplayActivityDate();
    }

    public void SaveListingActivity()
    {
        if (_userResponses.Count == 0)
        {
            Console.WriteLine("No listing responses to save.");
            return;
        }

        Console.WriteLine("Enter the name of your file to save your Listing Activity: ");
        string filePath2 = Console.ReadLine();

        using (StreamWriter userFile2 = new StreamWriter(filePath2, append: true))
        {
            userFile2.WriteLine($"--- Listing Activity ({DateTime.Now}) ---");

            Console.WriteLine("Responses:");
            foreach (string response in _userResponses)
            {
                userFile2.WriteLine(response);
            }
            userFile2.WriteLine($"Listing Activity has been saved successfully in {filePath2}.");

        }

    }

    public List<string> GetPromptsList()
    {
        return _prompts;
    }
     public List<string> GetListFromUser()
    {
        return _userResponses;
    }



    
}