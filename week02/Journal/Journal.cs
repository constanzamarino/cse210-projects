using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        string date = DateTime.Now.ToShortDateString();

        Console.WriteLine("");
        string text = Console.ReadLine();

        Entry newEntry = new Entry();
        newEntry._date = date;
        newEntry._randomPrompt = "";
        newEntry._entryText = text;

        _entries.Add(newEntry);

    }

    public void Display()
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
        
    }

    public void LoadFromFile()
    {

    }
}
