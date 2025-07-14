using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {

        string date = DateTime.Now.ToShortDateString();

        Console.WriteLine("Enter your name:");
        string user_name = Console.ReadLine();

        PromptGenerator generator = new PromptGenerator();
        string _randomPrompt = generator.GetRandomPrompt();

        Console.WriteLine($"{_randomPrompt}");
        Console.WriteLine($"Your entry: ");
        string text = Console.ReadLine();

        Entry newEntry = new Entry();
        newEntry._date = date;
        newEntry._userName = user_name;
        newEntry._randomPrompt = _randomPrompt;
        newEntry._entryText = text;
        _entries.Add(newEntry);
       

    }


    public void DisplayJournal()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }
        foreach (Entry entry in _entries)
            {
                entry.Display();
            }

    }

    public void SaveToFile()

    {
        Console.WriteLine("Enter the name of your file to save the journal:");
        string filename = Console.ReadLine();
        using (StreamWriter file = new StreamWriter(filename))

        {
            foreach (Entry entry in _entries)
            {
                file.WriteLine($"{entry._date}~~{entry._userName}~~{entry._randomPrompt}~~{entry._entryText}");
            }
        }
        Console.WriteLine($"Journal saved successfully to {filename}.");

        
    }


    public void LoadFromFile()
    {
        Console.WriteLine("Enter the name of your journal's file to load it:");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. Please, check if the file name is the correct one and try again.");
            return;
        }

        string[] journal_lines = System.IO.File.ReadAllLines(filename);

        foreach (string journal_line in journal_lines)
        {

            string[] parts = journal_line.Split("~~");

            if (parts.Length == 4)
            {
            string _date = parts[0];
            string _userName = parts[1];
            string _randomPrompt = parts[2];
            string _entryText = parts[3];

            Entry loadEntry = new Entry();
            loadEntry._date = _date;
            loadEntry._userName = _userName;
            loadEntry._randomPrompt = _randomPrompt;
            loadEntry._entryText = _entryText;

            _entries.Add(loadEntry);
            } 

        }
        Console.WriteLine($"Journal loaded successfully from {filename}.");



    }

    
}
