using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Text { get; set; }

    public Entry(string prompt, string text)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd");
        Prompt = prompt;
        Text = text;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nEntry: {Text}\n";
    }
}
