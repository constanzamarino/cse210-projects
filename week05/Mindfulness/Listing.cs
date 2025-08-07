using System;
using System.Threading.Channels;
using System.IO;

public class Listing : Activity
{
    private int _count;
    private List<string> _prompts;

    public Listing(string name, string description, int timeDuration, int count) : base(name, description, timeDuration)
    {
        _prompts = new List<string>();
        _count = count;
    }

    public void RunListingActivity()
    {

    }

    public List<string> GetListFromUser()
    {
        return _prompts;
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



    
}