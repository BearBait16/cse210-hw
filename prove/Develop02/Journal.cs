namespace JournalWriter;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (var x in _entries)
        { Console.WriteLine($"Date: {x._date} \n------------------\n Prompt: {x._prompt}\n Response: {x._response}\n"); }

    }
    public void Save()
    {
        Console.WriteLine("Write the name of the file you would like to save too. IE example.txt");
        var _textFileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_textFileName))
        {
            foreach (var x in _entries)
            {
                outputFile.WriteLine($"Date: {x._date} ~ Prompt: {x._prompt} ~ Response: {x._response}");
            }

        }
    }
    public void Load()
    {
        Console.WriteLine("Write the name of the file you would like to Load. IE example.txt");
        var _textFileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(_textFileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(new[] { "~" }, StringSplitOptions.None);
            string lineDate = parts[0];
            string linePrompt = parts[1];
            string lineResponse = parts[2];
            Entry NewEntry = new Entry
            {
                _date = lineDate,
                _prompt = linePrompt,
                _response = lineResponse
            };
            _entries.Add(NewEntry);
        }
    }
    // if (_textFileName)
}
