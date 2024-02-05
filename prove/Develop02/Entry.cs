using System.Reflection.Metadata.Ecma335;

namespace JournalWriter;
using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Entry
{
    public string _response;
    public string _prompt;
    public string _date;
    public List<string> _prompts = new List<string>();

    public Entry MakeEntry()
    {
        Console.WriteLine(GeneratePrompt());
        string newresponse = Console.ReadLine();
        Entry newEntry = new Entry
        {
            _date = DateTime.Now.ToString(),
            _prompt = GeneratePrompt(),
            _response = newresponse
        };
        return newEntry;
    }
    // Who was the most interesting person I interacted with today?
    // What was the best part of my day?
    // How did I see the hand of the Lord in my life today?
    // What was the strongest emotion I felt today?
    // If I had one thing I could do over today, what would it be?
    public string GeneratePrompt()
    {
        Console.Clear();
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");

        var _randomPrompt = new Random();
        int index = _randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }
}