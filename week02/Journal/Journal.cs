using System;

using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {

    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        
    }

    public void LoadFromFile()
    {

    }
}

