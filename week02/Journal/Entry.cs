using System;

public class Entry
{
    public string _date;

    public string _randomPrompt;

    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_date}\n{_randomPrompt}\n{_entryText}");
    }
}