namespace JournalWriter;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (var x in _entries)
        { System.Console.WriteLine($"Date: {x._date} \n------------------\n Prompt: {x._prompt}\n Response: {x._response}"); }

    }
    public void Save()
    {
        System.Console.WriteLine("Write the name of the file you would like to save too. IE example.txt");
        var _textFileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_textFileName))
        {
            outputFile.WriteLine("Date");
            outputFile.WriteLine(_textFileName);
        }
    }

    public void Load()
    {

    }

}