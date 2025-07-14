using System;

public class Entry
{
    
    public string _date;

    public string _userName;

    public string _randomPrompt;

    public string _entryText;

  

    public void Display()
    {
        Console.WriteLine($"By: {_userName}\n{_date}\n{_randomPrompt}\n{_entryText}\n");
    }
}