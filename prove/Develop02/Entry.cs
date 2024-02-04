using System.Reflection.Metadata.Ecma335;

namespace JournalWriter;
using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Entry
{
    public string _response;
    public string _prompt;
    public string _date;
    public List<string> _prompts = new List<string>();


    public string MakeEntry()
    {
        Console.WriteLine(GeneratePrompt());
        string _response = Console.ReadLine();
        return _response;
    }
    void Display()
    {
        System.Console.WriteLine();
    }

    // Who was the most interesting person I interacted with today?
    // What was the best part of my day?
    // How did I see the hand of the Lord in my life today?
    // What was the strongest emotion I felt today?
    // If I had one thing I could do over today, what would it be?
    public string GeneratePrompt()
    {
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