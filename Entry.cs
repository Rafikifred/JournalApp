using System;

/// <summary>
/// Represents a single journal entry.
/// </summary>
public class Entry
{
    /// <summary>
    /// The date the entry was created.
    /// </summary>
    public string _date;

    /// <summary>
    /// The prompt used for the entry.
    /// </summary>
    public string _promptText;

    /// <summary>
    /// The user's response.
    /// </summary>
    public string _entryText;

    /// <summary>
    /// Creates a new journal entry with a prompt and user input.
    /// </summary>
    public Entry(string prompt, string entry)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd");
        _promptText = prompt;
        _entryText = entry;
    }

    /// <summary>
    /// Returns a formatted string for display.
    /// </summary>
    public string Display()
    {
        return $"{_date} - Prompt: {_promptText}\nResponse: {_entryText}\n";
    }

    /// <summary>
    /// Returns a string formatted for saving to a file.
    /// </summary>
    public string ToFileFormat()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    /// <summary>
    /// Parses an entry from a file-formatted string.
    /// </summary>
    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split('|');
        return new Entry(parts[1], parts[2]) { _date = parts[0] };
    }
}