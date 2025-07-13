using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        string date = DateTime.Now.ToShortDateString();
        
        PromptGenerator generator = new PromptGenerator();
        generator.LoadRandomPrompt();
        string _randomPrompt = generator.GetRandomPrompt();

        Console.WriteLine("");
        string text = Console.ReadLine();

        Entry newEntry = new Entry();
        newEntry._date = date;
        newEntry._randomPrompt = _randomPrompt;
        newEntry._entryText = text;

        _entries.Add(newEntry);

    }
    

    public void DisplayJournal()
    {

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public static void SaveToFile(List<Entry> _entries)

    {
        string filename = "";
        using (StreamWriter file = new StreamWriter(filename))

        {
            foreach (Entry newEntry in _entries)
            {
                file.WriteLine($"{newEntry._date}~~{newEntry._randomPrompt}~~{newEntry._entryText}");
            }
        }
        Console.WriteLine($"Journal saved succesfully to {filename}.");
    }

    public void LoadFromFile()
    {
        

    }
}
