using System;
using System.Threading.Channels;
using System.IO;

public class Listing : Activity
{
    private int _count;
    private List<string> _prompts;

    public Listing(string name, string description, int timeDuration, int count) : base(name, description, timeDuration)
    {
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
        _count = count;
    }

    public void RunListingActivity()
    {
        DisplayStartingMessage();
        DisplayEndingMessage();
    }

    public void SaveListingActivity()
    {
        Console.WriteLine("Enter the name of your file to save your Listing Activity: ");
        string userFilename2 = Console.ReadLine();

        using (StreamWriter userFile2 = new StreamWriter(userFilename2))
        {
            DateTime activityDate2 = new DateTime();
            userFile2.WriteLine("Date " + activityDate2.ToString("yyyy-MM-dd HH:mm"));
            Console.WriteLine("Prompts:");
            foreach (string prompt in _prompts)
            {
                Console.WriteLine(prompt);
            }
        }

    }
    
     public List<string> GetListFromUser()
    {
        return _prompts;
    }



    
}