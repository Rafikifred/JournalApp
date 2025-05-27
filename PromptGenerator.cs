using System;
using System.Collections.Generic;

/// <summary>
/// Provides random prompts for journal entries.
/// </summary>
public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the highlight of your day?",
        "What are you grateful for today?",
        "What challenges did you face today?",
        "Describe something you learned today.",
        "How did you show kindness today?"
    };

    private Random _random = new Random();

    /// <summary>
    /// Gets a random prompt from the list.
    /// </summary>
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
