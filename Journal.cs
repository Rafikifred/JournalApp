using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Represents the user's journal.
/// </summary>
public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    /// <summary>
    /// Prompts the user to write a new journal entry.
    /// </summary>
    public void WriteNewEntry()
    {
        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("> ");
        string? response = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(response))
        {
            Console.WriteLine("Entry cannot be empty.");
            return;
        }

        Entry newEntry = new Entry(prompt, response);
        _entries.Add(newEntry);
    }

    /// <summary>
    /// Displays all journal entries.
    /// </summary>
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.Display());
        }
    }

    /// <summary>
    /// Saves journal entries to a file.
    /// </summary>
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToFileFormat());
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    /// <summary>
    /// Loads journal entries from a file.
    /// </summary>
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                Entry entry = Entry.FromFileFormat(line);
                _entries.Add(entry);
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}